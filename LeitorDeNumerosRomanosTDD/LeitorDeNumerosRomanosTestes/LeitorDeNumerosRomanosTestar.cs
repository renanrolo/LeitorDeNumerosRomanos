using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeitorDeNumerosRomanos;

namespace LeitorDeNumerosRomanosTestes
{
    [TestClass]
    public class LeitorDeNumerosRomanosTestar
    {
        [TestMethod]
        public void TestarInstancia()
        {
            NumerosRomanos leitorDeNumerosRomanos = new NumerosRomanos();

            Assert.IsNotNull(leitorDeNumerosRomanos);
        }
    }
}
