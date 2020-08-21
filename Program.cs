using System;

namespace URI_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracaoJogo ;
            string [] var = Console.ReadLine().Split(' ');
            horaInicial = int.Parse[0];
            horaFinal = int.Parse[0];

            if ( horaInicial < horaFinal){
                duracaoJogo = horaFinal - horaInicial;
                    Console.Log($"O JOGO DUROU {duracaoJogo} HORA(S)");
            } 
            else {
                duracaoJogo = 24 - horaInicial + horaFinal;
                    Console.Log($"O JOGO DUROU {duracaoJogo} HORA(S)");
            }
        }
    }
}
