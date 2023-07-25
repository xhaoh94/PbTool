using PbTool;
using System.Text.Json;
using System.Text.Json.Nodes;

internal class Program
{
    public static string InPath = string.Empty;
    public static string OutPath = string.Empty;
    public static string NameSpace = "Pb";
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            LogError("需要传入启动参数");
            return;
        }
        string confgPath = "./Config.json";
        string name = string.Empty;
        foreach (string arg in args)
        {
            var list = arg.Split('=');
            switch (list[0])
            {
                case "-config":
                    confgPath = list[1];
                    break;
                case "-type":
                    name = list[1];
                    break;
                case "-inpath":
                    InPath = list[1];
                    break;
                case "-outpath":
                    OutPath = list[1];
                    break;
                case "-namespace":
                    NameSpace = list[1];
                    break;
            }
        }
        if (string.IsNullOrEmpty(name))
        {
            LogError("需要指定解析类型");
            return;
        }
        var jsonStr = File.ReadAllText(confgPath);
        var jObject = JsonObject.Parse(jsonStr);
        if (jObject == null)
        {
            LogError("配置文件解析出错");
            return;
        }

        var obj = jObject[name];
        if (obj == null)
        {
            LogError("暂无法解析" + name);
            return;
        }

        foreach (var ator in typeof(IPb).Assembly.GetTypes())
        {
            object[] attrbutes = ator.GetCustomAttributes(typeof(PbAttribute), false);
            if (attrbutes.Length > 0)
            {
                var arrt = attrbutes[0] as PbAttribute;
                if (arrt != null && arrt.name == name)
                {
                    var temStr = obj.ToJsonString();
                    var pb = JsonSerializer.Deserialize(temStr, ator) as IPb;
                    pb?.Parse();
                    break;
                }
            }
        }
    }

    public static void LogError(string str)
    {
        Console.WriteLine(str);
        Console.ReadKey();
    }
}