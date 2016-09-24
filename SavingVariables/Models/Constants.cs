using SavingVariables.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables.Models
{
    public class Constants
    {
        [Key]
        public int constantsId { get; set; }

        [Required]
        public virtual List<Constants> constants { get; set; }

        private Dictionary<char, int> storeConstantsDictionary = new Dictionary<char, int>();
        
        //add a constant to dictionary
        public void UserCreateAConstToAddToDictionary(char key, int value)
        {
            if (storeConstantsDictionary.ContainsKey(key))
            {
                throw new ArgumentException("That constant already exists.");
            }
            else
            {
                storeConstantsDictionary.Add(key, value);//.Add(key, value)
            }
        }
        //return value of constant from dictionary
        public int ReturnValueOfConstant(char key)
        {
            if (storeConstantsDictionary.ContainsKey(key))
            {
                return storeConstantsDictionary[key];
            }
            else
            {
                throw new ArgumentException("You are free to set that constant by entering it in this form:  v = 45, with the variable on the left and the value to the right of the equals sign.");
            }
        }
        // clear/value/delete constant from dictionary
        public void RemoveConstantFromDictionary(char key)
        {
            if (storeConstantsDictionary.ContainsKey(key))
            {
                storeConstantsDictionary.Remove(key);
            }
        }  
    }
}

