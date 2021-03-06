﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FNPlugin {
    class FNPlanetaryResourcePixel {
        protected double quantity;
        protected string name;
        protected int body;
        protected string resourcename;

        public FNPlanetaryResourcePixel(string name, double quantity, int body) {
            this.name = name;
            this.quantity = quantity;
            this.body = body;
        }

        public void setResourceName(string resourcename) {
            this.resourcename = resourcename;
        }

        public string getResourceName() {
            return resourcename;
        }

        public double getAmount() {
            return quantity;
        }

        public int getBody() {
            return body;
        }

        public string getName() {
            return name;
        }
    }
}
