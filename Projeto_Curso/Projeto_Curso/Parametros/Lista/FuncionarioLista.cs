using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Curso.Parametros
{
    public class FuncionarioLista
    {
        public int IdFuncionario { get; set; }
        public string NomeFuncionario { get; set; }
        public double Salario { get; set; }


        public void AumentoSalario(double percentual)
        {
          Salario = (Salario * (percentual / 100)) + Salario;
        }
    }
}
