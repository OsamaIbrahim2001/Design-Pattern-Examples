public class Employee
    {
        public string FirstName { get; set; }

        public string MediumName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {MediumName} {LastName}";
        public IEnumerable<PayItem> PayItems { get; set; }
    }

