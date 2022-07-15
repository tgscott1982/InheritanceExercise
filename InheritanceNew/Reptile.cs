using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceNew
{
    internal class Reptile : Animal
    {

        public Reptile()
        {
            isAlive = true;
            breathesOxygen = true;
            hasBlood = true;
            canReproduce = true;
        }

        public string _reptileName { get; set; }
        public string _reptileColor { get; set; }

        public bool _isColdBlooded = true;
        public bool _hasScales { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {_reptileName}");
            Console.WriteLine($"Color: {_reptileColor}");
            Console.WriteLine($"Cold blooded: {_isColdBlooded}");
            Console.WriteLine($"Scales : {_hasScales}");
        }

    }
}
