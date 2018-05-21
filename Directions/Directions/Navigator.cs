using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directions
{
    class Navigator
    {
        //NOTE:  We do not need to include the avoid/include on route items, if we want to keep this simple.
        //I just added them since we had them in our assignment from week 2.
        string startPoint;
        string endPoint;
        string avoidOnRoute;
        string includeOnRoute;
        //is the API key a field in the class?

        //Methods

        SetCurrentLocation()
            //Read text from From field

        SetDestination()
            //Read text from To field
        
        ModifyRouteToInclude()
            //Read text from Include field
        
        ModifyRouteToAvoid()
            //Read text from Avoid field
        
        GetDirections()
            //I think this involves the API to determine the directions?
        
        GetTimeToDestination()
            //We don't have to include this
        
        TotalDistance()
            //We don't have to include this, either.
    }
}
