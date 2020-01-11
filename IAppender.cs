using System.Threading.Tasks;

namespace RegexDelegate
{
    public interface IAppender
    {
        Task<string> AppendAsync(string term);
    }
}
