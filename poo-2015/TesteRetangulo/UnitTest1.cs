using System;
using poo_paint;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteRetangulo
{
    [TestClass]
    public class TesteRetangulo
    {
        [TestMethod]
        public void TestaRet()
        {
            Figuras testarRetangulo = new Figuras(1,2,3,4);

            
        }

        [TestMethod]
        public void TestaContador()
        {
            Figuras.ZeraContador();
            Assert.AreEqual(0, Figuras.LeContador());
            Figuras r1 = new Figuras(10, 20, 50, 60);
            Figuras r2 = new Figuras(5, 5, 10, 200);
            Assert.AreEqual(2, Figuras.LeContador());
            Figuras r3 = new Figuras(5, 5, 3, 67);
            Assert.AreEqual(3, Figuras.LeContador());
        }
    }
}
