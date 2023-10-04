using System;

namespace Laba_5
{
    public class FoodOrganization
    {
        private readonly int MAX_CAPACITY_PERSON = 1000;

        private uint _maxCapacityPersom;
        private Establishment _establishment;

        public FoodOrganization(string companyName, DateTime createdDate, bool isLicenseOrganization, 
            string emailAdministration , string addresManagerOffice, uint maxCapacityPersom)
        {
            Establishment = new Establishment(companyName, createdDate, isLicenseOrganization, emailAdministration,addresManagerOffice);
            MaxCapacityPersom = maxCapacityPersom;
        }

        /// <summary>
        ///  Set:Checking field _maxCapacityPersom cannot be more then MAX_CAPACITY_PERSON
        /// </summary>
        private uint MaxCapacityPersom
        {
            get => _maxCapacityPersom;
            set => _maxCapacityPersom = value < MAX_CAPACITY_PERSON ? value : 
                throw new ArgumentOutOfRangeException($"Field MaxCapacityPersom cannot be " +
                    $"more then MAX_CAPACITY_PERSON({MAX_CAPACITY_PERSON})");
           
        }
        private Establishment Establishment
        {
            get => _establishment;
            set => _establishment = value;

        }
        public override string ToString()
        {
            return  Establishment+ $"Maximum capacity of person:'{MaxCapacityPersom}'\n";
        }

    }
}
