using System;
using System. IO;
using System.Threading;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)

        {       // Cosole output, initial welcome. 
            Console.WriteLine("Hello World");
        
                // Console output, ask the user for their name.
            Console.WriteLine("What is your name?");

                // User input, user answers with name, site reads the response.
            string name = Console.ReadLine();

                // Console reads user input in order to give console output. (Welcome including clients input name).
            Console.WriteLine($"Hi {name}");
        
                
                // Console output, waits for 2 seconds and then site prompts user input (day status).
            Thread.Sleep(2000);         
            Console.WriteLine("How are you today?");

                // User input, site reads user repsonse for their day status.
            string daystatus = Console.ReadLine();

        
                //Console output, site Responds according to user input (good).
            if(daystatus == "good")
            {
            Console.WriteLine("That's good!");
            }            

                //Console output, site Responds according to user input (anything other than good).
             else 
             {
            Console.WriteLine("Sounds like a you problem.");
             }

                //Waits for 2 seconds and starts trivia. 
            Thread.Sleep(2000);
            Console.WriteLine("I have some trivia questions for you, lets play!");
            Thread.Sleep(2000);
            Console.WriteLine("The answers are case sensitive, remember your capitals!");
            

                Thread.Sleep(2000);
            Random question = new Random();
            int x = question.Next(4);
            string [] array = new string[4];
            array[0] = "What is 2 + 6?";
            array[1] = "What is the tallest building in the world?";
            array[2] = "What is the fastest animal in the world?";
            array[3] = "What is the largest fish in the world?";

            Console.WriteLine(array[x]);

            string[] answer = new string[4];
            answer[0] = "8";
            answer[1] = "The Burj";
            answer[2] = "Cheetah";
            answer[3] = "Whale Shark";

            string a = Console.ReadLine();

            if(a == answer[x])
            {
                Console.WriteLine("Well done!");
            }
                else
            {    
                Console.WriteLine("Big nope, try again.");   
            }         
        }

        

            
        
    }
}