﻿using System;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            animal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
        }
    }

    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic Sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

}