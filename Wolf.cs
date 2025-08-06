namespace ZooWithInheritance{
    class Wolf : Animal
    {
        private String packName;
        private String howlSound;

        public Wolf(String name, String diet, String location, double weight, int age, String color, String packName, String howlSound) : base(name, diet, location, weight, age, color)
        {
            this.packName = packName;
            this.howlSound = howlSound;
        }
        public override void eat()
        {
            Console.WriteLine("The wolf is eating 2kgs of meat");
        }
        public override void makeNoise()
        {
            Console.WriteLine("The wolf is howling: " + howlSound);
        }
        public override void move()
        {
            Console.WriteLine("The wolf is running in a pack called " + packName);
        }
        public void drinkWater()
        {
            Console.WriteLine("The wolf is drinking water from a stream");
        }
    }
}