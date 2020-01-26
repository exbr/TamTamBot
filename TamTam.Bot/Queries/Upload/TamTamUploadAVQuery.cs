using System;
using System.IO;
using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries.Upload
{
    public class TamTamUploadAVQuery : TamTamUploadQuery<UploadedInfo>
    {
        public TamTamUploadAVQuery(TamTamClient tamTamClient, String url, FileInfo file)
            : base(tamTamClient, url, file)
        {
        }

        public TamTamUploadAVQuery(TamTamClient tamTamClient, String url, String fileName, Stream input)
            : base(tamTamClient, url, fileName, input)
        {
        }
    }
}
