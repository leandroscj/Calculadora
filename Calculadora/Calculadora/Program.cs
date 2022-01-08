using Calculadora.Calculos;
using System;

namespace Calculo_de_notas_da_escola
{
    class Program
    {
        private static List<long> numeros = new List<long>();
        static Subtracao subtracao = new Subtracao();
        static Multiplicação multiplicacao = new Multiplicação();
        static Divisao divisao = new Divisao();
        static Adicao adicao = new Adicao();
       
         static void Main(string[] args)
        {
            
            
            Console.WriteLine("Qual calculo a fazer? ");
            Console.WriteLine("(s)= Subtração (m)=Multiplicação (a)=Adição (d)=Divisão");
            string calculo = Console.ReadLine();
           
            Console.WriteLine("Digite numero e de enter, ao terminar digite (ok) para realizar o calculo");
            Calculos(calculo);
            Resultado(calculo);
            
        }

        public static void Calculos(string calculo)
        {
            if (calculo == "s")
            {
                string s = null;
                while (s != "ok")
                {
                    string valor = Console.ReadLine();
                    if (valor != "ok")
                    {
                        long i = int.Parse(valor);
                        numeros.Add(i);
                    }
                    else
                    {
                        s = "ok";
                    }
                }
                subtracao.calculo(numeros);

            }
            if (calculo == "a")
            {
                string s = null;
                while (s != "ok")
                {
                    string valor = Console.ReadLine();
                    if (valor != "ok")
                    {
                        long i = int.Parse(valor);
                        numeros.Add(i);
                    }
                    else
                    {
                        s = "ok";
                    }
                }
                adicao.calculo(numeros);
            }
            if (calculo == "d")
            {
                string s = null;
                while (s != "ok")
                {
                    string valor = Console.ReadLine();
                    if (valor != "ok")
                    {
                        long i = int.Parse(valor);
                        numeros.Add(i);
                    }
                    else
                    {
                        s = "ok";
                    }
                }
                divisao.calculo(numeros);
            }
            if (calculo == "m")
            {
                string s = null;
                while (s != "ok")
                {
                    string valor = Console.ReadLine();
                    if (valor != "ok")
                    {
                        long i = int.Parse(valor);
                        numeros.Add(i);
                    }
                    else
                    {
                        s = "ok";
                    }
                }
                multiplicacao.calculo(numeros);

            }
        }

        public static void Resultado(string calculo)
        {
            if(calculo == "d")
            {
                long saldo = divisao.Saldo;
                Console.WriteLine($"Resultado = {saldo}");
            }
            if (calculo == "a")
            {
                long saldo = adicao.Saldo;
                Console.WriteLine($"Resultado = {saldo}");
            }
            if (calculo == "s")
            {
                long saldo = subtracao.Saldo;
                Console.WriteLine($"Resultado = {saldo}");
            }
            if (calculo == "m")
            {
                long saldo = multiplicacao.Saldo;
                Console.WriteLine($"Resultado = {saldo}");
            }
        }
    }
}
