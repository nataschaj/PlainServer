﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;


namespace ModelLib
{
    public class Car
    {
        //properties 'model, color, registration number'
        public string Model { get; set; }
        public string Color { get; set; }
        public string RegNo { get; set; }

        public Car()
        {

        }

        public override string ToString()
        {
            return "Model: " + Model + "Color: " + Color + "Regno: " + RegNo;
        }
    }
}
