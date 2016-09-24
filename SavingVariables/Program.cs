using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int i = 0;
            //RegexParser parser = new RegexParser();
            //Evaluator eval = new Evaluator();
            Stack stackList = new Stack();
            bool keepLooping = true;
            while (keepLooping)
            {
                string prompt;
                Console.WriteLine("Enter your variables.");
                Console.Write(prompt = ">");
                userInput = Console.ReadLine();

                if (userInput == "quit" || userInput == "exit")
                {
                    keepLooping = false;
                    continue;
                }

                else if (userInput == "last")
                {
                    Console.WriteLine(stackList.answerList.Last());
                }
                else if (userInput == "lastq")
                {
                    //print the last entered command;
                    //storing last userInput;
                    Console.Write(stackList.lastCommandList.Last());
                }
                //else if (userInput.Contains('='))
                //{
                //    parser.parseConstant(userInput);
                //}
                //else
                //{
                //    try
                //    {
                //        parser.ParseInput(userInput);
                //       // int answer = eval.Calculate(parser);
                //        Console.WriteLine(answer);

                //        string lastExp = userInput;
                //        //add last command to lastCommandList;
                //        //keep a running list of commands given by user
                //        //stackList.AddToListOfCommands(userInput);
                //        userInput.ToString();
                //        stackList.AddToListOfCommands(userInput);

                //        //add this answer to the end of the answerList 
                //        //answerList keeps a running List of answers generated
                //        stackList.AddToListOfAnswers(answer);

                //    }
                //    catch (Exception e)//can have multiple catch blocks to catch lower level exceptions
                //    {
                //        Console.WriteLine(e.Message);
                //    }
                //    i++;
                //}
            }
        }
    }
}
