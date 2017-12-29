namespace EntityFramework3
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelNhanSu : DbContext
    {
        public ModelNhanSu()
            : base("name=ModelNhanSu")
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
