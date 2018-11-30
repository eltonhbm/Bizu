using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Controller
{
    public class SaqueCedulas
    {
        public string Sacar(string _ValorSaque)
        {
            int ValorSaque = 0;
            int Nota100Count = 0;
            int Nota50Count = 0;
            int Nota20Count = 0;
            int Nota10Count = 0;
            int Nota5Count = 0;
            int Nota2Count = 0;

            try
            {
                ValorSaque = Convert.ToInt32(_ValorSaque);

                if (ValorSaque == 1 || ValorSaque == 3)
                    return "Não temos cédulas de 1 real nem moedas. Saque outro valor.";
            }
            catch
            {
                return "Não é possivel efetuar saque com centavos.";
            }

            while (ValorSaque >= 100)
            {
                ValorSaque = ValorSaque - 100;
                Nota100Count++;
            }
            while (ValorSaque >= 50)
            {
                ValorSaque = ValorSaque - 50;
                Nota50Count++;
            }
            while (ValorSaque >= 20)
            {
                ValorSaque = ValorSaque - 20;
                Nota20Count++;
            }
            while (ValorSaque >= 10)
            {
                ValorSaque = ValorSaque - 10;
                Nota10Count++;
            }
            while (ValorSaque >= 5)
            {
                ValorSaque = ValorSaque - 5;
                Nota5Count++;
            }
            while (ValorSaque >= 2)
            {
                ValorSaque = ValorSaque - 2;
                Nota2Count++;
            }

            string notas = "O saque retornará:\n\n";

            if (Nota100Count > 0)
                notas += Nota100Count + " notas de 100\n";
            if (Nota50Count > 0)
                notas += Nota50Count + " notas de 50\n";
            if (Nota20Count > 0)
                notas += Nota20Count + " notas de 20\n";
            if (Nota10Count > 0)
                notas += Nota10Count + " notas de 10\n";
            if (Nota5Count > 0)
                notas += Nota5Count + " notas de 5\n";
            if (Nota2Count > 0)
                notas += Nota2Count + " notas de 2";

            return notas;
        }
    }
}