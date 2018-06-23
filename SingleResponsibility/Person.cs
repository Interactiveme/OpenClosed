using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Logger
    {
        public void Log(string log)
        {
            Console.WriteLine(log);
        }
    }

    public class Person
    {
        private Logger logger;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() {
            this.logger = new Logger();
        }

        public void Log() {
            this.logger.Log($"{FirstName} {LastName}");
        }
    }
}