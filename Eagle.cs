namespace ZooWithInheritance
{
    class Eagle : Animal
    {
        private String species;
        private String wingSpan;

        public Eagle(String name, String diet, String location, double weight, int age, String color, String species, String wingSpan) : base(name, diet, location, weight, age, color)
        {
            this.species = species;
            this.wingSpan = wingSpan;
        }
        public void layEggs()
        {
            Console.WriteLine("The eagle is laying eggs");
        }
        public void fly()
        {
            Console.WriteLine("The eagle is flying with a wingspan of " + wingSpan);
        }
        public override void makeNoise()
        {
            Console.WriteLine("The eagle is screeching");
        }
        public override void eat()
        {
            Console.WriteLine("The eagle is eating fish");
        }
        public override void move()
        {
            Console.WriteLine("The eagle is soaring through the sky");
        }
    }
}