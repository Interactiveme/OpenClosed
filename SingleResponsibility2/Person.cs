using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public interface ILogger {
        void Log(string log);
    }

    public class Logger:ILogger
    {
        public void Log(string log)
        {
            Console.WriteLine(log);
        }
    }

    public class AwesomeLogger : ILogger
    {
        public void Log(string log)
        {
            Console.WriteLine($"{log} is awesome!!");
        }
    }

    public class Person
    {
        private ILogger logger;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(ILogger logger) {
            this.logger = logger;
        }

        public void Log() {
            this.logger.Log($"{FirstName} {LastName}");
        }
    }
}