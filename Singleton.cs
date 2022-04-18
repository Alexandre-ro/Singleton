using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instancia = null;
        public static Singleton GetInstancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Singleton();
                    Console.WriteLine("Objeto Instânciado!");
                }

                return instancia;
            }
        }

        public void Mensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
