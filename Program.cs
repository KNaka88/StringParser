using System;

namespace RegexDelegate
{
    class Program
    { 
        static void Main(string[] args)
        {
            var input = "HelloWorld Mr.Bean is gone";
            IRegexExecutor[] executors = new IRegexExecutor[] 
            {
                new HelloWorldReplacer(),
                new MrBeanParser(new Appender()),
            };
            var termParser = new TermsParser(executors);

            var outcome = termParser.ParseAsync(input).Result;
            Console.WriteLine(outcome);
        }
    }
}
