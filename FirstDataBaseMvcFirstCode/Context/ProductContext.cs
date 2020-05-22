using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FirstDataBaseMvcFirstCode.Models;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace FirstDataBaseMvcFirstCode.Context
{
    public class ProductContext:DbContext
    {
        //the name of the connection String is passed into the constructor
        //this name will be used in web.config file
        public ProductContext():base("ProductContextDb")
        {

        }
        public DbSet<Category>Categories{ get; set; }
        public DbSet<Product> Products{ get; set; }
        
        //metodo construido para poner las tablas en singular
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}