using SavingVariables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SavingVariables
{
    public class RegexParser
    {
        public RegexParser parser = new RegexParser();
        private Constants constants = new Constants();
        public int Term1 { get; set; }
        public int Term2 { get; set; }
        public int Operator { get; set; }

        private string pattern = @"^(-?\d+|[a-zA-Z])\s*([\+-\/\*%])\s*(-?\d+|[a-zA-Z])$";
        public void ParseInput(string userInput)
        {
            Match match = Regex.Match(userInput, pattern);

            if (match.Success)
            {
                //checks if we can parse to an integer and then if we cannot parse it, we get the value of it from our dictionary 
                int firstTerm;
                bool canParse = int.TryParse(match.Groups[1].Value, out firstTerm);
                if (!canParse)
                {
                    char termA = char.Parse(match.Groups[1].Value);
                    firstTerm = constants.ReturnValueOfConstant(termA);
                }
                Term1 = firstTerm;

                Term2 = int.Parse(match.Groups[3].Value);
                Operator = match.Groups[2].Value[0];
            }
            else
            {
                throw new ArgumentException("Please enter a valid integer.");
            }
        }

        public void parseConstant(string userInput)
        {

            string ConstantsRegex = @"^([a-zA-Z])\s*['=']\s*(\d*)$";
            Match match = Regex.Match(userInput, ConstantsRegex);
            {
                if (match.Success)
                {
                    char key = match.Groups[1].Value[0];
                    int value = int.Parse(match.Groups[2].Value);
                    constants.UserCreateAConstToAddToDictionary(key, value);
                }
                else
                {
                    throw new ArgumentException("Sorry you need to set a constant by entering something like:  x = 6 ");
                }
            }
        }
    }

}
