using ControleMedicamentos.ModuloMedicamento;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloMedicamento
{
    internal class RepositorioMedicamento
    {
        public int contadorId = 1;
        public ArrayList listaMedicamento;

        public RepositorioMedicamento(ArrayList listaMedicamentos)
        {
            this.listaMedicamento = listaMedicamentos;
        }

        public void Inserir(Medicamento medicamento)
        {
            medicamento.id = contadorId;
            listaMedicamento.Add(medicamento);
            contadorId++;
        }

        public Medicamento SelecionarPorId(int id)
        {
            Medicamento m = null;
            foreach (Medicamento medicamento in listaMedicamento)
                if (medicamento.id == id)
                    return medicamento;
            return m;
        }

        public void Editar(Medicamento medicamento, int id)
        {
            Medicamento m = SelecionarPorId(id);
            m.nome = medicamento.nome;
            m.descricao = medicamento.descricao;
            m.quantidade = medicamento.quantidade;
            m.fornecedor =  medicamento.fornecedor;
        }

        public void Excluir(int id)
        {
            Medicamento medicamento = SelecionarPorId(id);
            listaMedicamento.Remove(medicamento);
        }
    }
}
