using System;


namespace Laba_5
{
    public class Catering : FoodOrganization
    {
        private readonly uint MAX_COUNT_BUFFET_TABLES = 20;

        private uint _countBuffetTables;
        private bool _isGeneralPurpose;
        private string _menuAsortiment;
        public Catering(string companyName, DateTime createdDate, bool isLicenseOrganization, string emailAdministration, 
            string addresManagerOffice, uint maxCapacityPersom, uint countBuffetTables,bool isGeneralPurpose,string menuAsortiment) 
            : base(companyName, createdDate, isLicenseOrganization, emailAdministration,addresManagerOffice, maxCapacityPersom)
        {
            CountBuffetTables = countBuffetTables;
            IsGeneralPurpose = isGeneralPurpose;
            MenuAsortiment = menuAsortiment;
        }

        /// <summary>
        /// Set: Checking field CountBuffetTables cannot be more then MAX_COUNT_BUFFET_TABLES
        /// </summary>
        private uint CountBuffetTables
        {
            get => _countBuffetTables;
            set
            {
                _countBuffetTables = value < MAX_COUNT_BUFFET_TABLES ? value :
                throw new ArgumentOutOfRangeException($"Field CountBuffetTables cannot be more" +
                $" then MAX_COUNT_BUFFET_TABLES({MAX_COUNT_BUFFET_TABLES})");
            }
        }
        private bool IsGeneralPurpose
        {
            get => _isGeneralPurpose;
            set => _isGeneralPurpose = value;
        }
        /// <summary>
        ///  Set:Checking field MenuAsortiment cannot be empty or null object
        /// </summary>
        private string MenuAsortiment
        {
            get => _menuAsortiment;
            set
            {
                _menuAsortiment = !string.IsNullOrEmpty(value) ? value.Trim() :
                    throw new ArgumentNullException("Field MenuAsortiment cannot be empty or null");
            }
        }
        public override string ToString()
        {
            string purpose = IsGeneralPurpose ? "for everyone" : "private";
            return base.ToString() + $"Count of buffet tables :'{CountBuffetTables}'\n" +
                $"Type purpose :'{purpose}'\nMenu asortiment :'{MenuAsortiment}'\n";
        }
    }
}
