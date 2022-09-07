using Microsoft.EntityFrameworkCore;
using HospiCasa.App.Dominio;

namespace HospiCasa.App.Persistencia
{
    public class AppContext: DbContext
    {

        // No se puede agregar por que causa el error de cascadde paths caminos en cascada... 
            //El conflicto esta en los ids y los flujos entre las tres clases  Persona, Paciente y Familiar. Ahora hay error en plataforma para poder hacer que las tablas reciban datos, los datos de esta erencia con persona no son posibles de llenar y son relevantes en el proceso.... Queda pendiente.......  
             
                //public DbSet <Persona> Personas {get;set;}

        //Error aca
        public DbSet <Paciente> Pacientes {get;set;}
        public DbSet <Familiar> Familiares {get;set;}

        public DbSet <Auxiliar> Auxiliares {get;set;}
        public DbSet <Medico> Medicos {get;set;}
        
        public DbSet <Enfermera> Enfermeros {get;set;}
        
        public DbSet <HistoriaMedica> HistoriasMedicas {get;set;}
        
        public DbSet <SignoVital> SignosVitales {get;set;}
        public DbSet <SugerenciaCuidado> SugerenciasCuidados {get;set;}
        //public DbSet <Genero> Genero {get; set;}
        //public DbSet <TipoSigno> TipoSigno {get; set;} */
    
  /* Intento de solucionar relacion uno a uno  Familiar paciente por error foreignkey 
   protected override OnModelCreating (ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Paciente>()
            .HasOne ( b => b.Familiar)
            .WithOne ( i => i.Paciente)
            .HasForeignKey<Familiar> ( b => b.PacienteForeignKey);
    } */

/*
//Solucion para lo del Ciclo en cascada
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }


// used on all entities with circular relationships
             var builder = new DbModelBuilder();
                    builder.Entity<CitiesModel>()
                    .HasRequired(x => x.ct_id)
                    .WithMany()
                    .WillCascadeOnDelete(false);

            builder.Entity<ProvincesModel>()
                .HasRequired(x => x.pr_id)
                .WithMany()
                .WillCascadeOnDelete(false);*/
//"Fin" de dicha solucion 

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog= HospiCasatDataReirth");

        }

    }

    }
}