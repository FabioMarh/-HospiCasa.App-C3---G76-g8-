
using System;

namespace HospiCasa.App.Dominio
{
    public class SugerenciaCuidado
    {
        public int id {get;set;}
        public string sugerencias {get;set;}
        
        //Relacion uno a muchos con HistoriaMedica una historia muchas sugerencias 
        
        public int idHistoriaMedica {get;set;}
        public HistoriaMedica historiaMedica {get;set;}
    }
}
