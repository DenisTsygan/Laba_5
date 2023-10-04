using System;


namespace Laba_5
{
    public class Restaurant : FoodOrganization
    {
        private readonly uint MAX_COUNT_HALLS = 10;
        private readonly uint MAX_STARS_RAITING = 5;


        private string _sponsorName;
        private uint _countPrivateHalls;
        private uint _starsRaiting;

        public Restaurant( string companyName, DateTime createdDate, bool isLicenseOrganization, string emailAdministration, 
            string addresManagerOffice, uint maxCapacityPersom, uint countPrivateHalls , string sponsorName, uint starsRaiting) 
            :base(companyName, createdDate, isLicenseOrganization, emailAdministration, addresManagerOffice, maxCapacityPersom)
        {
            CountPrivateHalls = countPrivateHalls;
            SponsorName = sponsorName;
            StarsRaiting = starsRaiting;
        }
        /// <summary>
        /// Set: Checking Field CountPrivateHalls cannot be more then MAX_COUNT_HALLS
        /// </summary>
        private uint CountPrivateHalls
        {
            get => _countPrivateHalls;
            set => _countPrivateHalls = value < MAX_COUNT_HALLS ? value :
                throw new ArgumentOutOfRangeException($"Field CountPrivateHalls cannot be more then MAX_COUNT_HALLS({MAX_COUNT_HALLS})");

        }
        /// <summary>
        /// Set:Checking field SponsorName cannot be empty or null object
        /// </summary>
        private string SponsorName
        {
            get => _sponsorName;
            set
            {
                _sponsorName = !string.IsNullOrEmpty(value) ? value.Trim() :
                    throw new ArgumentNullException("Field SponsorName cannot be empty or null");
            }
        }
        /// <summary>
        /// Set: Checking Field StarsRaiting cannot be more then MAX_STARS_RAITING
        /// </summary>
        private uint StarsRaiting
        {
            get => _starsRaiting;
            set => _starsRaiting = value <= MAX_STARS_RAITING ? value :
                throw new ArgumentOutOfRangeException($"Field StarsRaiting cannot be more " +
                    $"then MAX_STARS_RAITING({MAX_STARS_RAITING})");

        }
        public override string ToString()
        {
            return base.ToString() + $"Count private of halls:'{CountPrivateHalls}'\nSponsored by:'{SponsorName}'\n" +
                $"Stars raiting:'{StarsRaiting}/{MAX_STARS_RAITING}'\n";
        }
    }
}
