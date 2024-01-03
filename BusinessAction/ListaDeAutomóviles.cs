using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoapAutomóvilesLista.BusinessMessage;

namespace SoapAutomóvilesLista.BusinessAction
{
    public class ListaDeAutomóviles
    {
        public static AutomóvilesRespuesta GetAllAutomóviles()
        {
            var automóviles = new List<Automóviles>()
            {
                new Automóviles()
                {
                    NombresDeAutomóviles= "Ferrari"
                },
                new Automóviles()
                {
                    NombresDeAutomóviles= "Lamborghini"
                },
                new Automóviles()
                {
                    NombresDeAutomóviles= "Aston Martin"
                },
                new Automóviles()
                {
                    NombresDeAutomóviles= "Porsche"
                },
                new Automóviles()
                {
                    NombresDeAutomóviles= "Rolls Royce"
                },
                new Automóviles()
                {
                    NombresDeAutomóviles= "Bentley"
                },
                new Automóviles()
                {
                    NombresDeAutomóviles= "Jaguar"
                },


            };

            return new AutomóvilesRespuesta()
            {
                respuestaDeAutomóviles = automóviles
            };
        }

    }
}