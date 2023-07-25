using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
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
        void Parse();
    }

    internal abstract class PbBase : IPb
    {
        [JsonPropertyName("inPath")]
        [JsonInclude]
        public string InPath = string.Empty;
        [JsonPropertyName("outPath")]
        [JsonInclude]
        public string OutPath = string.Empty;

        public void Parse()
        {
            if (!string.IsNullOrEmpty(Program.InPath))
            {
                InPath = Program.InPath;
            }
            if (!string.IsNullOrEmpty(Program.OutPath))
            {
                InPath = Program.OutPath;
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
                Directory.Delete(OutPath, true);
            }
            Directory.CreateDirectory(OutPath);
            OnParse();

            OnCreateCmd();
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
