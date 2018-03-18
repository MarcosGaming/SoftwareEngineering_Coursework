using System;
using System.Collections.Generic;
using System.Text;

/*
 * Class to create instances of type Wheels.
 * Last modified date: 18/03/2018
 */

namespace Business
{
    public class Wheels
    {
        private String _wheels; //Bike wheels type

        //Getter and setter for the class properties
        public String WheelsType
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
    }
}
