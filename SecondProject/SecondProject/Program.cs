// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(string[] args)
    {
        var myCat = new cat();

        Console.WriteLine("enter your cat name: ");
        myCat.name = Console.ReadLine();
        Console.WriteLine("enter your cat age: ");
        myCat.age = int.Parse(Console.ReadLine());
        Console.WriteLine("enter your cat color: ");
        myCat.color = Console.ReadLine();
        Console.WriteLine("enter your cat gender: ");
        myCat.gender = Console.ReadLine();
        
        myCat.catInfo();
    }
    class cat
    {
        //fields
        public string name;
        public int age;
        public string color;
        public string gender;

        //constructor
        public cat()
        {
            name = "Mittens";
            age = 3;
            color = "Black";
            gender = "Male";
        }

        //functions
        public void catInfo()
        {
            Console.WriteLine("cat name is: {0} , it's age is: {1} , it's color is: {2} , it's gender is: {3}" , name , age, color, gender);
        }

    }
}
