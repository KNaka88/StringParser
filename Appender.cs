using System.Threading.Tasks;

namespace RegexDelegate
{
    public class Appender : IAppender
    {
        public async Task<string> AppendAsync(string term)
        {
            return await Task.FromResult("Ghone");
        }
    }
}
