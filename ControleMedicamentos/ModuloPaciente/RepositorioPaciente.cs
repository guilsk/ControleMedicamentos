using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloPaciente
{
    internal class RepositorioPaciente
    {
        public int contadorId = 1;
        public ArrayList listaPaciente;

        public RepositorioPaciente(ArrayList listaPaciente)
        {
            this.listaPaciente = listaPaciente;
        }

        public void Inserir(Paciente paciente)
        {
            paciente.id = contadorId;
            listaPaciente.Add(paciente);
            contadorId++;
        }

        public Paciente SelecionarPorId(int id)
        {
            Paciente p = null;
            foreach (Paciente paciente in listaPaciente)
                if (paciente.id == id)
                    return paciente;
            return p;
        }

        public void Editar(Paciente paciente, int id)
        {
            Paciente p = SelecionarPorId(id);
            p.nome = paciente.nome;
            p.telefone = paciente.telefone;
        }

        public void Excluir(int id)
        {
            Paciente funcionario = SelecionarPorId(id);
            listaPaciente.Remove(funcionario);
        }
    }
}
