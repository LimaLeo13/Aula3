using System;

namespace OperadoresLogicosCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO 1

            //Ler os valores inteiros.
            //Declarar A, B e C.
            //Imprimir na tela soma de A e B.

            int numeroA, numeroB, numeroC;

            Console.WriteLine("Digite numeroA");
            numeroA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite numeroB");
            numeroB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite numeroC");
            numeroC = Convert.ToInt32(Console.ReadLine());

            if (numeroA + numeroB > numeroC)
            {
                Console.WriteLine("A soma de A + B é maior que C");
            }
            else if (numeroA + numeroB < numeroC)
            {
                Console.WriteLine("A soma de A + B é menor que C");
            }

            else
            {
                Console.WriteLine("A soma de A + B é igual a C");
            }

            //EXERCICIO 2

            //Ler os valores inteiros
            //Mostrar na tela se o numero é impar ou par
            //Mostrar na tela se o numero é positivo ou negativo

            int numero;

            Console.WriteLine("Digite um numero");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("Numero Positivo");
            }

            else
            {
                Console.WriteLine("Numero Negativo");
            }

            if (numero % 2 == 0)
            {
                Console.WriteLine("Numero Par");
            }

            else
            {
                Console.WriteLine("Numero Impar");
            }


            //LISTA 2 EXERCICIO 5

            //Leia o codigo de um produto
            //Leia a quantidade de itens comprados deste produto
            //Mostre no console o valor total da compra

            int codigo = 0, preco = 0;
            int quantidade;
            string produto = "";

            Console.WriteLine("Digite o codigo");
            codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade");
            quantidade = Convert.ToInt32(Console.ReadLine());

            switch (codigo){
                case 1:
                    produto = "Cachorro-Quente";
                    preco = 10;
                    break;
                case 2:
                    produto = "X - Salada";
                    preco = 15;
                    break;
                case 3:
                    produto = "X - Bacon";
                    preco = 18;
                    break;
                case 4:
                    produto = "Bauru";
                    preco = 12;
                    break;
                case 5:
                    produto = "Refrigerante";   
                    preco = 8;
                    break;
                case 6:
                    produto = "Suco de Laranja";
                    preco = 13;
                    break;

                }


            Console.WriteLine($"Produto:{produto} \n Total: {preco * quantidade}");


            //LISTA 2 EXERCICIO 6 












            }
        }
    }