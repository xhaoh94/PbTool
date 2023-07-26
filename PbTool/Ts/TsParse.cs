using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbTool
{
    internal class TsParse
    {        
        public static string GetString(string str)
        {
            return "\"" + str + "\"";
        }
        public static string GetString(int str)
        {
            return "\"" + str + "\"";
        }
        public static string GetType(string str)
        {
            switch (str)
            {
                case "bool":
                    return "boolean";
                case "string":
                    return "string";
                case "bytes":
                    return "Uint8Array";
                case "float":
                    return "number";
                case "double":
                    return "number";
                case "enum":
                    return "enum";
                case "int32":
                    return "number";
                case "int64":
                    return "number|Long";
                case "uint32":
                    return "number";
                case "uint64":
                    return "number|Long";
                case "sint32":
                    return "number";
                case "sint64":
                    return "number|Long";
                case "fixed32":
                    return "number";
                case "fixed64":
                    return "number|Long";
                case "sfixed32":
                    return "number";
                case "sfixed64":
                    return "number|Long";
                default:
                    return str;
            }
        }
        public static string GetId(string str)
        {
            switch (str)
            {
                case "bool":
                    return "0";
                case "string":
                    return "1";
                case "bytes":
                    return "2";
                case "float":
                    return "3";
                case "double":
                    return "4";
                case "int32":
                    return "6";
                case "int64":
                    return "7";
                case "uint32":
                    return "8";
                case "uint64":
                    return "9";
                case "sint32":
                    return "10";
                case "sint64":
                    return "11";
                case "fixed32":
                    return "12";
                case "fixed64":
                    return "13";
                case "sfixed32":
                    return "14";
                case "sfixed64":
                    return "15";
                default:
                    return str;
            }
        }

    }
}
