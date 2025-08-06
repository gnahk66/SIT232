
namespace ZooWithInheritance
{
    class Penguin : Bird
    {
        public Penguin(string name) : base(name, "Penguin", "Black and White", 1.0, 2, "Fish")
        {
        }
        public override void makeNoise()
        {
            Console.WriteLine("Quack! Quack!");
        }
        public override void eat()
        {
            Console.WriteLine("The penguin is eating fish.");
        }
        public override void sleep()
        {
            Console.WriteLine("The penguin is sleeping in its nest.");
        }
        public override void move()
        {
            Console.WriteLine("The penguin is waddling on the ice.");
        }
    }
}