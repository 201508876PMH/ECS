using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy
{
    internal class FakeHeater : IHeater
    {
        public void TurnOn()
        {
            System.Console.WriteLine("FakeHeater is on");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("FakeHeater is off");
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
