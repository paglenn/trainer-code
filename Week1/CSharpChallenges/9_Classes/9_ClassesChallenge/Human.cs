using System;

namespace _9_ClassesChallenge
{
    public class Human
    {
        public string lastName = "Smyth"; 
        public string firstName = "Pat" ; 
        
        public int age; 
        public string eyeColor ; 
        private int weight; 
        public int Weight { get { return weight;}
        set {
            if (value >= 0 && value <= 400) weight = value;
        } }
        
        public Human() {}
        
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            
        }
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        //parameterized constructor
       public Human(string firstName, string lastName, string eyeColor, int age) {
        this.firstName = firstName; 
        this.lastName = lastName; 
        this.age = age; 
        this.eyeColor= eyeColor; 
       }

        public void AboutMe()
        {
            if(this.age == 0 && this.eyeColor == null)
                Console.WriteLine($"My name is {firstName} {lastName}.");
            else if(this.age == 0)
                Console.WriteLine($"My name is {firstName} {lastName}. My eye color is {this.eyeColor}.");
            else if (this.eyeColor == null)
                Console.WriteLine($"My name is {firstName} {lastName}. My age is {this.age}.");
            else
                Console.WriteLine($"My name is {firstName} {lastName}. My eye color is {this.eyeColor} and my age is {this.age}.");
        }

    }//end of class
}//end of namespace
