using System;

namespace Licao26_08IBM {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o horário no formato 00:00");
            string[] valores = Console.ReadLine().Split(':');
            int hora = int.Parse(valores[0]);
            int minuto = int.Parse(valores[1]);

            Calculo calc = new Calculo(hora, minuto);

            calc.TempoCalc();
        }
    }
}
