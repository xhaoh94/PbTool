# PbTool
pbtool.exe -config=./Config.json -type=csharp -inpath="./protofiles" -outpath="./out" -namespace="pb"
其中 config和type是必要参数
inpath、outpath、namespace可选参数
inpath:proto文件根目录，如果没有则使用配置里面的目录
outpath:导出目录，如果没有则使用配置里面的目录
namespace:导出cmd文件命名空间，如果没有则默认为："pb"
