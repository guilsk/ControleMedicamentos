using ControleMedicamentos.Compartilhado;
using ControleMedicamentos.ModuloReposicao;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloRequisicao
{
    public class RepositorioRequisicao : RepositorioBase
    {
        public RepositorioRequisicao(ArrayList lista)
        {
            listaRegistros = lista;
        }

        public override Requisicao SelecionarPorId(int id)
        {
            return (Requisicao)base.SelecionarPorId(id);
        }
    }
}
