using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lol.common
{
    public class ProductTypeMst
    {
        [Key]
        public int pk_prodtypeid {  get; set; }
        public string Description { get; set; }
    }
}