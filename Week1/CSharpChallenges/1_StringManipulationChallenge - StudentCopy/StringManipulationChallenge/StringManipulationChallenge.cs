using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInputString; //this will hold your users message
            int elementNum;         //this will hold the element number within the messsage that your user indicates
            char char1;             //this will hold the char value that your user wants to search for in the message.
            string fName;           //this will hold the users first name
            string lName;           //this will hold the users last name
            string userFullName;    //this will hold the users full name;
            
            //
            //
            //implement the required code here and within the methods below.
            //
            //
            Console.WriteLine("Please enter your message and press enter"); 

            //5. Assign entered string to string variable 
            userInputString = Console.ReadLine() ; 
            
            // 6. Print to the console "Please enter a number LESS THAN the length of your string and press enter"
            Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter"); 

            /* 
            7. Assign that entered string to the int variable which you declared initially. 
            8. You will need to parse the string to an int using 'int.parse();'
            */ 
            elementNum = Int32.Parse(Console.ReadLine()); 

            // 9. Call each of the provided methods with the correct arguments.
            // 10. Print the return of each method to the console.
            StringToUpper(userInputString); 
            StringToLower(userInputString); 
            StringTrim(userInputString); 
            StringSubstring(userInputString,elementNum); 

            // 12. Ask the user "For which character should I search in your original message?"
            Console.WriteLine("For which character should I search in your original message?"); 


            // 13. Same the user input to the char variable. **remember we are not validating 
            char1 = Convert.ToChar(Console.Read());

            // 14. Call the SearchChar method and print the result to the console.
            Console.WriteLine(SearchChar(userInputString,char1)); 

            /*
            15. Ask the user for their first name and save it to a string variable.
            */ 
            Console.WriteLine("What is your first name? "); 
            fName = Console.ReadLine() ; 
            Console.WriteLine("Entered first name:" + fName);

            //   16. Ask the user for their last name and save it to a variable. 
            Console.WriteLine("What is your last name? ");
            lName = Console.ReadLine()  ; 
            Console.WriteLine("Entered last name:" + lName);

            // 17. Call the ConcatNames method and print the full name result to the console.
            userFullName = ConcatNames(fName,lName); 
            Console.WriteLine("Your full name: " + userFullName); 

        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all upper case, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringToUpper(string x){
            x = x.ToUpper();
            Console.WriteLine(x);
            return x;
        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all lower case, 
        // 2) print the result to the console and 
        // 3) return the new string.        
        public static string StringToLower(string x){
            x= x.ToLower() ; 
            Console.WriteLine(x); 
            return x; 
        }
        
        // This method has one string parameter. 
        // It will:
        // 1) trim the whitespace from before and after the string, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringTrim(string x){
           x = x.Trim(); 
           Console.WriteLine(x); 
           return x ; 

        }
        
        // This method has two parameters, one string and one integer. 
        // It will:
        // 1) get the substring based on the integer received, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringSubstring(string x, int elementNum){
            x = x.Substring(elementNum); 
            Console.WriteLine(x); 
            return x; 

        }

        // This method has two parameters, one string and one char.
        // It will:
        // 1) search the string parameter for the char parameter
        // 2) return the index of the char.
        public static int SearchChar(string userInputString, char x){
            int pos = userInputString.IndexOf(x);
            return pos;
        }

        // This method has two string parameters.
        // It will:
        // 1) concatenate the two strings with a space between them.
        // 2) return the new string.
        public static string ConcatNames(string fName, string lName){
           return string.Concat(fName," ", lName);
        }



    }//end of program
}
