namespace CarDealerShip.Domain
{
    internal class Staff : Person
    {
        public string Position { get; set; }
        protected Staff(string firstName, string lastName, string socialSecurityNumber, string email, string phoneNumber, int salary, string position) : base(firstName,lastName,socialSecurityNumber,email,phoneNumber,salary)
        {
            Position = position;
        }
    }
}
