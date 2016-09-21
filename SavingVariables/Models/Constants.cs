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
        public int id { get; set; }

        [Required]
        public virtual List<Constants> constants { get; set; }

        internal void UserCreateAConstToAddToDictionary(char key, int value)
        {
            throw new NotImplementedException();
        }



    }
}

