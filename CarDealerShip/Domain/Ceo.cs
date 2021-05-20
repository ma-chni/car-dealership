using System;
namespace CarDealerShip.Domain
{
    internal class  Ceo : Staff
    {
        public Ceo(string firstName, string lastName, string socialSecurityNumber, string email, string phoneNumber, int salary, string position) : base(firstName, lastName, socialSecurityNumber, email, phoneNumber, salary, position)
        {
        }
    }
}
