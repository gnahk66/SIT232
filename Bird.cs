class Bird : Animal
{
    public Bird(string name, string species, string diet, double weight, int age, string habitat) 
        : base(name, species, diet, weight, age, habitat)
    {
    }

    public override void makeNoise()
    {
        Console.WriteLine("Chirp! Chirp!");
    }
    public override void eat()
    {
        Console.WriteLine("The bird is eating seeds and insects.");
    }
    public override void sleep()
    {
        Console.WriteLine("The bird is sleeping in its nest.");
    }
    public override void move()
    {
        Console.WriteLine("The bird is flying in the sky.");
    }
    public void layEggs()
    {
        Console.WriteLine("The bird is laying eggs.");
    }
    public void buildNest()
    {
        Console.WriteLine("The bird is building a nest.");
    }

}