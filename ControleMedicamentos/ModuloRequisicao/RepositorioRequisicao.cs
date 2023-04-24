using ControleMedicamentos.ModuloReposicao;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloRequisicao
{
    internal class RepositorioRequisicao
    {
        public int contadorId = 1;
        public ArrayList historicoRequisicao;

        public RepositorioRequisicao(ArrayList historicoRequisicao)
        {
            this.historicoRequisicao = historicoRequisicao;
        }

        public void Inserir(Requisicao requisicao)
        {
            requisicao.id = contadorId;
            historicoRequisicao.Add(requisicao);
            contadorId++;
        }
    }
}
