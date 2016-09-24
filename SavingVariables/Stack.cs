using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables
{
    public class Stack
    {
        public List<int> answerList = new List<int>();
        public List<string> lastCommandList = new List<string>();

        public Stack()
        {
            RegexParser parser = new RegexParser();
           // Evaluator eval = new Evaluator();

        }
        public void AddToListOfAnswers(int answer)
        {
            answerList.Add(answer);
        }
        public void AddToListOfCommands(string userInput)
        {
            lastCommandList.Add(userInput);
        }
        //public class Evaluator
        //{
        //    private Addition add = new Addition();
        //    private Subtraction sub = new Subtraction();
        //    private Multiplication mult = new Multiplication();
        //    private Modulo mod = new Modulo();
        //    private Division div = new Division();

            //public int Calculate(RegexParser parser)
            //{
            //    //Switch statement and cases here are to match operation user wants, 
            //    //and then calculate the input at this point.
            //    switch (parser.Operator)
            //    {
            //        case '+':
            //            return add.AddTwoNumbers(parser.Term1, parser.Term2);//etc etc etc
            //        case '-':
            //            return sub.SubtractTwoNumbers(parser.Term1, parser.Term2);
            //        case '*':
            //            return mult.MultiplyTwoNumbers(parser.Term1, parser.Term2);
            //        case '%':
            //            return mod.ModuloTwoNumbers(parser.Term1, parser.Term2);
            //        case '/':
            //            return div.DivideTwoNumbers(parser.Term1, parser.Term2);
            //        default:
            //            throw new Exception("Invalid Operator");
            //    }
            //}
    }
}

