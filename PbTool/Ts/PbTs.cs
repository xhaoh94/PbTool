using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PbTool
{
    [Pb("ts")]
    internal class PbTs : PbBase
    {
        [JsonPropertyName("tsdpb")]
        [JsonInclude]
        public string Tsdpb = string.Empty;

        [JsonPropertyName("createjson")]
        [JsonInclude]
        public bool CreateJson = false;

        [JsonPropertyName("usemodule")]
        [JsonInclude]
        public bool UseModule = true;

        protected override void OnCreateCmd()
        {
            
        }

        protected override bool OnParse()
        {
            if (string.IsNullOrEmpty(Tsdpb))
            {
                Tsdpb = System.IO.Path.GetFullPath("./tsdpb.exe").Replace("\\", "/");
            }
            if (!File.Exists(Tsdpb))
            {
                Program.LogError("没找到tsdpb.exe");
                return false;
            }

            var exe = $"-inpath={InPath} -outpath={OutPath} -namespace={Program.NameSpace} -createjson={CreateJson} -usemodule={UseModule}";
            Command.Run(Tsdpb, $"{exe}");
            return true;
        }
    }
}
