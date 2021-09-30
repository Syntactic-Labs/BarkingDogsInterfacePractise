using System;
using System.Collections.Generic;

namespace BarkingDogsInterfacePractise
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new List<Ibark>()
            {
                new Collie(),
                new Boxer(),
                new Chuhuahua()
            };
            foreach (var dog in dogs)        // dog is created in this foreach
            {
                Console.WriteLine($"{dog.Name} goes... {dog.Bark()}");
                var chawawa = dog as Chuhuahua;    //this allows you to us the var chawawa to call the Walk() method from Chuhuahua
                if (chawawa != null)
                {
                    Console.WriteLine(chawawa.Walk());
                }
                
            }
        }
    }
}
