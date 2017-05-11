namespace My_Stor
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using My_Stor.Models;
    public class Stor_Db : DbContext
    {
       
        public Stor_Db()
            : base("name=Stor Db")
        {
            //Database.CreateIfNotExists();
           // Database.SetInitializer<MyContext>(new UniDBInitializer<MyContext>());
            Database.SetInitializer<Stor_Db>(new Initializ<Stor_Db>());
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
         public virtual DbSet<Product> Products { get; set; }
    }
    public class Initializ<T> : DropCreateDatabaseIfModelChanges<Stor_Db>
    {
        protected override void Seed(Stor_Db context)
        {
            context.Products.AddOrUpdate(x => x.Id,



                new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
                new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
                new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M });

            
        }
    }


}