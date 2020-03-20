using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Services
{
    public class AdditionService
    {
        public int LastUsedA { get; set; } = 10;
        public int Add (int a, int b)
        {
            LastUsedA = a;
            return a + b;
        }
    }
}
