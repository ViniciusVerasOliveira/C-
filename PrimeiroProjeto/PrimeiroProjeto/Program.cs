using System;
using System.Globalization;

namespace PrimeiroProjeto {
    internal class Matematica {
        static void Main(string[] args) {
            //variaveis 
            string msgFinal = "" +
                    "\nQuer tentar outro numero? Digite qualquer numero para calcularmos!  " +
                    "\nSe quiser voltar digite: 'menu' " +
                    "\nSe quiser sair digite: 'adeus'";
            
            string msgInicial = "" +
                    "\nO que quer ver: " +
                    "\n\nTabuada até 10 de um numero ? Digite '1' ou 'tabuada'" +
                    "\nOperações aritimeticas entre dois numeros ? Digite '2' ou 'operacao'";
            
            string  nOpc;
            int     t;
            double  x;
            double  y;

            Console.WriteLine("Olá, vamos calcular!" + msgInicial);

            nOpc = Console.ReadLine().ToLower();

            Valida(nOpc);

            void Valida(string nOpc) {

                if (nOpc == "1" || nOpc == "tabuada") {
                    Console.WriteLine("\nVamos multiplicar! \nDigite um numero para calcularmos: ");
                    t = int.Parse(Console.ReadLine());
                    Tabuada(t);
                }
                else if (nOpc == "2" || nOpc == "operacao") {
                    Console.WriteLine("Vamos operacionar");
                    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Operacao(x, y);
                }
                else if(nOpc == "menu") {
                    Console.WriteLine(msgInicial);
                    Valida(Console.ReadLine());
                }
                else {
                    Console.WriteLine("Eu não entendi... Vamos tentar de novo? Caso queira encerrar digite 'adeus'");
                    nOpc = Console.ReadLine().ToLower();

                    if (nOpc.ToLower() == "adeus") {
                        Console.WriteLine("Tchau, obrigado pela visita!");
                        return;
                    }else {
                        Valida(nOpc);
                    }
                }
            }
            void Tabuada(int x) {
                for (int i = 1; i <= 10; i++) {
                    Console.Write(x + " X " + i + " = " +(x * i )+"\n");
                }
                Console.WriteLine(msgFinal);
                string retorno = Console.ReadLine();
                int retornoInt; 
                bool validaRetorno = int.TryParse(retorno, out retornoInt);

                if (validaRetorno) {
                    Tabuada(int.Parse(retorno));
                }else {
                    Valida(retorno);
                }

            }

            void Operacao(double x, double y) {
                Console.WriteLine("\nAs operações simples: " +
                    "\nSoma:            "+ x + " + " + y + " = " + (x + y) +
                    "\nSubtração:       "+ x + " - " + y + " = " + (x - y) +
                    "\nSubtração:       "+ y + " - " + x + " = " + (y - x) +
                    "\nMultiplicação:   "+ x + " X " + y + " = " + (x * y) +
                    "\nDivisão:         "+ x + " / " + y + " = " + (x / y) +
                    "\nDivisão:         "+ y + " / " + x + " = " + (y / x)
                    );

                Console.WriteLine(msgFinal);
                string retorno = Console.ReadLine();
                int retornoInt;
                bool validaRetorno = int.TryParse(retorno, out retornoInt);

                if (validaRetorno) {
                    Console.WriteLine("\nDigite o segundo numero: ");
                    Operacao(double.Parse(retorno), double.Parse(Console.ReadLine()));
                }
                else {
                    Valida(retorno);
                }
            }
        }
    }
}