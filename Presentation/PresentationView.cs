using System.Collections.Generic;

namespace aec_webapi_ef.Presentation{

    public class PresentationView
    {
        public string Mensagem
        {
             get{ return "Página de apresentação"; }        
        }

        public List<string> Endpoints
        {
             get{ return new List<string>()
             {
                 "api/candidatos",
                 "api/profissoes"
             }; 
             }        
        }
    }
}