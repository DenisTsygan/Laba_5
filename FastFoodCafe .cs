using System;

namespace Laba_5
{
    public class FastFoodCafe : FoodOrganization
    {
        private readonly uint MAX_COUNT_STREET_TABLES = 50;


        private uint _countStreetTables;
        private string _typeKitchen;
        private uint _trafficPeopleInDay;
        public FastFoodCafe(string companyName, DateTime createdDate, bool isLicenseOrganization, string emailAdministration,
            string addresManagerOffice, uint maxCapacityPersom, uint countStreetTables,string typeKitchen , uint trafficPeopleInDay) 
            : base(companyName, createdDate, isLicenseOrganization, emailAdministration, addresManagerOffice, maxCapacityPersom)
        {
            CountStreetTables = countStreetTables;
            TypeKitchen = typeKitchen;
            TrafficPeopleInDay = trafficPeopleInDay;
        }
        /// <summary>
        /// Set: Checking field CountStreetTables cannot be more then MAX_COUNT_STREET_TABLES
        /// </summary>
        private uint CountStreetTables
        {
            get => _countStreetTables;
            set
            {
                _countStreetTables = value < MAX_COUNT_STREET_TABLES ? value :
                throw new ArgumentOutOfRangeException($"Field CountStreetTables cannot be more then MAX_COUNT_STREET_TABLES({MAX_COUNT_STREET_TABLES})");
            }
        }
        /// <summary>
        ///  Set:Checking field TypeKitchen cannot be empty or null object
        /// </summary>
        private string TypeKitchen
        {
            get => _typeKitchen;
            set
            {
                _typeKitchen = !string.IsNullOrEmpty(value) ? value.Trim() :
                    throw new ArgumentNullException("Field TypeKitchen cannot be empty or null");
            }
        }
        private uint TrafficPeopleInDay
        {
            get => _trafficPeopleInDay;
            set => _trafficPeopleInDay = value;
            
        }
        public override string ToString()
        {
            return base.ToString()+ $"Count  tables on the street :'{CountStreetTables}'\nType of kitchen:'{TypeKitchen}'\n" +
                $"Traffic people in  day:'{TrafficPeopleInDay}'\n";
        }
    }
}
