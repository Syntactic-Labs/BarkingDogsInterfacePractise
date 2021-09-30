using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkingDogsInterfacePractise
{
    class Chuhuahua : Ibark
    {
        public string Name { get; set; } = "Helldog";
        public string Color { get; set; } = "Brown";
        public string BarkSound { get; set; } = "Squeek!!!";

        public string Bark()
        {
            return BarkSound;
        }
        public string Walk()
        {
            return "Walking the Dog";
        }
    }
}
