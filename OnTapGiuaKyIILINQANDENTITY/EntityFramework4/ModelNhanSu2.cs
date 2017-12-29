namespace EntityFramework4
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelNhanSu2 : DbContext
    {
        public ModelNhanSu2()
            : base("name=ModelNhanSu2")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
