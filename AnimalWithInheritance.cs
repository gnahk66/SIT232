class Animal
{
    private String name;
    private String diet;
    private String location;
    private double weight;
    private int age;
    private String color;
    public Animal(String name, String diet, String location, double weight, int age, String color)
    {
        this.name = name;
        this.diet = diet;
        this.location = location;
        this.weight = weight;
        this.age = age;
        this.color = color;
    }
    public virtual void eat()
    {
        Console.WriteLine(name + " is eating " + diet);
    }
    public virtual void sleep()
    {
        Console.WriteLine(name + " is sleeping in " + location);
    }
    public virtual void makeNoise()
    {
        Console.WriteLine(name + " is making noise");
    }
    public void makeLionNoise()
    {
        Console.WriteLine(name + " is making noise");
    }
    public void makeEagleNoise()
    {
        Console.WriteLine(name + " is making noise");
    }
    public void makeWolfNoise()
    {
        Console.WriteLine(name + " is making noise");
    }
    public void eatMeat()
    {
        Console.WriteLine(name + " is eating meat");
    }
    public void eatBerries()
    {
        Console.WriteLine(name + " is eating berries");
    }
    public virtual void move()
    {
        Console.WriteLine(name + " is moving");
    }

}