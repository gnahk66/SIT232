using System;
using ZooWithInheritance;

namespace ZooWithInheritance
{
    class ZooPark
    {
        static void Main(string[] args)
        {
            Tiger tonyTiger = new Tiger("Tony The Tiger", "Meat", "Cat Land", 200, 5, "Orange", "Bengal", "Black and Orange");
            Wolf willyWolf = new Wolf("Willy The Wolf", "Meat", "Wolf Land", 80, 4, "Gray", "Pack of Wolves", "Awooo");
            Eagle edgarEagle = new Eagle("Edgar The Eagle", "Fish", "Eagle Land", 10, 3, "Brown", "Golden Eagle", "2 meters");

            tonyTiger.makeNoise();
            Animal baseAnimal = new Animal("Base Animal", "Unknown", "Unknown", 0, 0, "Unknown");
            baseAnimal.makeNoise();

            tonyTiger.eat();
            baseAnimal.eat();
            willyWolf.eat();

            baseAnimal.sleep();
            willyWolf.sleep(); 
            edgarEagle.sleep();
            tonyTiger.sleep();
            tonyTiger.eat();

            Console.ReadLine();
        }
    }
}