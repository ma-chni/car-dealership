namespace CarDealerShip.Domain
{
    internal abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Salary { get; set; }

        protected Person(string firstName, string lastName, string socialSecurityNumber, string email, string phoneNumber, int salary)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            Email = email;
            PhoneNumber = phoneNumber;
            Salary = salary;
        }
    }
}
