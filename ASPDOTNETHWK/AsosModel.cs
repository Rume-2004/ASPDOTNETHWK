namespace ASPDOTNETHWK
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AsosModel : DbContext
    {
        public AsosModel()
            : base("name=AsosModel1")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
