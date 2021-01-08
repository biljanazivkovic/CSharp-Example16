using System;

namespace ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.honk();
            Console.WriteLine(myObj.brand + " " + myObj.modelName);
        }
    }
}
