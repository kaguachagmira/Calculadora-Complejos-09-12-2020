using Matematica.negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Matematica.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void SumaDeDosNumeros()
        {
            var primerNumero = 18;
            var segundoNumero = 3.7;
            var esperado = 21.7;

            var miCalculadora = new Calculadora();

            var resultado = miCalculadora.Sumar(primerNumero,segundoNumero);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DividirPorCero()
        {
            var dividendo = 5;
            var divisor = 0;
            var miCalculadora = new Calculadora();
            //el resultado que viene no me interesa pero debe tener u resultado _
             //_ = miCalculadora.Dividir(dividendo,divisor);

            Assert.ThrowsException<ArgumentException>(()=>miCalculadora.Dividir(dividendo,divisor),"Mensaje");
        }
        [TestMethod]
        public void DividirDosNumeros()
        {
            var dividendo = 6.50;
            var divisor = 2;
            var miCalculadora = new Calculadora();
            var resultadoEsperado = 3.25;  
            //el resultado que viene no me interesa pero debe tener u resultado _
            var resultado = miCalculadora.Dividir(dividendo, divisor);
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        public void SumarComplejos()
        {
            var primerNumeroComplejo = new Complejo(3, 2);
            var segundoNumeroComplejo = new Complejo(1.5, 6);
            var esperadoComplejo = new Complejo(4.5, 8);

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.SumarComplejos(primerNumeroComplejo, segundoNumeroComplejo);

            Assert.AreEqual(esperadoComplejo.X, resultado.X);
            Assert.AreEqual(esperadoComplejo.Y, resultado.Y);
        }
        [TestMethod]
        public void RestarComplejos()
        {
            var primerNumeroComplejo = new Complejo(3, 2);
            var segundoNumeroComplejo = new Complejo(1.5, 6);
            var esperadoComplejo = new Complejo(1.5, -4);

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.RestarComplejos(primerNumeroComplejo, segundoNumeroComplejo);

            Assert.AreEqual(esperadoComplejo.X, resultado.X);
            Assert.AreEqual(esperadoComplejo.Y, resultado.Y);
        }
        [TestMethod]
        public void MultiplicarComplejos()
        {
            var primerNumeroComplejo = new Complejo(3, 2);
            var segundoNumeroComplejo = new Complejo(1.5, 6);
            var esperadoComplejo = new Complejo(-7.5, 21);

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.MultiplicarComplejos(primerNumeroComplejo, segundoNumeroComplejo);

            Assert.AreEqual(esperadoComplejo.X, resultado.X);
            Assert.AreEqual(esperadoComplejo.Y, resultado.Y);

            Assert.IsTrue(esperadoComplejo.Equals(resultado));
        }
        [TestMethod]
        public void DividirComplejos()
        {
            var primerNumeroComplejo = new Complejo(3, 2);
            var segundoNumeroComplejo = new Complejo(1.5, 6);
            var esperadoComplejoRealString = "16,5/38,25";
            var esperadoComplejoImaginariaString = "-15/38,25";

            var miCalculadora = new Calculadora();
            string [] resultado = miCalculadora.DividirComplejos(primerNumeroComplejo, segundoNumeroComplejo);

            Assert.AreEqual(esperadoComplejoRealString, resultado[0]);
            Assert.AreEqual(esperadoComplejoImaginariaString, resultado[1]);
        }
        [TestMethod]
        public void MultiplicacionPorUnEscalar()
        {
            var numeroComplejo = new Complejo(3, 2);
            double numeroEscalar = 5;
            var resultadoEsperado = new Complejo(15, 10);

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.MultiplicacionPorUnEscalar(numeroComplejo, numeroEscalar);

            Assert.AreEqual(resultadoEsperado.X, resultado.X);
            Assert.AreEqual(resultadoEsperado.Y, resultado.Y);
        }
    }
}
