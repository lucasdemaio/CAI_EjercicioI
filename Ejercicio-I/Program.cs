using System.Xml;

namespace Ejercicio_I
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Ejercicio I 
            Crear una aplicación que cuente desde el número 1 hasta los últimos tres dígitos del
            propio número de registro(en caso de ser comenzar con 0, sumarle 100), todos los
            números deben mostrarse por pantalla y, con los múltiplos de 3 se debera agregar
            “Foo”, con los múltiplos de 5, “Bar”, y, por último, con los múltiplos de ambos, “FooBar”. 
            Por ejemplo, con el número mostrará “15 – FooBar”.*/

            int registro = 853392;
            int ultimosTresNumeros = registro % 1000;

            if (ultimosTresNumeros < 100)
            {
                ultimosTresNumeros += 100;
            }

            for (int i = 1; i <= ultimosTresNumeros; i++) 
            {
                string resultado = "";

                if (i % 3 == 0) 
                {
                    resultado += "Foo";
                }

                if (i % 5 == 0)
                {
                    resultado += "Bar";
                }

                if (resultado == "")
                {
                    resultado = i.ToString();
                }

                Console.WriteLine($"{i} - {resultado}");

            }            
        }
    }
}
