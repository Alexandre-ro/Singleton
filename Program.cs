using System;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Padrão de Projeto Singleton");

            Singleton jog1 = Singleton.GetInstancia;
            jog1.Mensagem("Bola com o jogador 1.");

            Singleton jog2 = Singleton.GetInstancia;
            jog2.Mensagem("Bola com o jogador 2");

            Console.ReadKey();
        }
    }
}
