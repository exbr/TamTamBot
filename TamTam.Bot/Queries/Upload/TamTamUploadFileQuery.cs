using System.IO;
using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries.Upload
{
    public class TamTamUploadFileQuery : TamTamUploadQuery<UploadedInfo>
    {
        public TamTamUploadFileQuery(TamTamClient tamTamClient, string url, FileInfo file)
            : base(tamTamClient, url, file)
        {
        }

        public TamTamUploadFileQuery(TamTamClient tamTamClient, string url, string fileName, Stream input)
            : base(tamTamClient, url, fileName, input)
        {
        }
    }
}
