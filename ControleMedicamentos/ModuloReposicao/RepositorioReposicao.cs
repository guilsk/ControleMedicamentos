using ControleMedicamentos.ModuloMedicamento;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloReposicao
{
    internal class RepositorioReposicao
    {
        public int contadorId = 1;
        public ArrayList historicoReposicao;

        public RepositorioReposicao(ArrayList historicoReposicao) 
        {
            this.historicoReposicao = historicoReposicao; 
        }

        public void Inserir(Reposicao reposicao)
        {
            reposicao.id = contadorId;
            historicoReposicao.Add(reposicao);
            contadorId++;
        }

    }
}
