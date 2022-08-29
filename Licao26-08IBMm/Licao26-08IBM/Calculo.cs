using System;
using System.Collections.Generic;
using System.Text;

namespace Licao26_08IBM {

    class Calculo {
        public int Hora { get; }
        public int Minuto { get;}
        public int Resto { get; set; }

        public Calculo(int hora, int minuto) {
            Hora = hora;
            Minuto = minuto;
        }
        public void TempoCalc() {

            if (Hora < 8 && Minuto < 01 || Hora < 7) {
                Console.WriteLine("Atraso maximo: " + 0);
            }
            else {
                Resto = (Hora - 7) * 60 + Minuto;
                Console.WriteLine("Atraso maximo: " + Resto);
            }
        }
    }
}