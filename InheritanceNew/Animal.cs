using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceNew;

internal class Animal
{
    
    
    
    
    public bool isAlive = true;
    public bool breathesOxygen = true;
    public bool hasBlood = true;
    public bool canReproduce = true;

    public void PrintInfo()
    {
        Console.WriteLine($"Alive: {isAlive}");
        Console.WriteLine($"Breathes oxygen: {breathesOxygen}");
        Console.WriteLine($"Has blood: {hasBlood}");
        Console.WriteLine($"Can reproduce: {canReproduce}");
    }
}
