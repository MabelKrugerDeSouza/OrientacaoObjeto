using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Curso.Parametros
{
    public class Estudante
    {
        public string NomeEstudante { get; set; }
        public string Email { get; set; }

        public Estudante(string nome, string email)
        {
            NomeEstudante = nome;
            Email = email;
        }

        public override string ToString()
        {
            return NomeEstudante + ", " + Email; 
        }
    }
}
