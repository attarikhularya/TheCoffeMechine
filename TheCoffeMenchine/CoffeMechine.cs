using System;
using System.Collections.Generic;
using System.Text;
using TheCoffeMechine;

namespace TheCoffeMenchine
{
    class CoffeMechine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;
        private WaterMilk waterMilk;
        public CoffeMechine(CoffePowder powder, WaterGalon galon, WaterMilk milk)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
            this.waterMilk = milk;
        }
        public String makeEsspresso()
        {
            if(!this.waterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, thi coffe is empty";
            }
            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            return "Yey! your Esspresso is ready";
        }
        public String checkAvailability()
        {
            return $"the water :{this.waterGalon.getVolume()} and the coffe powder : {this.coffePowder.getNetto()}";
        }
        public String makeCappucino()
        {
            if (!this.waterMilk.isAvailable())
            {
                return "Sorry, the milk is empty";
            }
            
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, thi coffe is empty";
            }
            this.waterMilk.makeOneCup();
            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            return "Yey! your Cappucino is ready";
        }
        public String checkAvailabili()
        {
            return $"the water :{this.waterGalon.getVolume()}, the coffe powder : {this.coffePowder.getNetto()} and the milk : {this.waterMilk.getVolume()}";
        }

    }
    }
