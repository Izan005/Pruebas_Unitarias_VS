using gestionBancariaApp;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace gestionBancariaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarMetodoIngreso11()
        {
            //Clase de equivalencia 1
            //preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            //Método a probar
            cuenta.realizarIngreso(ingreso);
            //afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }
        [TestMethod]
        public void validarMetodoIngreso12() {

            //Clase de equivalencia 2
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            //Método a probar
            cuenta.realizarIngreso(ingreso);
            //afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0, "El saldo de la cuenta no es correcto");

        }


        [TestMethod]
        public void validarMetodoReintegro12()
        {
            double saldoInicial = 1000;
            double ingreso = 100;
            double saldoActual = 0;
            double saldoEsperado = 900;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            //Método a probar
            cuenta.realizarReintegro(ingreso);
            //afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarMetodIngreso21()
        {
            double saldoInicial = 1000;
            double ingreso = -100;
            double saldoActual = 0;
            double saldoEsperado = 900;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            //Método a probar
            cuenta.realizarReintegro(ingreso);
            //afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarMetodReintegro21()
        {
            double saldoInicial = 1000;
            double ingreso = -100;
            double saldoActual = 0;
            double saldoEsperado = 900;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            //Método a probar
            cuenta.realizarReintegro(ingreso);
            //afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarMetodReintegro22()
        {
            double saldoInicial = 1000;
            double ingreso = -100;
            double saldoActual = 0;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            //Método a probar
            cuenta.realizarReintegro(ingreso);
            //afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 100, "El saldo de la cuenta no es correcto");
        }
    }
}
