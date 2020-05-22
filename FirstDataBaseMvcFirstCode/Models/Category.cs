using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstDataBaseMvcFirstCode.Models
{
    public class Category
    {
        /*
         * the ID property will become the primary key column of the database table.
         * by default, the EF interprents a property named ID or 'classname' ID as the primary key.
         * eg:create primary hey:Id or CategoryId
         */
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products{ get; set; }
    }
}   