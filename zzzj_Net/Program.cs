using FlashWing.HIME.Model.Common.Protocol;
using FlashWing.HIME.Script.Model.Common.Protocol;
using Newtonsoft.Json;
using ProtoBuf;
using ProtoBuf.Meta;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zzzj_Net
{
    internal class Program
    {
        public static byte[] Compress(byte[] data)
        {
            var ms = new MemoryStream();
            using (var gzip = new GZipStream(ms, CompressionLevel.Optimal))
            {
                gzip.Write(data, 0, data.Length);
            }
            return ms.ToArray();
        }

        public static byte[] Decompress(byte[] data)
        {
            var input = new MemoryStream(data);
            var gzip = new GZipStream(input, CompressionMode.Decompress);
            var output = new MemoryStream();
            gzip.CopyTo(output);
            return output.ToArray();
        }
        static void Main(string[] args)
        {
            string run_type = args[0];
            string file_name = args[1];
            string output_json = file_name + ".json";
            byte[] fileBytes = File.ReadAllBytes(file_name);
            using (var stream = new MemoryStream(fileBytes))
            {
                try
                {
                    if(run_type == "req")
                    {
                        RequestOperation request = Serializer.Deserialize<RequestOperation>(stream);
                        Console.WriteLine("解析成功！");
                        string jsonContent = JsonConvert.SerializeObject(request, Formatting.Indented);
                        File.WriteAllText(output_json, jsonContent);
                    }
                    if(run_type == "resp")
                    {
                        ResponsePack request = Serializer.Deserialize<ResponsePack>(stream);
                        Console.WriteLine("解析成功！");
                        Console.WriteLine(string.Format("IsGZip:{0}\nDataLen:{1}\n",request.IsGZip,request.Data.Length));
                        ResponseOperation responseOperation;
                        byte[] resp_data = request.Data;
                        if (request.IsGZip)
                        {
                            resp_data = Decompress(request.Data);
                        }
                        responseOperation = Serializer.Deserialize<ResponseOperation>(new MemoryStream(resp_data));
                        string jsonContent = JsonConvert.SerializeObject(responseOperation, Formatting.Indented);
                        Console.WriteLine(jsonContent);
                        //save file
                        File.WriteAllText(output_json, jsonContent);
                    }
                }
                catch (ProtoBuf.ProtoException ex)
                {
                    Console.WriteLine($"解析失败: {ex.Message}");
                    // 如果这里还报错，说明垃圾数据在有效数据中间，而不是末尾
                }
            }
        }
    }
}
