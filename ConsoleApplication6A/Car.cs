using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6A
{
    class Car
    {
        private string _make;
        private bool _manualTransmission;
        private ushort _cc;

        public string Model { get; private set; }

        public Car(string make, string model, bool manual, ushort cc)
        {
            this._make = make;
            this.Model = model;
            this._manualTransmission = manual;
            this._cc = cc;
        }

        public string Make
        {
            get { return this._make; }
            set { this._make = value; }
        }
        public ushort CC
        {
            get { return this._cc; }
            set
            {
                if (value <= 6000)
                    this._cc = value;
                else
                    this._cc = 0;
            }
        }
    }
}
