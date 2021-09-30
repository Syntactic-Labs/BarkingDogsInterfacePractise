using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkingDogsInterfacePractise
{
    class Boxer : Ibark
    {
        public string Name { get; set; } = "Cardboard";
        public string Color { get; set; } = "White";
        public string BarkSound { get; set; } = "Ruff";

        public string Bark()
        {
            return BarkSound;
        }
    }
}
