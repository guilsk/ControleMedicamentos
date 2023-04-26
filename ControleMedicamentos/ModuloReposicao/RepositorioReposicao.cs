using ControleMedicamentos.Compartilhado;
using ControleMedicamentos.ModuloMedicamento;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloReposicao
{
    public class RepositorioReposicao : RepositorioBase
    {
        public RepositorioReposicao(ArrayList lista) 
        {
            listaRegistros = lista; 
        }

        public override Reposicao SelecionarPorId(int id)
        {
            return (Reposicao)base.SelecionarPorId(id);
        }
    }
}
