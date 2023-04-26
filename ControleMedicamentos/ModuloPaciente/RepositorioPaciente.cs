using ControleMedicamentos.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloPaciente
{
    public class RepositorioPaciente : RepositorioBase
    {
        public RepositorioPaciente(ArrayList lista)
        {
            listaRegistros = lista;
        }

        public override Paciente SelecionarPorId(int id)
        {
            return (Paciente)base.SelecionarPorId(id);
        }
    }
}
