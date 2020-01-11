using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDelegate
{
    public class HelloWorldReplacer : IRegexExecutor
    {
        public Task<string> ReplaceAsync(string term)
        {
            return Task.FromResult(Regex.Replace(term, @"^HelloWorld", "Hello Japan")); 
        }
    }
}
