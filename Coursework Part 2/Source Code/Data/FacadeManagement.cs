using System;
using System.Collections.Generic;
using Business;
using Data;

/*
 * FACADE AND SINGLETON DESIGN PATTERNS
 * Facade use to manage the stock, bikes and order cost. Singleton use to work with only one instance of this class.
 * Last date modified: 18/03/2018
 */

namespace Data
{
    public class FacadeManagement
    {
        private List<Bike> _bikeList;              //Bikes for the order
        private Stock _stock;                      //Stock with the components amount available
        private static FacadeManagement _instance; //Instance for the singleton
        ComponentsAndPrices componentsCost;        //Class that manages the components cost

        //Singleton private constructor
        private FacadeManagement()
        {
            _stock = Stock.getInstance();
            _bikeList = new List<Bike>();
            componentsCost = new ComponentsAndPrices();
        }
        //Method to get the facade management instance, only allows to get it not to set it
        public static FacadeManagement getInstance()
        {
            if(_instance == null)
            {
                _instance = new FacadeManagement();
            }
            return _instance;
        }
        //Add bike to the list
        public void addBike(Bike bike)
        {
            _bikeList.Add(bike);
        }
        //Update stock back in the case that the order is cancelled
        public void updateStockBack()
        {
            _stock.updateStockBack(_bikeList);
        }
        //Calculate components cost
        private int calculateComponentsCost(Bike bike)
        {
            int cost = 0;
            //Cost of the frame
            cost += componentsCost.getFrames()[bike.Frame.FrameSize];
            //Cost of the group set
            cost += componentsCost.getGears()[bike.GroupSet.Gears];
            cost += componentsCost.getBrakes()[bike.GroupSet.Brakes];
            //Cost of the wheels
            cost += componentsCost.getWheels()[bike.Wheels.WheelsType];
            //Cost of the finishing set
            cost += componentsCost.getHandleBars()[bike.FinishingSet.HandleBars];
            cost += componentsCost.getSaddles()[bike.FinishingSet.Saddle];
            //Cost of the warranty
            if(bike.getWarranty())
            {
                cost += 50;
            }
            return cost;
        }
        //Building and testing cost is the same for all the bikes
        private int calculateBuildingTestingCost()
        {
            return 100;
        }
        //Check if all the bikes have available components(updating at the same time the stock components)
        private Boolean checkStock()
        {
            bool everythingAvailable = true;
            
            foreach(Bike b in _bikeList)
            {
                if (_stock.getFrameStock()[b.Frame.FrameSize] > 0)
                {
                    _stock.getFrameStock()[b.Frame.FrameSize] -= 1;
                }
                else
                {
                    everythingAvailable = false;
                }
                if (_stock.getGearsStock()[b.GroupSet.Gears] > 0)
                {
                    _stock.getGearsStock()[b.GroupSet.Gears] -= 1;
                }
                else
                {
                    everythingAvailable = false;
                }
                if (_stock.getBrakesStock()[b.GroupSet.Brakes] > 0)
                {
                    _stock.getBrakesStock()[b.GroupSet.Brakes] -= 1;
                }
                else
                {
                    everythingAvailable = false;
                }
                if (_stock.getWheelsStock()[b.Wheels.WheelsType] > 0)
                {
                    _stock.getWheelsStock()[b.Wheels.WheelsType] -= 1;
                }
                else
                {
                    everythingAvailable = false;
                }
                if (_stock.getHandlebarsStock()[b.FinishingSet.HandleBars] > 0)
                {
                    _stock.getHandlebarsStock()[b.FinishingSet.HandleBars] -= 1;
                }
                else
                {
                    everythingAvailable = false;
                }
                if (_stock.getSaddleStock()[b.FinishingSet.Saddle] > 0)
                {
                    _stock.getSaddleStock()[b.FinishingSet.Saddle] -= 1;
                }
                else
                {
                    everythingAvailable = false;
                }
            }
            return everythingAvailable;
        }
        //Calculate completion time of completion for all bikes (depends on the availability of the components)
        public int getTotalCompletionTime()
        {
            //Standard completition time for each bike is 32H
            int totalCompletionTime = 32 * _bikeList.Count;
            //If any of the components is missing an additional 24H is added(This is only done once as if there are several missing components all are ordered at the same time)
            if(!checkStock())
            {
                totalCompletionTime += 24;
            }
            return totalCompletionTime;
        }
        //Calculate total order cost
        public int getTotalBikesCost()
        {
            int totalCost = 0;
            foreach(Bike b in _bikeList)
            {
                totalCost += getBikeCost(b);
            }
            return totalCost;
        }
        //Calculate bike cost
        public int getBikeCost(Bike bike)
        {
            int cost = 0;
            cost += calculateBuildingTestingCost();
            cost += calculateComponentsCost(bike);
            return cost;
        }
        //Clear bike list
        public void clearBikeList()
        {
            _bikeList.Clear();
        }
    }
}
