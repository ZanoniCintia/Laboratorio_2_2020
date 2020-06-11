using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
using CentralTelefonica;
using System.Collections.Generic;

namespace CentralitaPrueba
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidaListaDeLLamadas()
        {
            //arrange
            Centralita c;
            List<Llamada> llamadas;

            // act
            c = new Centralita("Mi central");
            llamadas = c.Llamadas;

            //assert
            Assert.IsNotNull(llamadas);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void ValidaExcepcionLocalExistente()
        {
            //arrange
            Centralita centralita = new Centralita("Mi central");
            Local local = new Local("Avellaneda", 23, "Varela", 1.20f);
            Local localRepetida = new Local("Avellaneda", 23, "Varela", 1.20f);
            //act
            centralita += local;
            centralita += localRepetida;
            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void ValidaExcepcionProvincialExistente()
        {
            //arrange
            Centralita centralita = new Centralita("Mi central");
            Provincial provincial = new Provincial(Provincial.Franja.Franja_1, "Bernal", 12, "Cordoba");
            Provincial provincialRepetida = new Provincial(Provincial.Franja.Franja_1, "Bernal", 12, "Cordoba");
            //act
            centralita += provincial;
            centralita += provincialRepetida;
            //assert

        }

        [TestMethod]
        public void ValidaIgualdadDeTipo()
        {   
            //arrange
            Local local = new Local("Avellaneda", 23, "Varela", 1.20f);
            Local localRepetida = new Local("Avellaneda", 23, "Varela", 1.20f);

            Provincial provincial = new Provincial(Provincial.Franja.Franja_1, "Bernal", 12, "Cordoba");
            Provincial provincialRepetida = new Provincial(Provincial.Franja.Franja_1, "Bernal", 12, "Cordoba");

            //assert
            Assert.AreEqual(local, localRepetida);
            Assert.AreEqual(provincial, provincialRepetida);
            Assert.AreNotEqual(local, provincial);

        }
    }
}
