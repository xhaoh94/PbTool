using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbTool
{
    public class WriteData
    {
        string content;
        bool newLine;
        public WriteData(string _content)
        {
            content = _content;
        }
        public WriteData()
        {
            content = string.Empty;
        }
        public void Writeln()
        {
            content += "\n";
            newLine = true;
        }
        public void Writeln(string add, bool isBlock = true)
        {
            if (isBlock)
            {
                foreach (var b in block)
                {
                    content += b;
                }
            }
            content += add + "\n";
            newLine = true;
        }
        public void Write(string add, bool isBlock = true)
        {
            if (isBlock)
            {
                foreach (var b in block)
                {
                    content += b;
                }
            }
            content += add;
            newLine = false;
        }

        List<string> block = new List<string>();
        public void StartBlock()
        {
            Writeln("{", newLine);
            block.Add("\t");
        }
        public void EndBlock(bool isLn = true)
        {
            block.RemoveAt(0);
            if (isLn)
                Writeln("}");
            else
                Write("}");
        }

        public void Export(string path, string fileName)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path += $"/{fileName}";
            if (!File.Exists(path))
            {
                File.CreateText(path).Dispose();
            }
            File.WriteAllText(path, content, Encoding.UTF8);
        }
    }
}
