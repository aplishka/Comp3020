using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinalImplementation
{
    public class Review
    {
        private int Rating;
        private string PlotRating;
        private string ActorRating;

        public Review()
        {
            Rating = -1;
            PlotRating = "N/A";
            ActorRating = "N/A";
        }

        public Review(int _rating, string _plotRating, string _actorRating)
        {
            Rating = _rating;
            PlotRating = _plotRating;
            ActorRating = _actorRating;
        }

        public int GetRating() { return Rating; }
        public string GetPlot() { return PlotRating; }
        public string GetActor() { return ActorRating; }

        public override string ToString()
        {
            string result = "";
            if (this.PlotRating.Length > 0 && this.ActorRating.Length > 0)
            {
                result =  this.Rating + "/10 -- Plot: " + this.PlotRating + " -- Actor: " + this.ActorRating;
            }
            else if (this.PlotRating.Length > 0)
            {
                result =  this.Rating + "/10 -- Plot: " + this.PlotRating;
            }
            else if (this.ActorRating.Length > 0)
            {
                result =  this.Rating + "/10 -- Actor: " + this.ActorRating;
            }
            else
            {
                result =  this.Rating + "/10";
            }
            if (result.Length > 50)
            {
                result = result.Substring(0, 50);
                result = result + "...[Click to read more]";
            }
            return result;
        }
    }
}
