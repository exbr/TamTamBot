using System.IO;
using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries.Upload
{
    public class TamTamUploadImageQuery : TamTamUploadQuery<PhotoTokens>
    {
        public TamTamUploadImageQuery(TamTamClient tamTamClient, string url, string fileName, Stream input)
            : base(tamTamClient, url, fileName, input)
        {
        }
    }
}
