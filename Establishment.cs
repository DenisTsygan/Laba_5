using System;

namespace Laba_5
{
    public class Establishment
    {
        private string _companyName;
        private readonly DateTime _createdDate;
        private bool _isLicenseOrganization;
        private string _emailManagerOffice;
        private string _addresManagerOffice;


        public Establishment(string companyName, DateTime createdDate, bool isLicenseOrganization, 
            string emailAdministration,string addresManagerOffice)
        {
            CompanyName = companyName;
            CreatedDate = createdDate;
            IsLicenseOrganization = isLicenseOrganization;
            EmailManagerOffice = emailAdministration;
            AddresManagerOffice = addresManagerOffice;
        }

        /// <summary>
        ///  Set:Checking field _companyName cannot be empty or null object
        /// </summary>
        private string CompanyName
        {
            get => _companyName;
            set
            {
                _companyName = !string.IsNullOrEmpty(value) ? value.Trim() :
                    throw new ArgumentNullException("Field CompanyName cannot be empty or null");
            }
        }
        /// <summary>
        /// Set: Check field CreatedDate cannot be more then Date Now
        /// </summary>
        private DateTime CreatedDate
        {
            get => _createdDate;
            init
            {
                DateTime dateTimeNow = DateTime.Now;
                int result = value.CompareTo(dateTimeNow);
                if (result > 0)
                {
                    throw new ArgumentException($"Date '{value}' cannot be more then Date Now'{dateTimeNow}'");
                }
                else
                {
                    _createdDate = value;
                }

            }

        }
        private bool IsLicenseOrganization
        {
            get => _isLicenseOrganization;
            set => _isLicenseOrganization = value;
        }
        /// <summary>
        /// Set: Checking string for email format
        /// </summary>
        private string EmailManagerOffice
        {
            get => _emailManagerOffice;
            set
            {
                string valueTrim = value.Trim();
                _emailManagerOffice = EmailController.IsEmail(valueTrim) ? valueTrim : 
                    throw new ArgumentException($"String ({value}) is not email ");
            }
        }

        /// <summary>
        ///  Set:Checking field _companyName cannot be empty or null object
        /// </summary>
        private string AddresManagerOffice
        {
            get => _addresManagerOffice;
            set
            {
                _addresManagerOffice = !string.IsNullOrEmpty(value) ? value.Trim() :
                    throw new ArgumentNullException("Field CompanyName cannot be empty or null");
            }
        }
        public override string ToString()
        {
            string licenseCheck = (IsLicenseOrganization ? "" : "dont ") + "have license ";
            return $"Company {licenseCheck} name:'{CompanyName}'\nWas created:'{CreatedDate}'\n" +
                $"Main office address'{AddresManagerOffice}' email:'{EmailManagerOffice}'\n";
        }
    }
}
