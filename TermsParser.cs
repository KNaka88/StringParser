using System.Text;
using System.Threading.Tasks;

namespace RegexDelegate
{
    public class TermsParser
    {
        private IRegexExecutor[] _executors;
        private StringBuilder _sb = new StringBuilder();

        public TermsParser(IRegexExecutor[] executors)
        {
            _executors = executors;
        }

        public async Task<string> ParseAsync(string terms)
        {
            var splitedTerms = terms.Split(" ");

            foreach (var term in splitedTerms)
            {
                string replacedTerm = term;
                foreach(var executor in _executors)
                {
                    replacedTerm = await executor.ReplaceAsync(replacedTerm);
                }
                _sb.Append(replacedTerm + " ");
            }
            return _sb.ToString().Trim();
        }
    }
}
