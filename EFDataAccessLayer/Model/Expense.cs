using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLayer.Model
{
    public class Expense
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Expenses Type")]
        [Required]
        public string ExpensesType { get; set; }

        [Required]
        [Range(1,int.MaxValue, ErrorMessage= "Amount must be greater than 0!")]
        public double Amout { get; set; }
    }
}
