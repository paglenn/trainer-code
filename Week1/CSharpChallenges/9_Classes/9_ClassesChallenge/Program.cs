using System;

namespace _9_ClassesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human h1 = new Human() ; 
            Human h2 = new Human("John", "Doe") ; 
            Human h3 = new Human("Kristen", "Bell", "blue");
            Human h4 = new Human("Chidi","Anagonye",40);
            Human h5 = new Human("Mojo","Jojo", "green", 13);

            h1.AboutMe() ; 
            h2.AboutMe(); 
            h3.AboutMe() ; 
            h4.AboutMe()  ; 
            h5.AboutMe() ;

            Human h6 = new Human("Chonker", "Mann");
            h6.Weight = 20; 
            System.Console.WriteLine(h6.Weight);

            h6.Weight = 405; 
            System.Console.WriteLine(h6.Weight);

            
        }
    }
}
