using System;

namespace URI_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracaoJogo ;
            string [] array = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(array[0]);
            horaFinal = int.Parse(array[1]);

            if ( horaInicial < horaFinal){
                duracaoJogo = horaFinal - horaInicial;
                    Console.WriteLine($"O JOGO DUROU {duracaoJogo} HORA(S)");
            } 
            else {
                duracaoJogo = 24 - horaInicial + horaFinal;
                    Console.WriteLine($"O JOGO DUROU {duracaoJogo} HORA(S)");
            }
        }
    }
}
