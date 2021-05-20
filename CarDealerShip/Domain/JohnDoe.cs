using System;
namespace CarDealerShip.Domain
{
    internal class JohnDoe : Customer
    {
        public JohnDoe(string firstName, string lastName, string socialSecurityNumber, string email, string phoneNumber, int salary) : base(firstName, lastName, socialSecurityNumber, email, phoneNumber, salary)
        {
        }
    }
}
