using System;

namespace HospiCasa.App.Persistencia
{
    public interface IRepositorioAuxiliar
    {   

// Sprint 2 //        
        //  Sprint 2 / Agregar paciente HU - 01 
        public Paciente addPaciente (Paciente paciente);

        // Sprint 2 / Adicionar datos medico HU - 02
        public Medico addMedico (Medico medico);

        // Sprint 2 / Adicionar datos de un Familiar HU - 03
        public Paciente addFamiliar (Paciente paciente);

        // Sprint 2 / Consultar pacientes registrados HU - 04
        public IEnumerable <Paciente> getAllPacientes();

        // Sprint 2 /Consultar informacion de un paciente 
        public Paciente getPaciente (int idPaciente);
// Fin Historias de usuario de Sprint 2 
    
    // Falta implementar En repositorio..... al parecer hay que corregir de nuevo el diagrama de relaciones   




        //public void deletePaciente (Paciente paciente);
         
    }
}