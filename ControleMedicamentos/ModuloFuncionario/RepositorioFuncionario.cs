using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloFuncionario
{
    internal class RepositorioFuncionario
    {
        public int contadorId = 1;
        public ArrayList listaFuncionario;

        public RepositorioFuncionario(ArrayList listaFuncionario)
        {
            this.listaFuncionario = listaFuncionario;
        }

        public void Inserir(Funcionario funcionario)
        {
            funcionario.id = contadorId;
            listaFuncionario.Add(funcionario);
            contadorId++;
        }

        public Funcionario SelecionarPorId(int id)
        {
            Funcionario f = null;
            foreach (Funcionario funcionario in listaFuncionario)
                if (funcionario.id == id)
                    return funcionario;
            return f;
        }

        public void Editar(Funcionario funcionario, int id)
        {
            Funcionario f = SelecionarPorId(id);
            f.nome = funcionario.nome;
            f.telefone = funcionario.telefone;
        }

        public void Excluir(int id)
        {
            Funcionario funcionario = SelecionarPorId(id);
            listaFuncionario.Remove(funcionario);
        }
    }
}
