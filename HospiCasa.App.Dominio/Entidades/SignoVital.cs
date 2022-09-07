using System;

namespace HospiCasa.App.Dominio
{
    public class SignoVital
    {
        public int id {get;set;}
        public string estadoGeneralPaciente {get;set;}
        public DateTime fechaYHora {get;set;}
        public int oximetria {get;set;}
        public int frecuenciaRespiratoria {get;set;}
        public int frecuenciaCardiaca {get;set;}
        public string temperatura {get;set;}
        public string presionArterial {get;set;}
        public string glicemias {get;set;}

        //Relacion uno a muchos un enfermero muchos signos vitales 
        public int idEnfermera {get;set;}
        public Enfermera emfermera {get;set;}
        

        //Relacion uno a muchos una historia muchos signos vitales 
        public int idHistoriaMedica {get;set;}
        public HistoriaMedica historiaMedica {get;set;}



    }
}
