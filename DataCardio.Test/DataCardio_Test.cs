using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class DataCardio_Test
    {
        //script 1
        [DataTestMethod]
        [DataRow(15, 143.5, 184.5)]  //età, battitti minimi, battiti massimi 
        [DataRow(20, 140, 180)]
        [DataRow(25, 136.5, 175.5)]
        [DataRow(30, 133, 171)]

        public void TestBattitiMinimiMassimi(int età, double battiti_min_aspettati, double battiti_max_aspettati)
        {
            double battiti_min = CardioLibrary.DataCardio.Btminimi(età);
            Assert.AreEqual(battiti_min, battiti_min_aspettati);

            double battiti_max = CardioLibrary.DataCardio.Btmassimi(età);
            Assert.AreEqual(battiti_max, battiti_max_aspettati);
        }

        //script 2
        [DataTestMethod]
        [DataRow(40, "Bradicardia")]  //battiti, frequenza cardiaca a riposo
        [DataRow(50, "Bradicardia")]
        [DataRow(60, "Normale")]
        [DataRow(100, "Normale")]
        [DataRow(120, "Tachicardia")]
        [DataRow(140, "Tachicardia")]
        [DataRow(-10, "Errore")]
        [DataRow(0, "Errore")]

        public void TestValoriFrequenzaCardiacaRiposo(double battiti, string frequenza_cardiaca_riposo_aspettati)
        {
            string frequenza_cardiaca_riposo = CardioLibrary.DataCardio.FrequenzaCardiacaRiposo(battiti);

            Assert.AreEqual(frequenza_cardiaca_riposo, frequenza_cardiaca_riposo_aspettati);
        }

    }
}
