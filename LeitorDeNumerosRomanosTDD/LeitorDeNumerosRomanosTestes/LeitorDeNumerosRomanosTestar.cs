using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeitorDeNumerosRomanos;

namespace LeitorDeNumerosRomanosTestes
{
    [TestClass]
    public class LeitorDeNumerosRomanosTestar
    {
        NumerosRomanos leitorDeNumerosRomanos;

        [TestInitialize]
        public void Setup()
        {
            leitorDeNumerosRomanos = new NumerosRomanos();
        }

        [TestMethod]
        public void TestarInstancia()
        {
            Assert.IsNotNull(leitorDeNumerosRomanos);
        }

        [TestMethod]
        public void TestarLerNumeroUm()
        {
            int numero = leitorDeNumerosRomanos.Ler("i");
            Assert.AreEqual(1, numero);
        }

        [TestMethod]
        public void TestarLerNumeroDois()
        {
            int numero = leitorDeNumerosRomanos.Ler("ii");
            Assert.AreEqual(2, numero);
        }

        [TestMethod]
        public void TestarLerNumeroTres()
        {
            int numero = leitorDeNumerosRomanos.Ler("iIi");
            Assert.AreEqual(3, numero);
        }

        [TestMethod]
        public void TestarLerNumeroQuatro()
        {
            int numero = leitorDeNumerosRomanos.Ler("IV");
            Assert.AreEqual(4, numero);
        }

        [TestMethod]
        public void TestarLerNumeroCinco()
        {
            int numero = leitorDeNumerosRomanos.Ler("V");
            Assert.AreEqual(5, numero);
        }

        [TestMethod]
        public void TestarLerNumeroSeis()
        {
            int numero = leitorDeNumerosRomanos.Ler("Vi");
            Assert.AreEqual(6, numero);
        }

        [TestMethod]
        public void TestarLerNumeroSete()
        {
            int numero = leitorDeNumerosRomanos.Ler("Vii");
            Assert.AreEqual(7, numero);
        }

        [TestMethod]
        public void TestarLerNumeroOito()
        {
            int numero = leitorDeNumerosRomanos.Ler("Viii");
            Assert.AreEqual(8, numero);
        }

        [TestMethod]
        public void TestarLerNumeroNove()
        {
            int numero = leitorDeNumerosRomanos.Ler("ix");
            Assert.AreEqual(9, numero);
        }

        [TestMethod]
        public void TestarLerNumeroDez()
        {
            int numero = leitorDeNumerosRomanos.Ler("x");
            Assert.AreEqual(10, numero);
        }

        [TestMethod]
        public void TestarLerNumeroOnze()
        {
            int numero = leitorDeNumerosRomanos.Ler("xi");
            Assert.AreEqual(11, numero);
        }

        [TestMethod]
        public void TestarLerNumeroCatorze()
        {
            int numero = leitorDeNumerosRomanos.Ler("xiv");
            Assert.AreEqual(14, numero);
        }

        [TestMethod]
        public void TestarLerNumeroVinte()
        {
            int numero = leitorDeNumerosRomanos.Ler("xx");
            Assert.AreEqual(20, numero);
        }

        [TestMethod]
        public void TestarLerNumeroTrinta()
        {
            int numero = leitorDeNumerosRomanos.Ler("xxx");
            Assert.AreEqual(30, numero);
        }

        [TestMethod]
        public void TestarLerNumeroQuarenta()
        {
            int numero = leitorDeNumerosRomanos.Ler("xL");
            Assert.AreEqual(40, numero);
        }

        [TestMethod]
        public void TestarLerNumeroCinquenta()
        {
            int numero = leitorDeNumerosRomanos.Ler("L");
            Assert.AreEqual(50, numero);
        }

        [TestMethod]
        public void TestarLerNumeroSessenta()
        {
            int numero = leitorDeNumerosRomanos.Ler("LX");
            Assert.AreEqual(60, numero);
        }

        [TestMethod]
        public void TestarLerNumeroSetenta()
        {
            int numero = leitorDeNumerosRomanos.Ler("LXx");
            Assert.AreEqual(70, numero);
        }

        [TestMethod]
        public void TestarLerNumeroOitenta()
        {
            int numero = leitorDeNumerosRomanos.Ler("LXxx");
            Assert.AreEqual(80, numero);
        }

        [TestMethod]
        public void TestarLerNumeroNoventa()
        {
            int numero = leitorDeNumerosRomanos.Ler("XC");
            Assert.AreEqual(90, numero);
        }
        [TestMethod]
        public void TestarLerNumeroCem()
        {
            int numero = leitorDeNumerosRomanos.Ler("C");
            Assert.AreEqual(100, numero);
        }

        [TestMethod]
        public void TestarLerNumeroDuzentos()
        {
            int numero = leitorDeNumerosRomanos.Ler("CC");
            Assert.AreEqual(200, numero);
        }

        [TestMethod]
        public void TestarLerNumeroTrezentos()
        {
            int numero = leitorDeNumerosRomanos.Ler("CCC");
            Assert.AreEqual(300, numero);
        }
    }
}
