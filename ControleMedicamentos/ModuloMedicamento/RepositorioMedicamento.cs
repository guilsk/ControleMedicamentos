using ControleMedicamentos.Compartilhado;
using ControleMedicamentos.ModuloMedicamento;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloMedicamento
{
    public class RepositorioMedicamento : RepositorioBase
    {
        public RepositorioMedicamento(ArrayList lista)
        {
            listaRegistros = lista;
        }

        public override Medicamento SelecionarPorId(int id)
        {
            return (Medicamento)base.SelecionarPorId(id);
        }
    }
}
