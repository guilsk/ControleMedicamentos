using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloFornecedor
{
    internal class RepositorioFornecedor
    {
        public int contadorId = 1;
        public ArrayList listaFornecedor;

        public RepositorioFornecedor(ArrayList listaFornecedor)
        {
            this.listaFornecedor = listaFornecedor;
        }

        public void Inserir(Fornecedor Fornecedor)
        {
            Fornecedor.id = contadorId;
            listaFornecedor.Add(Fornecedor);
            contadorId++;
        }

        public Fornecedor SelecionarPorId(int id)
        {
            Fornecedor f = null;
            foreach (Fornecedor fornecedor in listaFornecedor)
                if (fornecedor.id == id)
                    return fornecedor;
            return f;
        }

        public void Editar(Fornecedor fornecedor, int id)
        {
            Fornecedor f = SelecionarPorId(id);
            f.nome = fornecedor.nome;
            f.telefone = fornecedor.telefone;
        }

        public void Excluir(int id)
        {
            Fornecedor fornecedor = SelecionarPorId(id);
            listaFornecedor.Remove(fornecedor);
        }
    }
}
