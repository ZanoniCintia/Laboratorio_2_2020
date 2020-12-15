using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ValidarBinario()
        {
            Paciente paciente = new Paciente(1, "Joe", "Morello", 7, "masculino", "Avellaneda 123", Cobertura.CoberturaCompleta);
            Binario<Paciente> pacienteBinario = new Binario<Paciente>();
            string archivo ="SerilizarBinario.Paciente";
            string ruta= (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\ArchivosClinica\\");

            Assert.IsTrue(pacienteBinario.Escribir(archivo,ruta, paciente));
        }

        /// <summary>
        /// Verifica que la lista de Pacientes de la clinica esté instanciada
        /// </summary>
        [TestMethod]
        public void Clinica_InstanciaLista()
        {
           
            //Assert
            Assert.IsNotNull(Clinica.Pacientes);

        }




        [TestMethod]
        public void Turnos_repetidos()
        {
            //string fecha = DateTime.Now.FormatearFecha();
            Turno turno = new Turno(1, 3, "mareos", "18_10_2020_22_10_11");
            Turno turno2 = new Turno(1, 3, "nada", "10_12_2020_23_11");
            //Assert
            Assert.IsTrue(turno == turno2);

        }

        [TestMethod]
        public void ExtencionNuevaBinario()
        {
            Turno turno = new Turno(1, 3, "mareos", "18_10_2020_22_10_11");
            string ruta= (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments )+ ".\\SegundoParcialUtn\\ArchivosClinica\\SerilizarBinario.Paciente");
            Assert.IsTrue(turno.SerializarBinario(ruta));
        
        }


    }
}
