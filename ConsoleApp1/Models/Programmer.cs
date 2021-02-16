using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public class Programmer : BaseUser
    {
        public List<string> KnownLanguages { get; set; }
    }
}