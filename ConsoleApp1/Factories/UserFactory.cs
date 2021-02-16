using System.Collections.Generic;
using Bogus;
using ConsoleApp1.Models;

namespace ConsoleApp1.Factories
{
    public class UserFactory
    {
        public List<Programmer> GetProgrammers(int userCount = 1)
        {
            return new Faker<Programmer>()
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u => u.KnownLanguages, f => new List<string> {"Java", "C#", "Javascript"})
                .RuleFor(u => u.Age, f => f.Random.Int(20, 60)).Generate(userCount);
        }

        public List<Client> GetClients(int userCount = 1)
        {
            return new Faker<Client>()
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u => u.Order, f => f.Commerce.Product())
                .RuleFor(u => u.Age, f => f.Random.Int(20, 60)).Generate(userCount);
        }

        public List<Employee> GetEmployees(int userCount = 1)
        {
            return new Faker<Employee>()
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u => u.CompanyName, f => f.Company.CompanyName())
                .RuleFor(u => u.Age, f => f.Random.Int(20, 60)).Generate(userCount);
        }
    }
}