using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_cat1_dog2_
{
    abstract class Animal
    {
        public float weight;
        public string color;

        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Animal(float weight, string color)
        {
            this.weight = weight;
            this.color = color;
        }
        public abstract string MakeSound();
    }
    abstract class AnimalWithTail : Animal 
    {
        public float tailLenght;
        public float TailLenght
        {
            get { return tailLenght; }
            set { tailLenght = value; }
        }



            public AnimalWithTail(float weight, string color, float tailLenght): base (weight,color)
        {
            base.weight = weight;
            base.color = color;
            this.tailLenght = tailLenght;
        }
    }
     class Cat : AnimalWithTail
    {
        public Cat(float weight, string color, float tailLenght): base(weight, color, tailLenght)
        {
            base.weight = weight;
            base.color = color;
            base.tailLenght = tailLenght;
        }
        private string Purr()
        {
            return "Purr";
        }
        private string Meow()
        {
            return "Meow";
        }

        public override string MakeSound()
        {
            return Purr() + Meow();
        }

        public override string ToString()
        {
            return $"This is a Cat, Weight = {weight} Color = {color} TailLenght = {tailLenght}";
        }
    }

    class Dog : AnimalWithTail 
    {
        public Dog(float weight, string color, float tailLenght): base (weight, color, tailLenght)
        {
            base.weight = weight;
            base.color = color;
            base.tailLenght = tailLenght;
        }

        public override string MakeSound()
        {
            return "Woof";
        }

        public override string ToString()
        {
            return $"This is a Dog, Weight = {weight} Color = {color} TailLenght = {tailLenght}";
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть вагу кота");
            float weight = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine("Введіть колір кота");
            string color = Console.ReadLine();

            Console.WriteLine("Введіть довжину хвоста кота");
            float tailLenght = Convert.ToSingle(Console.ReadLine());

            Cat cat = new Cat(weight, color, tailLenght);
            Console.WriteLine(cat.ToString());
            Console.WriteLine(cat.MakeSound());


            Console.WriteLine("Введіть вагу собаки");
            weight = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введіть колір собаки");
            color = Console.ReadLine();

            Console.WriteLine("Введіть довжину хвочта собаки");
            tailLenght = Convert.ToSingle(Console.ReadLine());

            Dog dog = new Dog(weight, color, tailLenght);
            Console.WriteLine(dog.ToString());
            Console.WriteLine(dog.MakeSound());

            Console.ReadKey();
        }
    }
}
