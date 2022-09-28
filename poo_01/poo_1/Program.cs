using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           aluno alunoobj = new aluno();
            Console.WriteLine("qual o seu nome?");
            alunoobj.nome=Console.ReadLine();

            Console.WriteLine("qual sua idade?");
            alunoobj.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("qual seu CPF?");
            alunoobj.cpf = double.Parse(Console.ReadLine());


            
        }
    }
}
