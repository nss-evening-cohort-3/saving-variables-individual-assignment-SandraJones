using SavingVariables.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables.Models
{
    public class Constant
    {
        [Key]
        public int ConstantId { get; set; }

        [Required]
        [MaxLength(length: 1, ErrorMessage = "The key can only be one character long.")]
        public string Key { get; set; }
        

        [Required]
        public int Value { get; set; }
    }
}
        
