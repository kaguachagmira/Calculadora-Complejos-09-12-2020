using System;

namespace Matematica.negocio
{
    public class Calculadora
    {
        public Calculadora()
        {
        }

        public double Sumar(double primerNumero, double segundoNumero)
        {
            return primerNumero + segundoNumero;
        }
        public Complejo SumarComplejos(Complejo primerComplejo, Complejo segundoComplejo)
        {
            var parteReal = primerComplejo.getX() + segundoComplejo.getX();
            var parteImaginaria = primerComplejo.getY() + segundoComplejo.getY();

            return new Complejo(parteReal, parteImaginaria);
        }

        public Complejo RestarComplejos(Complejo primerComplejo, Complejo segundoComplejo)
        {
            var parteReal = primerComplejo.getX() - segundoComplejo.getX();
            var parteImaginaria = primerComplejo.getY() - segundoComplejo.getY();

            return new Complejo(parteReal, parteImaginaria);
        }
        public Complejo MultiplicacionPorUnEscalar(Complejo primerComplejo, double segundoComplejo)
        {
            var parteReal = primerComplejo.getX() * segundoComplejo;
            var parteImaginaria = primerComplejo.getY() * segundoComplejo;

            return new Complejo(parteReal, parteImaginaria);
        }
        
        public Complejo MultiplicarComplejos(Complejo primerComplejo, Complejo segundoComplejo)
        {
            var parteReal = (primerComplejo.getX() * segundoComplejo.getX()) - (primerComplejo.getY() * segundoComplejo.getY()); 
            var parteImaginaria = (primerComplejo.getX() * segundoComplejo.getY()) + (primerComplejo.getY() * segundoComplejo.getX()) ;

            return new Complejo(parteReal, parteImaginaria);
        }
        public String [] DividirComplejos(Complejo primerComplejo, Complejo segundoComplejo)
        {
            string[] resultados = new string[2];

            var dividendoParteReal = (primerComplejo.getX() * segundoComplejo.getX()) - (primerComplejo.getY() * (segundoComplejo.getY()*-1));
            var dividendoParteImaginaria = (primerComplejo.getX() * (segundoComplejo.getY()*-1)) + (primerComplejo.getY() * segundoComplejo.getX());

            var divisorParteReal = (segundoComplejo.getX() * segundoComplejo.getX());
            var divisorParteImaginaria = (-1)*((-1)*(segundoComplejo.getY() * segundoComplejo.getY()));

            var divisorTotal = divisorParteReal + divisorParteImaginaria;

            resultados[0] = dividendoParteReal.ToString() + "/" + divisorTotal.ToString();
            resultados[1] = dividendoParteImaginaria.ToString() + "/" + divisorTotal.ToString();

            return resultados;
        }
        
        public double Dividir(double dividendo, double divisor)
        {
            if (divisor == 0)
            {
                throw new System.ArgumentException();
                return 0;

            }
            else
            {
                return dividendo / divisor;
            }
        } 
    }
}