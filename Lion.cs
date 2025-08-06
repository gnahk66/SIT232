namespace ZooWithInheritance
{
    using System;
    class Lion : Feline
    {
        public Lion(string name, int age, string location, string species, double weight, string furColor, string habitat) 
            : base(name, location, species, weight, age, furColor, habitat)
        {
        }

        public override void makeNoise()
        {
            Console.WriteLine("Roar!");
        }
        public override void eat()
        {
            Console.WriteLine("The lion is eating 5kgs of meat.");
        }
        public override void sleep()
        {
            Console.WriteLine("The lion is sleeping in the shade.");
        }
        public override void move()
        {
            Console.WriteLine("The lion is prowling through the savannah.");
        }
        public void hunt()
        {
            Console.WriteLine("The lion is hunting in a pride.");
        }
        public void groom()
        {
            Console.WriteLine("The lion is grooming its mane.");
        }
    }
}