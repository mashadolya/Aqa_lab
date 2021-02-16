using System.Linq;
using Bogus;
using ConsoleApp1.Factories;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var factory = new UserFactory();

            var programmers = factory.GetProgrammers(new Faker().Random.Int(1, 4));
            var employees = factory.GetEmployees(new Faker().Random.Int(1, 4));
            var clients = factory.GetClients();
            
            programmers.First().ShowInfo();
            employees.First().ShowInfo();
            clients.First().ShowInfo();
            
        }
    }
}