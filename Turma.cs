using System;
using System.Collections.Generic;

//SEGUNDA PARTE
/*- Faça o desafio com 3 provas
- Calcular a médiade uma prova P3
- Cadastrar endereço por aluno
- Cadastrar a data de registro do aluno 
- Cadastra e-mail;
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
        public partial class Turma
        {
            public string nome, professor;
            public List<Aluno> ListaAlunos;
            public double Media1, Media2, Media3;
            public Turma(string Nome, string Professor)
            {
                nome = Nome;
                professor = Professor;
                ListaAlunos = new List<Aluno>();
            }
            //ADICIONANDO ALUNOS
            public void AdicionarAluno(Aluno aluno)
            {
                ListaAlunos.Add(aluno);
            }
            //CALCULANDO AS MÉDIAS
            public void MediaTurma()
            {
                double soma1 = 0, soma2 = 0, soma3 = 0;


                for (int i = 0; i < ListaAlunos.Count - 1; i++)
                {
                    soma1 = soma1 + ListaAlunos[i].ListaNota[0];
                    soma2 = soma2 + ListaAlunos[i].ListaNota[1];
                    soma3 = soma3 + ListaAlunos[i].ListaNota[2];
                }
                Media1 = soma1 / ListaAlunos.Count;
                Media2 = soma2 / ListaAlunos.Count;
                Media3 = soma3 / ListaAlunos.Count;

            }

            //CALCULANDO AS MENORES NOTAS
            public Aluno MenorNota(Enums.Prova AvaliacaoTipo)
            {
                Aluno alunoMenorNota = ListaAlunos[0];

                for (int i = 1; i < ListaAlunos.Count - 1; i++)
                {
                    if (ListaAlunos[i].ListaNota[(int)AvaliacaoTipo] < alunoMenorNota.ListaNota[(int)AvaliacaoTipo])
                    {
                        alunoMenorNota = ListaAlunos[i];
                    }
                }
                return alunoMenorNota;
            }
            // CALCULANDO AS MAIORES NOTAS
            public Aluno MaiorNota(Enums.Prova AvaliacaoTipo)
            {
                Aluno alunoMaiorNota = ListaAlunos[0];
                for (int i = 1; i < ListaAlunos.Count - 1; i++)
                {
                    if (ListaAlunos[i].ListaNota[(int)AvaliacaoTipo] > alunoMaiorNota.ListaNota[(int)AvaliacaoTipo])
                    {
                        alunoMaiorNota = ListaAlunos[i];
                    }
                }
                return alunoMaiorNota;
            }
            //MOSTRAR TURMAS
            public void MostrarListaTurma()
            {
                for (int i = 0; i < ListaAlunos.Count - 1; i++)
                {
                    Console.WriteLine("\t{0} - {1}", i + 1, ListaAlunos[i].nome);
                }

            }

            //MOSTRAR DETALHES

            /* public void MostrarDetalhes(int escolha)
             {
                 if (escolha == 1){

                 Console.WriteLine("Favor inserir ao qual o aluno pertence:");
                 Console.WriteLine("Turma ");

                 Console.WriteLine("INFORMAÇÕES DO ALUNO: "+)
             }*/


        }


    }
}
