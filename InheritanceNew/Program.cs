using InheritanceNew;

//Animal[] animalArray = new Animal[2]; 
//List<Animal> animalList = new List<Animal>();
//will experiment with this later



// TODO Be sure to follow best practice when creating your classes

// Create a class Animal
// give this class 4 members that all Animals have in common


// Create a class Bird
// give this class 4 members that are specific to Bird
// Set this class to inherit from your Animal Class

// Create a class Reptile
// give this class 4 members that are specific to Reptile
// Set this class to inherit from your Animal Class




/*Create an object of your Bird class
 *  give values to your members using the object of your Bird class
 *
 * Creatively display the class member values 
 */

var bird1 = new Bird();
{
    bird1.canReproduce = true;
    bird1._birdName = "Bluejay";
    bird1._birdColor = "Blue";
    bird1.isAlive = true;
}
bird1.PrintInfo();
Console.WriteLine();
/*Create an object of your Reptile class
 *  give values to your members using the object of your Reptile class
 *  
 * Creatively display the class member values 
 */

var reptile1 = new Reptile();
{
    reptile1._reptileName = "Bearded Dragon";
    reptile1._isColdBlooded = true;
    reptile1._hasScales = true;
    reptile1._reptileColor = "Brown";
}
reptile1.PrintInfo();