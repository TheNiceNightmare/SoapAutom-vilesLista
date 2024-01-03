using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapAutomóvilesLista.BusinessMessage
{
    public class AutomóvilesRespuesta
    {
        public List<Automóviles> respuestaDeAutomóviles { get; set; }

        public bool ActionResult { get; set; }

        public string Error { get; set; }
    }
}