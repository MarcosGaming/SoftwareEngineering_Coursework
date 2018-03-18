using System;
using System.Collections.Generic;
using System.Text;

/*
 * Class to create instances of type GroupSet.
 * Last modified date: 18/03/2018
 */

namespace Business
{
    public class GroupSet
    {
        private String _gears;      //Bike gears
        private String _brakes;     //Bike brakes

        //Getter and setter methods for the class properties
        public String Gears
        {
            get
            {
                return _gears;
            }
            set
            {
                if(value != null)
                {
                    _gears = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect gears value");
                }
            }
        }
        public String Brakes
        {
            get
            {
                return _brakes;
            }
            set
            {
                if(value != null)
                {
                    _brakes = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect brakes value");
                }
            }
        }
    }
}
