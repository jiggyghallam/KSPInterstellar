﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FNPlugin {
    class GameConstants {
        public const double baseReprocessingRate = 0.4;
        public const double basePowerConsumption = 5;
        public const double electrolysisEnergyPerTon = 18159;
        public const double bakingEnergyPerTon = 4920;
        public const double aluminiumElectrolysisEnergyPerTon = 35485.714;
        public const double electrolysisMassRatio = 7.936429;
        public const double aluminiumElectrolysisMassRatio = 1.5;
        public const double baseELCPowerConsumption = 40;
        public const double baseMiningPowerConsumption = 10;
        public const double baseMiningRatePerTon = 0.009259259259;
        public const double baseScienceRate = 0.1f;
        public const double baseAMFPowerConsumption = 5000;
        public const double baseCentriPowerConsumption = 43.5;
        public const double deuterium_abudance = 0.00015625;
        public const double deuterium_timescale = 0.0016667;
        public const double stefan_const = 5.670373e-8;
        public const double warpspeed = 29979245.8;
        public const float MAX_ANTIMATTER_TANK_STORED_CHARGE = 1000;
        public const double thorium_power_output_ratio = 1.38;
        public const double thorium_resource_burnrate_ratio = 0.45;
        public const double thorium_actinides_ratio_factor = 1;
        public const double thorium_temperature_ratio_factor = 1.17857;
        public const double plutonium_238_decay_constant = 3.6132369229223432425344238140179e-10;
        public const double microwave_angle = 3.64773814E-10f;
        public const double microwave_dish_efficiency = 0.85f;
        public const double microwave_alpha = 0.00399201596806387225548902195609f;
        public const string deuterium_tritium_fuel_mode = "Deuterium/Tritium";
        public const string deuterium_helium3_fuel_mode = "Deuterium/Helium-3";
        public const string helium3_fuel_mode = "Helium-3";
        public const double rad_const_h = 1000;
        public const double alpha = 0.001998001998001998001998001998;
        public const double atmospheric_non_precooled_limit = 740;
        public const double initial_alcubierre_megajoules_required = 1000;
        public const double anthraquinoneEnergyPerTon = 1834.321;
        public const double baseAnthraquiononePowerConsumption = 1;
        public const double basePechineyUgineKuhlmannPowerConsumption = 5;
        public const double pechineyUgineKuhlmannMassRatio = 0.4847459883;
        public const double pechineyUgineKuhlmannEnergyPerTon = 1021;
    }
}
