using System.Threading;
using System.Threading.Tasks;

namespace ExLib.TamTam.Bot.Queries
{
    public interface ITamTamQuery<T>
    {
        void AddParam(IQueryParam queryParam);

        Task<T> Execute(CancellationToken cancellationToken = default);
    }

    public interface ITamTamQuery
    {
        void AddParam(IQueryParam queryParam);

        Task Execute(CancellationToken cancellationToken = default);

    }
}
