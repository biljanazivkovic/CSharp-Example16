using System;
using System.Collections.Generic;
using System.Text;

namespace ex16
{
  /* sealed */ class Vehicle
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Tuuut, tuuut!");
        }
    }
}
