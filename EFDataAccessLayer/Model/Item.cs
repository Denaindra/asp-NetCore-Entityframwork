using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLayer.Model
{
    public class Item
    {
        [Key]
        public int ID { get; set; }
        public string Borrower { get; set; }
        public string Lender { get; set; }

        [DisplayName("Item name")]
        public string ItemName { get; set; }
    }
}
