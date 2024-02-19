using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCSharp
{
    public class Student
    {
        private string firstName = "Erick";
        private string lastName = "Kurniawan";
        private string address = "Jakarta";

        public string getFullName()
        {
            return $"{firstName} {lastName}";
        }

        public string getFullName(string firstName,string lastName)
        {
            return $"{firstName} {lastName}";
        }

        public string getFullName(string firstName, string lastName, string address)
        {
            return $"{firstName} {lastName} {address}";
        }
    }
}
