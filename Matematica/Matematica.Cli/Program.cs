using System;
using Matematica.negocio;

namespace Matematica.Cli
{
    class Program
    {
        static void Main(string[] args)
        {

            var primerNumero = "";
            var opcion = 0;
            var segundoNumero = "";
            var miCalculadora = new Calculadora();
            do
            {
                Console.Clear();
                Console.WriteLine("**************************");
                Console.WriteLine("*       09/12/2020       *");
                Console.WriteLine("*                        *");
                Console.WriteLine("*    CALCULADORA EN C#   *");
                Console.WriteLine("*     USANDO UNIT-TEST   *");
                Console.WriteLine("**************************");
                Console.WriteLine("(1) Sumar números enteros");
                Console.WriteLine("(2) Sumar números complejos");
                Console.WriteLine("(3) Restar números complejos");
                Console.WriteLine("(4) Multiplicar números complejos");
                Console.WriteLine("(5) Dividir números complejos");
                Console.WriteLine("(6) Escalar por número complejo");
                Console.WriteLine("(7) Salir");
                Console.WriteLine("Seleccione una opción del menú: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Elegiste sumar");
                        Console.WriteLine("Ingrese el primer numero");
                        primerNumero = Console.ReadLine();
                        Console.WriteLine("Ingrese el segundo numero");
                        segundoNumero = Console.ReadLine();
                        var respuesta = miCalculadora.Sumar(double.Parse(primerNumero), double.Parse(segundoNumero));
                        Console.WriteLine("La respuesta es: " + respuesta);
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Elegiste Sumar numeros complejos");
                        Console.WriteLine("Ingrese la parte real del primer numero complejo");
                        var realA = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la parte imaginaria del primer numero complejo");
                        var imaginarioA = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la parte real del segundo numero complejo");
                        var realB = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la parte imaginaria del segundo numero complejo");
                        var imaginarioB = double.Parse(Console.ReadLine());
                        var primerComplejo = new Complejo(realA, imaginarioA);
                        var segundoComplejo = new Complejo(realB, imaginarioB);

                        var respuestaSumaComplejos = miCalculadora.SumarComplejos(primerComplejo, segundoComplejo);

                        Console.WriteLine("La respuesa de la suma de los complejos es: " + respuestaSumaComplejos.getX() + " , " + respuestaSumaComplejos.getY()+"i");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 3:

                        Console.WriteLine("Elegiste Restar numeros complejos");
                        Console.WriteLine("Ingrese la parte real del primer numero complejo");
                        var realAR = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la parte imaginaria del primer numero complejo");
                        var imaginarioAR = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la parte real del segundo numero complejo");
                        var realBR = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la parte imaginaria del segundo numero complejo");
                        var imaginarioBR = double.Parse(Console.ReadLine());
                        var primerComplejoR = new Complejo(realAR, imaginarioAR);
                        var segundoComplejoR = new Complejo(realBR, imaginarioBR);

                        var respuestaRestaComplejos = miCalculadora.RestarComplejos(primerComplejoR, segundoComplejoR);

                        Console.WriteLine("La respuesa de la resta de los complejos es: " + respuestaRestaComplejos.getX() + " , " + respuestaRestaComplejos.getY()+"i");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 4:

                        Console.WriteLine("Elegiste Multiplicar numeros complejos");
                        Console.WriteLine("Ingrese la parte real del primer numero complejo");
                        var realAM = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la parte imaginaria del primer numero complejo");
                        var imaginarioAM = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la parte real del segundo numero complejo");
                        var realBM = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la parte imaginaria del segundo numero complejo");
                        var imaginarioBM = double.Parse(Console.ReadLine());
                        var primerComplejoM = new Complejo(realAM, imaginarioAM);
                        var segundoComplejoM = new Complejo(realBM, imaginarioBM);

                        var respuestaMultiplicacionComplejos = miCalculadora.MultiplicarComplejos(primerComplejoM, segundoComplejoM);

                        Console.WriteLine("La respuesa de la multiplicación de los complejos es: " + respuestaMultiplicacionComplejos.getX() + " , " + respuestaMultiplicacionComplejos.getY()+"i");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 5:

                        Console.WriteLine("Elegiste Dividir numeros complejos");
                        Console.WriteLine("Ingrese la parte real del primer numero complejo");
                        var realAD = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la parte imaginaria del primer numero complejo");
                        var imaginarioAD = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la parte real del segundo numero complejo");
                        var realBD = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la parte imaginaria del segundo numero complejo");
                        var imaginarioBD = double.Parse(Console.ReadLine());
                        var primerComplejoD = new Complejo(realAD, imaginarioAD);
                        var segundoComplejoD = new Complejo(realBD, imaginarioBD);

                        var respuestaDivisionComplejos = miCalculadora.DividirComplejos(primerComplejoD, segundoComplejoD);

                        Console.WriteLine("La respuesa de la división de los complejos es: " + "(" + respuestaDivisionComplejos[0] +")" + " , " + "(" + respuestaDivisionComplejos[1] +")" +"(i)");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine(" Elegiste Escalar por número complejo");
                        Console.WriteLine("Ingrese la parte real del primer numero complejo");
                        var realAE = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la parte imaginaria del primer numero complejo");
                        var imaginarioAE = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el escalar");
                        var escalar = int.Parse(Console.ReadLine());


                        var primerComplejoE = new Complejo(realAE, imaginarioAE);

                        var respuestaEscalar = miCalculadora.MultiplicacionPorUnEscalar(primerComplejoE, escalar);

                        Console.WriteLine("La respuesa de la multiplicacion por el escalar es de los complejos es: " + respuestaEscalar.getX() + " , " + respuestaEscalar.getY() + "i");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("La opción escogida no esta dentro del menú vuelve a digitarlo porfavor");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                }
            } while (opcion != 7);
            
        }
    }
}
