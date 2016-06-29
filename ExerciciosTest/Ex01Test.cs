using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercicios;

namespace ExerciciosTest
{
    [TestClass]
    public class Ex01Test
    {
        [TestMethod]
        public void Primeiro_Numero_For_Menor()
        {
            Ex01 ex = new Ex01();

            int resultado = ex.Calcular (1, 2, 3);

            Assert.AreEqual(1, resultado);

        }

        [TestMethod]
        public void Segundo_Numero_For_Menor()
        {
            Ex01 ex = new Ex01();

            int resultado = ex.Calcular(2, 1, 3);

            Assert.AreEqual(1, resultado);

        }

        [TestMethod]
        public void Terceiro_Numero_For_Menor()
        {
            Ex01 ex = new Ex01();

            int resultado = ex.Calcular(2, 3, 1);

            Assert.AreEqual(1, resultado);

        }
    }
}
