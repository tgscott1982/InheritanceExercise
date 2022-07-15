using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceNew;

internal class Bird : Animal
{

    public Bird()
    {
        isAlive = true;
        breathesOxygen = true;
        hasBlood = true;
        canReproduce = true;

    }


    public string _birdName { get; set; }
    public string _birdColor { get; set; }

    public bool _flies = true;
    public string _birdClass { get; set; }


    public void PrintInfo()
    {
        Console.WriteLine($"Name: {_birdName}");
        Console.WriteLine($"Color: {_birdColor}");
        Console.WriteLine($"Can fly: {_flies}");
        Console.WriteLine($"Bird class:{_birdClass}");
    }
}
