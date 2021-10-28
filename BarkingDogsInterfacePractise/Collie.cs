using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkingDogsInterfacePractise {
    class Collie : Ibark {
        public string Name { get; set; } = "Lassie";
        public string Color { get; set; } = "Golden";
        public string BarkSound { get; set; } = "Woof";

        public string Bark() {
            return BarkSound;
        }
    }
}
