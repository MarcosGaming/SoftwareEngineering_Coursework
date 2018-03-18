using System;
using System.Collections.Generic;
using System.Text;

/*
 * Class to create instances of type Frame.
 * Last modified date: 18/03/2018
 */

namespace Business
{
    public class Frame
    {
        private String _frameSize;      //Bike frame size
        private String _frameColour;    //Bike frame colour

        //Getter and setter for the class properties
        public String FrameSize
        {
            get
            {
                return _frameSize;
            }
            set
            {
                if(value != null)
                {
                    _frameSize = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect frame size value");
                }
            }
        }
        public String FrameColour
        {
            get
            {
                return _frameColour;
            }
            set
            {
                if (value != null)
                {
                    _frameColour = value;

                }
                else
                {
                    throw new ArgumentException("Incorrect colour value");
                }
            }
        }
    }
}
