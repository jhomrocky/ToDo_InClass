using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public DateTime ItemDueDate { get; set; }
        public string ItemDetails { get; set; }
        public bool IsDone { get; set; } //try to always use bool in positive form (IsDone, IsTrue, etc)

        [ForeignKey("List")]
        public int ListID { get; set; }
        public virtual List List { get; set; }
    }
}