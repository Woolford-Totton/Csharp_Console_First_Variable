#region ""
using System;

namespace LS_2_FirstVariable
{
    class Program
    {
        #endregion
        /*
            Welcome to your first variable- to start run the program by pressing the green play button OR by pressing F5.

            You will see a window with text showing the different datatypes a variable can be.

            Once you see it close it and try changing the variables to output something else.
        */

        static void Main(string[] args)
        {
            //String variable
            
            Console.WriteLine("This is how to write a String:");

            string MyString = "Hello World! I am a string variable!";   //  <-- change this variable to get different results

            Console.WriteLine(MyString);            

            //Int variable
            
            Console.WriteLine("This is how to write an int:");

            int MyInt = 10; //  <-- change the number to get different results

            Console.WriteLine(MyInt);

            //Float variable

            float MyFloat = 3.14f;  //  <-- change the number to get different results

            Console.WriteLine("This is how to write a float:");

            Console.WriteLine(MyFloat);

            //Boolean variable

            bool MyBool = false;    //  <-- Booleans can only be true or false

            Console.WriteLine("This is how to write a boolean:");

            Console.WriteLine(MyBool);

            /*
             Try creating your own variables- make an int and add it to MyInt to change its number eg 

                int My2ndInt=5;

                MyInt=My2ndInt;

                MyInt=MyInt+My2ndInt;            

                MyInt+=My2ndInt;

                MyInt=MyInt-My2ndInt;

                MyInt-=My2ndInt;

                MyInt=MyInt*My2ndInt;

                MyInt*=My2ndInt;

                MyInt=MyInt/My2ndInt;

                MyInt/=My2ndInt;

             */

            Console.ReadLine();


        }
#region "" 
    }
}
#endregion