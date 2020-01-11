using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDelegate
{
    public class MrBeanParser : IRegexExecutor
    {
        private IAppender _appender;

        public MrBeanParser(IAppender appender)
        {
            _appender = appender;
        }

        public async Task<string> ReplaceAsync(string term)
        {
            var fieldValue = Regex.Match(term, "Mr.Bean");       
            if (fieldValue.Success && fieldValue.ToString() != "") 
            {
                return await _appender.AppendAsync(fieldValue.ToString());     
            }                 
            return term;     
        }
    }
}
