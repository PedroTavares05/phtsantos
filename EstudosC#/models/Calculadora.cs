using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudosC_.models
{
    public class Calculadora
    {
        public void Somar(float x, float y)
        {
            Console.WriteLine($"A soma dos dois savlores {x} e {y} = {x + y}");
        }

        public void Subtracao(float x, float y)
        {
            Console.WriteLine($" o valor dos numeros {x} - {y} = {x - y}");
        }

        public void Multiplication(float x, float y)
        {
            Console.WriteLine($"A multiplicação dos numeros {x} e {y} = {x * y}");
        }
        public void Division(float x, float y)
        {
            Console.WriteLine($"a divisão dos numeros {x} e {y} = {x / y}");
        }
        public void Potenciacao(int x, int y)
        {
            Double Pot = Math.Pow(x, y);
            Console.WriteLine($"{x} elevaado a {y} = {Pot}");
        }
        public void Seno(double Angulo)
        {
            Double radiante = Angulo * Math.PI / 180;
            double Sen = Math.Sin(radiante);
            Console.WriteLine($"O seno de {Angulo} é = {Math.Round(Sen, 4)}");
        }
        public void ConoSeno(double Angulo)
        {
            Double radiante = Angulo * Math.PI / 180;
            Double CosSe = Math.Cos(radiante);
            Console.WriteLine($"O angulo do  Coseno é = {Math.Round(CosSe, 4)}");
        }
        public void Tange(Double Angulo)
        {
            Double radiante = Angulo * Math.PI / 180;
            Double Tandente = Math.Tan(radiante);
            Console.WriteLine($"O angulo ce {Angulo} da Tangente é = {Math.Round(Tandente, 4)}");
        }
        public void RaizQuadrada(Double x)
        {
            Double Raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz de {x} = {Raiz}");
        }
        public void Exponencial(float x)
        { double Result= Math.Exp(x);
        Console.WriteLine($"A exponenciação do numero {x} é = {Result}");
        }
        public void LogDe10(float x)
        {
            double Result= Math.Log10(x);
            Console.WriteLine($"O log de 10 do numero {x} é = {Result}");
        }
        public void LogNormal(float x)
        {
            double  Result= Math.Log(x);
            Console.WriteLine($"O log normal do numero (x) é de = {Result}");
        }
        public void Maximo(float x, float y)
        { double Result= Math.Max(x, y);
            Console.WriteLine($"O valor maximo entre os numeros {x} e {y} é = {Result}");
        }
        public void Minimo(float x, float y)
        { Double Result = Math.Min(x, y);
            Console.WriteLine($"O valor maximo entre os numeros {x} e {y} é = {Result}");
        }
        public void LogaritimoNatural(float x)
        {
            double Result= Math.E;
            Console.WriteLine($"O valor do Logaritimo Natural é =  {Result}");
        }                
    }
}