using System;
using System.Collections.Generic;
using System.Text;

/*
 * Class to create instances of type Bike.
 * Last modified date: 18/03/2018
 */

namespace Business
{
    public class Bike
    {
        private Frame _frame;               //Bike frame type
        private GroupSet _groupSet;         //Bike gears and brakes types
        private Wheels _wheels;             //Bike wheels type
        private FinishingSet _finishingSet; //Bike handlebars and saddle type
        private Boolean _warranty;          //Bike warranty

        public Bike()
        {
            _frame = new Frame();
            _groupSet = new GroupSet();
            _wheels = new Wheels();
            _finishingSet = new FinishingSet();
            _warranty = false;
        }
        //Getter and setter for the bike properties
        public Frame Frame
        {
            get
            {
                return _frame;
            }
            set
            {
                if(value != null)
                {
                    _frame = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect frame value");
                }
            }
        }
        public GroupSet GroupSet
        {
            get
            {
                return _groupSet;
            }
            set
            {
                if(value != null)
                {
                    _groupSet = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect group set value");
                }
            }
        }
        public Wheels Wheels
        {
            get
            {
                return _wheels;
            }
            set
            {
                if(value != null)
                {
                    _wheels = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect wheels value");
                }
            }
        }
        public FinishingSet FinishingSet
        {
            get
            {
                return _finishingSet;
            }
            set
            {
                if(value != null)
                {
                    _finishingSet = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect finishing set value");
                }
            }
        }
        //Update warranty
        public void updateWarranty()
        {
            _warranty = true;
        }
        //Get warranty
        public Boolean getWarranty()
        {
            return _warranty;
        }
    }
}
