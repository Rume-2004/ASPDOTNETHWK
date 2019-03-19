namespace ASPDOTNETHWK
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AsosModel1 : DbContext
    {
        public AsosModel1()
            : base("name=AsosModel11")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
