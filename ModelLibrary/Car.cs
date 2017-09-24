using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Car
    {
        //properties 'model, color, registration number'
        public string Model { get; set; }
        public string Color { get; set; }
        public string RegNo { get; set; }

        public Car(string model, string color, string regno)
        {
            this.Color = color;
            this.Model = model;
            this.RegNo = regno;
        }
    }
}
