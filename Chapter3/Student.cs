namespace SampleCSharp
{
    public class Student
    {
        public string LastName { get; set; } = string.Empty;

        private string firstName = string.Empty;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length > 0)
                    firstName = value;
                else
                    firstName = string.Empty;
            }
        }

        public string getFirstName()
        {
            return firstName;
        }

        public void setFirstName(string value)
        {
            if (value.Length > 0)
                firstName = value;
            else
                firstName = string.Empty;
        }

        public string getFullName()
        {
            return $"{firstName}";
        }

        public string getFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        public string getFullName(string firstName, string lastName, string address)
        {
            return $"{firstName} {lastName} {address}";
        }
    }
}
