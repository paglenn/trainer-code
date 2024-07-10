using System;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1
            string name = GetName();
            GreetFriend(name);

            //2
            double result1 = GetNumber();
            double result2 = GetNumber();
            int action1 = GetAction();
            
            double result3 = DoAction(result1, result2, action1);

            System.Console.WriteLine($"The result of your mathematical operation is {result3}.");


        }

        public static string GetName()
        {
           string name; 
           Console.WriteLine("Enter your name: "); 
           name = Console.ReadLine(); 
           return name ; 
        }

        public static void GreetFriend(string name)
        {
            //Greeting should be: Hello, nameVar. You are my friend
            //Ex: Hello, Jim. You are my friend
            Console.WriteLine($"Hello {name}! You are my friend."); 
           
        }

        public static double GetNumber()
        {
            Console.WriteLine("Enter a number: "); 
            string numString = Console.ReadLine(); 
            return Convert.ToDouble(numString);

            //Should throw FormatException if the user did not input a number
            
        }

        public static int GetAction()
        {
           Console.WriteLine("Select an action by entering a number: "); 
           Console.WriteLine("1) add"); 
           Console.WriteLine("2) subtract"); 
           Console.WriteLine("3) multiply"); 
           Console.WriteLine("4) divide"); 
           string choiceString =  Console.ReadLine(); 
           return Convert.ToInt32(choiceString); 

        }

        public static double DoAction(double x, double y, int z)
        {
            
            switch(z) {
                case 1: 
                    // add 
                    return x + y ; 
                    break; 
                case 2: 
                    // subtract
                    return x - y; 
                    break; 
                case 3: 
                    //multiply 
                    return  x * y ; 
                    break; 
                case 4: 
                    // divide
                    return x / y; 
                    break;  
                default:
                    return 0; 

            }

          
        }
    }
}
