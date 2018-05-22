using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directions
{

    public abstract class tempNav
    {
        public string startPoint { get; set; }
        public string endPoint { get; set; }
        public string directionOne { get; set; }
        public string directionTwo { get; set; }
        public string directionThree { get; set; }
        public string directionFour { get; set; }
        public string arrivalMsg { get; set; }



    }

    class Navigator
    {
        public string startPoint;
        public string endPoint;
        //is the API key a field in the class?

        //Methods

        public void SetCurrentLocation(string startPoint)
        {
            //Read text from From field
        }


        public void SetDestination(string endPoint)
        {
            //Read text from To field
        }


        public string GetDirections(string startPoint, string endPoint)
        {
            //I think this involves the API to determine the directions?
        }
             
    }
}
