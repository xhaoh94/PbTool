using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PbTool
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class PbAttribute : Attribute
    {
        public string name { get; }
        public PbAttribute(string name)
        {
            this.name = name;
        }
    }

    internal interface IPb
    {
        void Parse(string configPath);
    }

    internal abstract class PbBase : IPb
    {
        protected readonly Regex CS = new Regex(@"(//(cs|CS)=)(?<cmd>([1-9][0-9]*))(message )(?<title>(\w|_)+)");
        protected readonly Regex SC = new Regex(@"(//(sc|SC)=)(?<cmd>([1-9][0-9]*))(message )(?<title>(\w|_)+)");
        protected readonly Regex BCST = new Regex(@"(//(BCST|bcst)=)(?<cmd>([1-9][0-9]*))(message )(?<title>(\w|_)+)");
        protected string ConfigPath { get; private set; } = string.Empty;

        [JsonPropertyName("in_path")]
        [JsonInclude]
        public string InPath = string.Empty;
        [JsonPropertyName("out_path")]
        [JsonInclude]
        public string OutPath = string.Empty;

        protected string GetPaserPath(string path)
        {
            int index = 0;
            while (true)
            {
                if (path.StartsWith("./"))
                {
                    index++;
                    path = path.Substring(2);
                }
                else
                {
                    break;
                }
            }

            if (index == 0)
            {
                return path;
            }
            int temCnt = 0;

            for (int i = ConfigPath.Length - 1; i >= 0; i--)
            {
                if (ConfigPath[i] == '/')
                {
                    temCnt++;
                }
                if (index == temCnt)
                {
                    index = i;
                    break;
                }
            }
            path = Path.Combine(ConfigPath.Substring(0, index), path).Replace("\\", "/"); ;
            return path;
        }
        public void Parse(string configPath)
        {
            ConfigPath = System.IO.Path.GetFullPath(configPath).Replace("\\", "/");
            if (!string.IsNullOrEmpty(Program.InPath))
            {
                InPath = Program.InPath;
            }
            if (!string.IsNullOrEmpty(Program.OutPath))
            {
                OutPath = Program.OutPath;
            }

            if (string.IsNullOrEmpty(InPath))
            {
                Program.LogError("Proto目录不能为空");
                return;
            }
            InPath = System.IO.Path.GetFullPath(InPath).Replace("\\", "/");
            if (!Directory.Exists(InPath))
            {
                Program.LogError("Proto目录不存在");
                return;
            }

            OutPath = System.IO.Path.GetFullPath(OutPath).Replace("\\", "/");

            Console.WriteLine($"Proto目录:{InPath}");
            Console.WriteLine($"导出目录:{OutPath}");
            if (Directory.Exists(OutPath))
            {
                try
                {
                    Directory.Delete(OutPath, true);
                }
                catch
                {
                    Program.LogError("导出目录有文件被其他进程占用，无法删除");
                    return;
                }
            }
            Directory.CreateDirectory(OutPath);
            if (!OnParse())
            {
                return;
            }
            OnCreateCmd();
            Console.WriteLine("success");
        }
        protected abstract bool OnParse();

        protected abstract void OnCreateCmd();

        public string[]? GetProtoFiles()
        {
            var files = Directory.GetFiles(InPath, "*.proto", SearchOption.AllDirectories);
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = files[i].Replace("\\", "/");
            }
            return files;
        }


    }

}
