﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Directions
{
    class Navigator
    {
        public string startPoint;
        public string endPoint;
        public string listedDirections;
        //is the API key a field in the class?

        //Methods
        public Navigator(string start, string end, string directions)
        {
            startPoint = start;
            endPoint = end;
            listedDirections = directions;

        }

        public void SetCurrentLocation(string startPoint)
        {
            //Read text from From field
        }


        public void SetDestination(string endPoint)
        {
            //Read text from To field
        }

        public string displayDirections()
        {
            return listedDirections;
        }
        public string GetDirections(string startPoint, string endPoint)
        {
            //I think this involves the API to determine the directions?
            var url = "https://maps.googleapis.com/maps/api/directions/json?origin=" + startPoint + "&destination=" + endPoint + "&key=AIzaSyC-eFtOEhwXhlFvtwWLepZXLyKP440k6Dk";
            var client = new WebClient();
            listedDirections = client.DownloadString(url);
            return listedDirections;
        }
             
    }
}
