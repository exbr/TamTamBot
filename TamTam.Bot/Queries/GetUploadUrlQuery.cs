using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
  public  class GetUploadUrlQuery: TamTamQuery<UploadEndpoint>
  {
      private readonly QueryParam<UploadType> _type ;

      public GetUploadUrlQuery(TamTamClient client, UploadType type)
          :base(client, "/uploads", null,  Method.POST)
      {
          _type = new QueryParam<UploadType>("type",type, this).Required();
      }

      public UploadType Type
      {
          get => _type.Value;
          set => _type.Value = value;
      }

  }
}
