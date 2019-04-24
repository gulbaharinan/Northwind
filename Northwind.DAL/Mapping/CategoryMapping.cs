using Northwind.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Mapping
{
   public  class CategoryMapping :EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            ToTable("Categories");
            HasKey(c => c.CategoryID);
        }
    }
}
