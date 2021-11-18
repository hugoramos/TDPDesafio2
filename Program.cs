using System;
using System.Collections.Generic;

//SEGUNDA PARTE
/*
- Faça o desafio com 3 provas
- Calcular a média de uma prova P4
- Cadastra endereço por aluno
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
        static void Main(string[] args)
        {
            var turmaA = CriaTurmaA();
            var turmaB = CriaTurmaB();

            Aluno alunoMaiorNotaAp1 = ValidaMaiorNota(turmaA, turmaB, Enums.Prova.AP1);
            Aluno alunoMaiorNotaAp2 = ValidaMaiorNota(turmaA, turmaB, Enums.Prova.AP2);
            Aluno alunoMaiorNotaAp3 = ValidaMaiorNota(turmaA, turmaB, Enums.Prova.AP3);

            Aluno alunoMenorNotaAp1 = ValidaMenorNota(turmaA, turmaB, Enums.Prova.AP1);
            Aluno alunoMenorNotaAp2 = ValidaMenorNota(turmaA, turmaB, Enums.Prova.AP2);
            Aluno alunoMenorNotaAp3 = ValidaMenorNota(turmaA, turmaB, Enums.Prova.AP3);

            //SAÍDAS
            int aux0 = 1;

            while (aux0 == 1)
            {
                Console.Clear();
                Console.WriteLine("Escolha a opção desejada:");
                Console.WriteLine("\t1 - Resultados individuais e gerais das Turmas {0} e {1}", turmaA.nome, turmaB.nome);
                Console.WriteLine("\t2 - Listar alunos e professores da turma {0} e {1}", turmaA.nome, turmaB.nome);
                Console.WriteLine("\t4 - Apagar aluno");
                Console.WriteLine("\t3 - Encerrar");

                int escolha0 = int.Parse(Console.ReadLine());

                if (escolha0 == 1)
                {
                    Console.Clear();
                    Console.WriteLine("----------------- RESULTADOS DA TURMA {0} -----------------------", turmaA.nome);
                    Console.WriteLine("A média da turma " + turmaA.nome + " para a AV1 é:" + turmaA.Media1);
                    Console.WriteLine("A média da turma " + turmaA.nome + " para a AV2 é:" + turmaA.Media2);
                    Console.WriteLine("A média da turma " + turmaA.nome + " para a AV3 é:" + turmaA.Media2 + "\n");
                    Console.WriteLine("----------------- RESULTADOS DA TURMA {0} -----------------------", turmaB.nome);
                    Console.WriteLine("A média da turma " + turmaB.nome + " para a AV1 é:" + turmaB.Media1);
                    Console.WriteLine("A média da turma " + turmaB.nome + " para a AV2 é:" + turmaB.Media2);
                    Console.WriteLine("A média da turma " + turmaB.nome + " para a AV3 é:" + turmaB.Media3 + "\n");
                    Console.WriteLine("----------------- RESULTADOS GERAIS -----------------------");

                    Console.WriteLine("A menor nota da AP1 foi " + alunoMenorNotaAp1.ListaNota[(int)Enums.Prova.AP1] + " do aluno " + alunoMenorNotaAp1.nome);
                    Console.WriteLine("A menor nota da AP2 foi " + alunoMenorNotaAp2.ListaNota[(int)Enums.Prova.AP2] + " do aluno " + alunoMenorNotaAp2.nome);
                    Console.WriteLine("A menor nota da AP3 foi " + alunoMenorNotaAp3.ListaNota[(int)Enums.Prova.AP3] + " do aluno " + alunoMenorNotaAp3.nome);

                    Console.WriteLine("A maior nota da AP1 foi " + alunoMaiorNotaAp1.ListaNota[(int)Enums.Prova.AP1] + " do aluno " + alunoMaiorNotaAp1.nome);
                    Console.WriteLine("A maior nota da AP2 foi " + alunoMaiorNotaAp2.ListaNota[(int)Enums.Prova.AP2] + " do aluno " + alunoMaiorNotaAp2.nome);
                    Console.WriteLine("A maior nota da AP3 foi " + alunoMaiorNotaAp3.ListaNota[(int)Enums.Prova.AP3] + " do aluno " + alunoMaiorNotaAp3.nome + "\n");

                    Console.WriteLine("ESCOLHA A OPÇÃO DESEJADA:");
                    Console.WriteLine("\t1 - Voltar ao Menu anterior");
                    Console.WriteLine("\t2 - Encerrar");
                    Console.Write("Opção desejada:");
                    int escolha1 = int.Parse(Console.ReadLine());
                    if (escolha1 == 1)
                    {
                        aux0 = 1;
                        Console.Clear();
                    }
                    else
                    {
                        break;
                    }
                }

                else if (escolha0 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("----------------- LISTA DE ALUNOS DA TURMA {0} -----------------------", turmaA.nome);
                    turmaA.MostrarListaTurma();
                    Console.WriteLine("Professor responsável: " + turmaA.professor);
                    Console.WriteLine("\n");
                    Console.WriteLine("----------------- LISTA DE ALUNOS DA TURMA {0} -----------------------", turmaB.nome);
                    turmaB.MostrarListaTurma();
                    Console.WriteLine("Professor responsável: " + turmaB.professor);
                    Console.WriteLine("\n");
                    Console.WriteLine("ESCOLHA A OPÇÃO DESEJADA:");
                    Console.WriteLine("\t1 - Voltar ao Menu anterior");
                    Console.WriteLine("\t2 - Encerrar");
                    Console.Write("Opção desejada:");
                    int escolha2 = int.Parse(Console.ReadLine());
                    if (escolha2 == 1)
                    {
                        aux0 = 1;
                        Console.Clear();
                    }
                    else
                    {
                        break;
                    }

                }

                else if (escolha0 == 3)
                {
                    break;
                }

                else if (escolha0 == 4)
                {
                    Console.Clear();
                    Console.WriteLine("----------------- LISTA DE ALUNOS DA TURMA A -----------------------", turmaA.nome);
                    turmaA.MostrarListaTurma();

                    int escolha1 = int.Parse(Console.ReadLine());

                    turmaA.ListaAlunos.RemoveAt(escolha1 - 1);

                    Console.Clear();
                    Console.WriteLine("----------------- LISTA DE ALUNOS DA TURMA A -----------------------", turmaA.nome);
                    turmaA.MostrarListaTurma();

                    // break;
                }

            }

        }

        static Turma CriaTurmaA()
        {
            Aluno aluno1 = new Aluno("Paloma", 27, "rua 41, número 247, Fortaleza", "paloma@trilogo.com.br", "10/10/2021", new List<Double> { 11, 3, 7 });
            Aluno aluno2 = new Aluno("Pablo", 25, "rua 41, número 247, Fortaleza", "pablo@trilogo.com.br", "10/10/2021");
            Aluno aluno3 = new Aluno("Polytiana", 30, "rua 27, número 247, Fortaleza", "polytiana@trilogo.com.br", "10/10/2021");
            Aluno aluno4 = new Aluno("Pamella", 33, "rua 39, número 222, Fortaleza", "pamella@trilogo.com.br", "10/10/2021");
            Aluno aluno5 = new Aluno("Socorro", 33, "rua 27, número 455", "socorro@trilogo.com.br", "10/10/2021");
            Aluno aluno6 = new Aluno("Wilton", 33, "rua 43, número 276, Fortaleza", "wilton@trilogo.com.br", "10/10/2021");
            Aluno aluno7 = new Aluno("Estêvão", 33, "rua 41, número 261, Fortaleza, Fortaleza", "estevao@trilogo.com.br", "10/10/2021");
            Aluno aluno8 = new Aluno("Priscila", 33, "rua 41, número 500, Fortaleza", "priscila@trilogo.com.br", "10/10/2021");

            // aluno1.AdicionarNotas(new double[] { 11, 3, 7 });

            aluno2.AdicionarNota(11);
            aluno2.AdicionarNota(3);
            aluno2.AdicionarNota(7);

            aluno2.AdicionarNotas(new double[] { 11, 3, 7 });
            aluno3.AdicionarNotas(new double[] { 11, 3, 7 });
            aluno4.AdicionarNotas(new double[] { 11, 3, 7 });
            aluno5.AdicionarNotas(new double[] { 11, 3, 7 });
            aluno6.AdicionarNotas(new double[] { 11, 3, 7 });
            aluno7.AdicionarNotas(new double[] { 11, 3, 7 });
            aluno8.AdicionarNotas(new double[] { 11, 3, 7 });


            Turma turmaA = new Turma("1º ano_A", "Cássio");
            //Pergurntar como adicionar todos os aluno de uma só vez na turma
            turmaA.AdicionarAluno(aluno1);
            turmaA.AdicionarAluno(aluno2);
            turmaA.AdicionarAluno(aluno3);
            turmaA.AdicionarAluno(aluno4);
            turmaA.AdicionarAluno(aluno5);
            turmaA.AdicionarAluno(aluno6);
            turmaA.AdicionarAluno(aluno7);
            turmaA.AdicionarAluno(aluno8);

            turmaA.MediaTurma();

            return turmaA;
        }

        static Turma CriaTurmaB()
        {
            //Criando os alunos     

            //TURMA 2
            Turma turmaB = new Turma("1º ano_B", "Luciana");

            Aluno aluno9 = new Aluno("Caio", 27, "rua 41, número 247, Boa Viagem", "paloma@trilogo.com.br", "10/10/2021");
            Aluno aluno10 = new Aluno("Joana", 25, "rua 45, número 247, Boa Viagem", "joana@trilogo.com.br", "10/10/2021");
            Aluno aluno11 = new Aluno("Luís", 30, "rua 54, número 247, Boa Viagem", "luís@trilogo.com.br", "10/10/2021");
            Aluno aluno12 = new Aluno("Aretuza", 33, "rua 36, número 247, Boa Viagem", "aretuza@trilogo.com.br", "10/10/2021");
            Aluno aluno13 = new Aluno("Luana", 33, "rua 87, número 247, Boa Viagem", "luana@trilogo.com.br", "10/10/2021");
            Aluno aluno14 = new Aluno("Aline", 33, "rua 93, número 247, Boa Viagem", "alinema@trilogo.com.br", "10/10/2021");
            Aluno aluno15 = new Aluno("Souza", 33, "rua 34, número 247, Boa Viagem", "souza@trilogo.com.br", "10/10/2021");
            Aluno aluno16 = new Aluno("Riquelme", 33, "rua 57, número 247, Boa Viagem", "riquelme@trilogo.com.br", "10/10/2021");

            aluno9.AdicionarNotas(new double[] { 10, 3, 7 });
            aluno10.AdicionarNotas(new double[] { 9.8, 3, 10 });
            aluno11.AdicionarNotas(new double[] { 9.7, 3, 7 });
            aluno12.AdicionarNotas(new double[] { 6, 3, 7 });
            aluno13.AdicionarNotas(new double[] { 5, 0, 7 });
            aluno14.AdicionarNotas(new double[] { 4, 3, 7 });
            aluno15.AdicionarNotas(new double[] { 9.9, 3, 5.5 });
            aluno16.AdicionarNotas(new double[] { 8, 8, 7 });

            turmaB.AdicionarAluno(aluno9);
            turmaB.AdicionarAluno(aluno10);
            turmaB.AdicionarAluno(aluno11);
            turmaB.AdicionarAluno(aluno12);
            turmaB.AdicionarAluno(aluno13);
            turmaB.AdicionarAluno(aluno14);
            turmaB.AdicionarAluno(aluno15);
            turmaB.AdicionarAluno(aluno16);

            turmaB.MediaTurma();

            return turmaB;
        }

        static Aluno ValidaMaiorNota(Turma turmaA, Turma turmaB, Enums.Prova prova)
        {
            Aluno aluno;

            if (turmaA.MaiorNota(prova).ListaNota[(int)prova] < turmaB.MaiorNota(prova).ListaNota[(int)prova])
            {
                aluno = turmaB.MaiorNota(prova);
            }
            else
            {
                aluno = turmaA.MaiorNota(prova);
            }

            return aluno;
        }

        static Aluno ValidaMenorNota(Turma turmaA, Turma turmaB, Enums.Prova prova)
        {
            Aluno aluno;

            if (turmaA.MenorNota(prova).ListaNota[(int)prova] > turmaB.MenorNota(prova).ListaNota[(int)prova])
            {
                aluno = turmaB.MenorNota(prova);
            }
            else
            {
                aluno = turmaA.MenorNota(prova);
            }

            return aluno;
        }
    }
}
