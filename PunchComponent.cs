using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExampleProject
{
    public class PunchComponent : IPunchComponent
    {
        public PunchComponent()
        {

        }

        public void CreatePunch()
        {
            Console.WriteLine("Creating a Punch");
        }

        public void GetPunchcomponent()
        {
            Console.WriteLine("Here is your PunchComponent");
        }
    }
}
