namespace ZooWithInheritance
{
    class Tiger : Feline
    {
        private String species;
        private String colourStripes;
        public Tiger(String name, String diet, String location, double weight, int age, String color, String species, String colourStripes) : base(name, diet, location, weight, age, color, species)
        {
            this.species = species;
            this.colourStripes = colourStripes;
        }
        public override void makeNoise()
        {
            Console.WriteLine("ROARRRRRRRRRRRRRRRRRRRRRRRRRRRR");
        }
        public override void eat()
        {
            Console.WriteLine("The tiger is eating 5kgs of meat");
        }
        public override void move()
        {
            Console.WriteLine("The tiger is prowling through the jungle");
        }
        public override void sleep()
        {
            Console.WriteLine("The tiger is sleeping in a tree");
        }
        public void hunt()
        {
            Console.WriteLine("The tiger is hunting in the jungle");
        }
        
    }
}