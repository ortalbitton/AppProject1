using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppProject.Models
{
    public class Mart
    {
        [Key]
        //idcustomer
        public int MartId { get; set; }
        //need to add list of products id
        public Productes ProductId { get; set; }
    }
}
