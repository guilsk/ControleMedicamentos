﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloFornecedor
{
    internal class Fornecedor
    {
        public string nome;
        public string telefone;
        public int id;
        public Fornecedor()
        {
        }

        public Fornecedor(string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
        }
    }
}
