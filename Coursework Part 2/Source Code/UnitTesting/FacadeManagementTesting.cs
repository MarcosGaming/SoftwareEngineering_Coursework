using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
 * Class to test the methods of the FacadeManagement class. Private methods are not being tested.
 * Last modified date: 18/03/2018
 */

namespace UnitTesting
{
    [TestClass]
    public class FacadeManagementTesting
    {
        [TestMethod]
        public void testAddBikeMethod()
        {
            //arrange
            FacadeManagement facade = FacadeManagement.getInstance();
            Bike bike1 = new Bike();
            bike1.Frame.FrameColour = "Blue";
            bike1.Frame.FrameSize = "Small";
            bike1.GroupSet.Gears = "Thumb Shifter";
            bike1.GroupSet.Brakes = "Disk Brakes";
            bike1.Wheels.WheelsType = "Mountain";
            bike1.FinishingSet.HandleBars = "Riser Bars";
            bike1.FinishingSet.Saddle = "Forward";
            //act
            facade.addBike(bike1);
            //assert (if the list is empty then the bike cost would be 0)
            Assert.AreNotEqual(0, facade.getTotalBikesCost(), "Bike not added correctly");
        }
        [TestMethod]
        public void testUpdateStockBackMethod()
        {
            //arrange
            FacadeManagement facade = FacadeManagement.getInstance();
            Stock stock = Stock.getInstance();
            int initialAmount = stock.getFrameStock()["Small"];
            Bike bike1 = new Bike();
            bike1.Frame.FrameColour = "Blue";
            bike1.Frame.FrameSize = "Small";
            bike1.GroupSet.Gears = "Thumb Shifter";
            bike1.GroupSet.Brakes = "Disk Brakes";
            bike1.Wheels.WheelsType = "Mountain";
            bike1.FinishingSet.HandleBars = "Riser Bars";
            bike1.FinishingSet.Saddle = "Forward";
            //act
            facade.addBike(bike1);
            facade.getTotalCompletionTime();
            facade.updateStockBack();
            //assert
            Assert.AreEqual(initialAmount, stock.getFrameStock()["Small"], "Facade updated back method not implemented correctly");
        }
        [TestMethod]
        public void testGetTotalCompletionTime()
        {
            //arrange
            FacadeManagement facade = FacadeManagement.getInstance();
            Bike bike1 = new Bike();
            bike1.Frame.FrameColour = "Blue";
            bike1.Frame.FrameSize = "Small";
            bike1.GroupSet.Gears = "Thumb Shifter";
            bike1.GroupSet.Brakes = "Disk Brakes";
            bike1.Wheels.WheelsType = "Mountain";
            bike1.FinishingSet.HandleBars = "Riser Bars";
            bike1.FinishingSet.Saddle = "Forward";
            //act
            facade.addBike(bike1);
            //assert (With just one bike in the list all the stock is available and the time should be 32H and there are three at the moment)
            Assert.AreEqual(32*3, facade.getTotalCompletionTime(), "Facade get total completion time method not implemented correctly");
        }
        [TestMethod]
        public void testGetTotalBikesCost()
        {
            //arrange
            FacadeManagement facade = FacadeManagement.getInstance();
            //act (Values are taken from the stock class, the three bikes added have the same components)
            int totalCost = 100*3 + 30*3 + 3 *40 + 100*3 + 150*3 + 20 *3 + 50 *3;
            //assert (There are already three bikes added so the test is performed with those three bikes)
            Assert.AreEqual(totalCost, facade.getTotalBikesCost(), "Facade get total bikes cost method not implemented correctly");
        }

    }
}
