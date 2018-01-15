using System;

namespace CertificationStudies
{
    public class FormatterExample
    {
        public void Run()
        {
            //Formatações padrões
            Console.WriteLine("\nPadrões");
            Console.WriteLine(string.Format("{0:C}", 30)); // Dinheiro
            Console.WriteLine(string.Format("{0:D}", -1234)); // Decimal
            Console.WriteLine(string.Format("{0:D6}", -1234)); // Decimal com 6 casas, zero a esquerda
            Console.WriteLine(string.Format("{0:E}", 30)); // Exponencial
            Console.WriteLine(string.Format("{0:F}", 1234)); // Ponto fixo
            Console.WriteLine(string.Format("{0:G5}", 123.4546)); // compacta os pontos fixos e as notaçoes
            Console.WriteLine(string.Format("{0:N2}", 30));
            Console.WriteLine(string.Format("{0:P}", 0.514));//  porcentagem
            Console.WriteLine(string.Format("{0:X}{1:X}{2:X}", 255, 255, 255));//  hexadecimal

            //Formatações personalizadas
            Console.WriteLine("\nPersonalizadas");
            Console.WriteLine(string.Format("{0:[##-##-##]}", 126578)); // Dinheiro
            Console.WriteLine(string.Format("{0:C}", 30)); // Dinheiro
            Console.WriteLine(string.Format("{0:C}", 30)); // Dinheiro
            Console.WriteLine(string.Format("{0:C}", 30)); // Dinheiro
            Console.WriteLine(string.Format("{0:C}", 30)); // Dinheiro
            Console.WriteLine(string.Format("{0:C}", 30)); // Dinheiro
            Console.WriteLine(string.Format("{0:C}", 30)); // Dinheiro
        }
    }
}
