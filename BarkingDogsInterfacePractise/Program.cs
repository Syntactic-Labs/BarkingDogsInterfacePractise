using System;
using System.Collections.Generic;

namespace BarkingDogsInterfacePractise {
    class Program {
        static void Main(string[] args) {
            var dogs = new List<Ibark>() {
                new Collie(),
                new Boxer(),
                new Chuhuahua()
            };
            foreach (var dog in dogs) {
                Console.WriteLine($"{dog.Name} goes... {dog.Bark()}");
                var chawawa = dog as Chuhuahua;
                if (chawawa != null){
                    Console.WriteLine(chawawa.Walk());
                }
                
            }
        }
    }
}
