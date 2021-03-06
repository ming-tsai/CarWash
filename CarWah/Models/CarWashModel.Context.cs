namespace CarWah.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;

    public partial class CarWashEntities : DbContext
    {
        public CarWashEntities()
            : base("name=CarWashEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Cliente_Vehiculo> Cliente_Vehiculo { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Empleado_Roles> Empleado_Roles { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<FacturaDetails> FacturaDetails { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Modelo> Modelo { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipoLavado> TipoLavado { get; set; }
        public virtual DbSet<TipoVehiculo> TipoVehiculo { get; set; }
        public virtual DbSet<Vehiculo> Vehiculo { get; set; }

        public virtual ObjectResult<UserInRol_Result> UserInRol(string user, string password)
        {
            var userParameter = user != null ?
                new ObjectParameter("user", user) :
                new ObjectParameter("user", typeof(string));

            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserInRol_Result>("UserInRol", userParameter, passwordParameter);
        }
    }
}