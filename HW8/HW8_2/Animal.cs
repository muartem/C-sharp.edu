namespace HW8_2
{
    public abstract class Animal
    {
        public abstract void singSong();
    }
    public abstract class Mammals : Animal
    {
        public abstract void eatMilk();
    }
    public abstract class Fish: Animal
    {
        public abstract void breatheWater();
    }
}