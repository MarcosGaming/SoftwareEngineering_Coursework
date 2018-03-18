using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
 * Class to test the methods of the Stock class. Private, generate and get methods are not being tested as they are the same as getter and setters.
 * Last modified date: 18/03/2018
 */

namespace UnitTesting
{
    [TestClass]
    public class StockTesting
    {
        [TestMethod]
        public void testUpdateStockBackMethod()
        {
            //arrange
            Stock stock = Stock.getInstance();
            int initialAmount = stock.getFrameStock()["Small"];
            List<Bike> bikeList = new List<Bike>();
            Bike bike1 = new Bike();
            bike1.Frame.FrameColour = "Blue";
            bike1.Frame.FrameSize = "Small";
            bike1.GroupSet.Gears = "Thumb Shifter";
            bike1.GroupSet.Brakes = "Disk Brakes";
            bike1.Wheels.WheelsType = "Mountain";
            bike1.FinishingSet.HandleBars = "Riser Bars";
            bike1.FinishingSet.Saddle = "Forward";
            Bike bike2 = new Bike();
            bike2.Frame.FrameColour = "Blue";
            bike2.Frame.FrameSize = "Small";
            bike2.GroupSet.Gears = "Thumb Shifter";
            bike2.GroupSet.Brakes = "Disk Brakes";
            bike2.Wheels.WheelsType = "Mountain";
            bike2.FinishingSet.HandleBars = "Riser Bars";
            bike2.FinishingSet.Saddle = "Forward";
            bikeList.Add(bike1);
            bikeList.Add(bike2);
            //act
            stock.getFrameStock()[bike1.Frame.FrameSize] -= 1;
            stock.getFrameStock()[bike2.Frame.FrameSize] -= 1;
            stock.updateStockBack(bikeList);
            //assert
            Assert.AreEqual(initialAmount, stock.getFrameStock()["Small"], "Stock not updated back correctly");
        }
    }
}
