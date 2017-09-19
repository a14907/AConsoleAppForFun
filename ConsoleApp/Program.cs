using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Messaging;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp
{ 
    class Program
    { 
        static void Main(string[] args)
        {
            Animal ani=new Cat();
            (ani as Cat).Speak();
        }
        
    }
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal.Speak");
        }
    }

    class Cat : Animal
    {
        public void Speak()
        {
            Console.WriteLine("Cat.Speak");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog.Speak");
        }
    }
}


 