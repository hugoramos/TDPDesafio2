using System;
using System.Collections.Generic;
//SEGUNDA PARTE
/*- Faça o desafio com 3 provas
- Calcular a médiade uma prova P3
- Cadastra endereço por aluno
- Cadastrar a data de registro do aluno 
- Cadastrar e-mail
- Criar uma segunda turma
- Atribuir notas aos alunos nas duas turmas;
- Calcular medias notas p1 e p2 das duas turmas;
- Deletar aluno de uma determinada turma
- Atribuir professor a uma turma
- Deletar professor de uma turma
- Como listar os alunos de uma turma e o professor da turma*/
namespace Desafio_Parte2
{
    partial class Program
    {
        public partial class Aluno
        {
            public string nome, endereço, email, data;
            public int idade;
            public List<Double> ListaNota;
            public Aluno(string Nome, int Idade, string Endereço, string Email, string Data, List<Double> notas = null)
            {
                nome = Nome;
                idade = Idade;
                endereço = Endereço;
                email = Email;
                data = Data;
                ListaNota = notas;
            }
            public void AdicionarNotas(double[] notas)
            {
                ListaNota = new List<double>();

                AdicionarNota(notas[0]);
                AdicionarNota(notas[1]);
                AdicionarNota(notas[2]);
            }

            public void AdicionarNota(double nota)
            {
                if (ListaNota == null) ListaNota = new List<double>();

                ListaNota.Add(nota);
            }
        }
    }
}
