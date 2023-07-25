﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PbTool
{
    internal class PbCSharpBase : PbBase
    {
        Regex CS = new Regex(@"(//(cs|CS)=)(?<cmd>([1-9][0-9]*))(message )(?<title>(\w|_)+)");
        Regex SC = new Regex(@"(//(sc|SC)=)(?<cmd>([1-9][0-9]*))(message )(?<title>(\w|_)+)");
        Regex BCST = new Regex(@"(//(BCST|bcst)=)(?<cmd>([1-9][0-9]*))(message )(?<title>(\w|_)+)");
        protected override bool OnParse()
        {
            return true;
        }

        protected override void OnCreateCmd()
        {
            var files = GetProtoFiles();
            if (files == null) return;

            var csWd = new WriteData();
            csWd.Writeln(@"//自动生成的代码，请勿修改!!!");
            csWd.Writeln($"namespace {Program.NameSpace}");


            var scWd = new WriteData();
            scWd.Writeln(@"//自动生成的代码，请勿修改!!!");
            scWd.Writeln($"namespace {Program.NameSpace}");

            var bcstWd = new WriteData();
            bcstWd.Writeln(@"//自动生成的代码，请勿修改!!!");
            bcstWd.Writeln($"namespace {Program.NameSpace}");

            csWd.StartBlock();
            scWd.StartBlock();
            bcstWd.StartBlock();

            csWd.Writeln("public enum CS");
            scWd.Writeln("public enum SC");
            bcstWd.Writeln("public enum BCST");

            csWd.StartBlock();
            scWd.StartBlock();
            bcstWd.StartBlock();
            foreach (var file in files)
            {
                var str = File.ReadAllText(file);
                ParseMeesage(str, csWd, scWd, bcstWd);
            }
            csWd.EndBlock();
            scWd.EndBlock();
            bcstWd.EndBlock();


            csWd.EndBlock();
            scWd.EndBlock();
            bcstWd.EndBlock();

            csWd.Export(OutPath, "CS");
            scWd.Export(OutPath, "SC");
            bcstWd.Export(OutPath, "BCST");
        }

        void ParseMeesage(string str, WriteData csWd, WriteData scWd, WriteData bcstWd)
        {
            str = str.Replace("\r", "");
            str = str.Replace("\n", "");
            var matches = CS.Matches(str);
            foreach (Match match in matches)
            {
                var context = match.Value;
                var cmd = int.Parse(match.Groups["cmd"].Value);
                var title = match.Groups["title"];
                csWd.Writeln($"{title} = {cmd},");
            }

            matches = SC.Matches(str);
            foreach (Match match in matches)
            {
                var context = match.Value;
                var cmd = int.Parse(match.Groups["cmd"].Value);
                var title = match.Groups["title"];
                scWd.Writeln($"{title} = {cmd},");
            }

            matches = BCST.Matches(str);
            foreach (Match match in matches)
            {
                var context = match.Value;
                var cmd = int.Parse(match.Groups["cmd"].Value);
                var title = match.Groups["title"];
                bcstWd.Writeln($"{title} = {cmd},");
            }
        }
    }
    [Pb("csharp")]
    internal class PbCSharp : PbCSharpBase
    {
        [JsonPropertyName("protoc")]
        [JsonInclude]
        public string Protoc = string.Empty;

        protected override bool OnParse()
        {
            if (string.IsNullOrEmpty(Protoc))
            {
                Protoc = System.IO.Path.GetFullPath("./protoc.exe").Replace("\\", "/");
            }
            if (!File.Exists(Protoc))
            {
                Program.LogError("没找到protoc.exe");
                return false;
            }

            var files = GetProtoFiles();
            if (files == null)
            {
                Program.LogError("没有找到Proto文件");
                return false;
            }

            var exe = $"--proto_path={InPath} --csharp_out={OutPath}";
            foreach (var file in files)
            {
                var temFile = GetFileName(file, out var dirName);
                Console.WriteLine(temFile);
                if (!Directory.Exists($"{OutPath}/{dirName}"))
                {
                    Directory.CreateDirectory($"{OutPath}/{dirName}");
                }
                Command.Run(Protoc, $"{exe}/{dirName} {temFile}");
            }

            return true;
        }

        public string GetFileName(string filePath, out string dirName)
        {
            filePath = filePath.Replace("\\", "/");
            filePath = filePath.Replace(InPath + "/", "");
            var index = filePath.LastIndexOf("/");
            if (index == -1)
            {
                dirName = string.Empty;
            }
            else
            {
                dirName = filePath.Substring(0, index);
            }
            return filePath;
        }
    }
    [Pb("csharp_pbnet")]
    internal class PbCSharpNet : PbCSharpBase
    {
        [JsonPropertyName("protobufNet")]
        [JsonInclude]
        public string Protoc = string.Empty;

        protected override bool OnParse()
        {
            if (string.IsNullOrEmpty(Protoc))
            {
                Protoc = System.IO.Path.GetFullPath("./protobuf/protogen.exe").Replace("\\", "/");
            }
            if (!File.Exists(Protoc))
            {
                Program.LogError("没找到protogen.exe");
                return false;
            }
            var files = GetProtoFiles();
            if (files == null)
            {
                Program.LogError("没有找到Proto文件");
                return false;
            }

            var exe = $"--proto_path={InPath} --csharp_out={OutPath} ";
            foreach (var file in files)
            {
                var temFile = GetFileName(file);
                Command.Run(Protoc, exe + temFile);
            }
            return true;
        }

        public string GetFileName(string filePath)
        {
            filePath = filePath.Replace("\\", "/");
            return filePath.Replace(InPath + "/", "");
        }
    }
}
