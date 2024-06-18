using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoginRada
    {
        public class Celula
        {
            public string Nome { get; private set; }
            public string Id { get; private set; }
            public string CPF { get; private set; }
            public bool RemoverP { get; private set; }
            public bool CadastrarP { get; private set; }
            public bool AssistirP { get; private set; }
            public bool EditarP { get; private set; }
            public bool DesligarAlarmeP { get; private set; }
            
            public Celula(string nome, string id, string cpf, bool remover, bool cadastrar, bool assistir, bool desligarAlarme,bool Editar)
            {
                Nome = nome;
                Id = id;
                CPF = cpf;
                RemoverP = remover;
                CadastrarP = cadastrar;
                AssistirP = assistir;
                DesligarAlarmeP = desligarAlarme;
                EditarP = Editar;   
            }
        }
}


