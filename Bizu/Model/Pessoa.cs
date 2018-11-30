using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Model
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public IEnumerable<string> Validar()
        {
            if (String.IsNullOrWhiteSpace(Nome))
                yield return "O nome deve ser preenchido.";

            if (String.IsNullOrWhiteSpace(Telefone))
                yield return "O telefone deve ser preenchido.";
        }

        public IEnumerable<int> ObterNumeros()
        {
            int i = 0;
            while (true)
            {
                if (i < 5)
                    yield return i;
                else
                    yield break;

                i++;
            }
        }
    }
}