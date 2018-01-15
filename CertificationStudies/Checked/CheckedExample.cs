using System;

namespace CertificationStudies
{
    public class CheckedExample
    {
        public void Run()
        {
            try
            {
                // Este exemplo causara um erro no compilador pq 2147483647 é o valor maximo para inteiros
                //int i1 = 2147483647 + 10;

                // Este exemplo que inclui a variavel dez não causara um erro no compilador
                int ten = 10;
                int i2 = 2147483647 + ten;

                // Por padrão, o fluxo na linha anterior não causa errors em tempo de execução
                // A proxima linha mostra
                // -2,147,483,639 como a soma de 2,147,483,647 and 10.
                Console.WriteLine(i2);

                //não vai lançar exeção
                int i3 = unchecked(2147483647 + ten);

                //Vai lançar exeção
                int i4 = checked(2147483647 + ten);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
