using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShoppingList.Models
{
    public class ShoppingListContext : DbContext
    {
        public ShoppingListContext (DbContextOptions<ShoppingListContext> options)
            : base(options)
        {
        }

        public DbSet<ShoppingList.Models.Items> ItemsModel { get; set; }
    }
}
