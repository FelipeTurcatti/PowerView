using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.Common
{
    [DataContract]
    public class DataPoint
    {
        [DataMember(Name = "x")]
        public Nullable<double> X = null;

        [DataMember(Name = "y")]
        public Nullable<double> Y = null;


        [DataMember(Name = "label")]
        public string Label = null;

        
        public DataPoint(double x, double y,string label)
        {
            this.X = x;
            this.Y = y;
            this.Label = label;
        }
        public DataPoint(double y, string label)
        {
            this.Y = y;
            this.Label = label;
        }
        public DataPoint()
        {
        }
    }
}
