using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;

/*
 * Class to test the methods of the Bike class. Getter and setter methods are not tested.
 * Last modified date: 18/03/2018
 */

namespace UnitTesting
{
    [TestClass]
    public class BikeTesting
    {
        [TestMethod]
        public void testUpdateWarrantyMethod()
        {
            //arrange
            Bike bike = new Bike();
            //act
            bike.updateWarranty();
            //assert
            bool expected = true;
            Assert.AreEqual(expected,bike.getWarranty(), "Warranty do not updated correctly");
        }
    }
}
