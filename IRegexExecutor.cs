using System;
using System.Threading.Tasks;

namespace RegexDelegate
{
    public interface IRegexExecutor
    {
        Task<string> ReplaceAsync(string term);
    }
}
