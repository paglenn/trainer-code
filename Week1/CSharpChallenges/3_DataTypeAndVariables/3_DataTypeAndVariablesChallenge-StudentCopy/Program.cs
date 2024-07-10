using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
      public static void Main(string[] args)
      {

          byte myByte = 125; 
          Console.WriteLine(myByte); 

          sbyte mySbyte = 126 ; 
          Console.WriteLine(mySbyte);

          int myInt = 15; 
          Console.WriteLine(myInt);

          uint myUint = 15; 
          Console.WriteLine(myUint);

          short myShort = 15; 
          Console.WriteLine(myShort);

          ushort myUShort = 15; 
          Console.WriteLine(myUShort); 

          float myFloat = 10.0F; 
          Console.WriteLine(myFloat); 

          double myDouble = 15.5; 
          Console.WriteLine(myDouble); 

          char myCharacter = 'a'; 
          Console.WriteLine(myCharacter); 

          bool myBool = false ; 
          Console.WriteLine(myBool); 

          string myText = "I control text"; 
          Console.WriteLine(myText); 
 
          string numText = "15";
          Console.WriteLine(Text2Num(numText)); 
      }

      public static int Text2Num(string numText)
      {
        int number; 
        Int32.TryParse(numText, out number); 
        return number; 
      }
    }
}
