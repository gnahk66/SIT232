class Feline : Animal
{
    private String species;
    public Feline(String name, String diet, String location, double weight, int age, String color, String species) : base(name, diet, location, weight, age, color)
    {
        this.species = species;
    }
    public override void sleep()
    {
        Console.WriteLine("The feline is sleeping in a tree");
    }
    public override void eat()
    {
        Console.WriteLine("The feline is eating 3kgs of meat");
    }
    public override void makeNoise()
    {
        Console.WriteLine("The feline is making noise");
    }
    public override void move()
    {
        Console.WriteLine("The feline is prowling through the jungle");
    }
    
}