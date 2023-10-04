using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5
{
    public class CateringEstablishments
    {
        private FoodOrganization[] _establishments;
        /// <summary>
        /// if the establishments is null , initialize array _establishments with zero length
        /// </summary>
        /// <param name="establishments">elements successor to the FoodOrganization class</param>
        public CateringEstablishments(params FoodOrganization[] establishments)
        {
            if(establishments is not null)
            {
                _establishments = establishments;
            }
            else
            {
                _establishments = new FoodOrganization[0];
            }
        }
        /// <summary>
        /// adding the establishment to the end of the array _establishment
        /// </summary>
        /// <param name="establishment">successor to the FoodOrganization class</param>
        public void addEstablishment(FoodOrganization establishment)
        {
            Array.Resize(ref _establishments, _establishments.Length+1);
            _establishments[_establishments.Length - 1] = establishment;
        }
        /// <summary>
        /// removing an element from  array _establishment by index
        /// </summary>
        /// <param name="indexRemove">index of the element to be removed</param>
        public void deleteEstablishmentByIndex(uint indexRemove)
        {
            if(indexRemove < _establishments.Length)
            {
                FoodOrganization[] newEstablishments = new FoodOrganization[_establishments.Length - 1];
                for (int i = 0,j=0; i < _establishments.Length; i++)
                {
                    if (i != indexRemove)
                    {
                        newEstablishments[j] = _establishments[i];
                        j++;
                    }
                }
                _establishments= newEstablishments;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index is out of array ");
            }
           
        }
        /// <summary>
        /// Update establishment by index 
        /// </summary>
        /// <param name="establishment"> updated establishment</param>
        /// <param name="indexUpdate">index updated establishment</param>
        public void updateEstablishmentByIndex(FoodOrganization establishment, uint indexUpdate)
        {
            if (indexUpdate < _establishments.Length)
            {
                _establishments[indexUpdate] = establishment;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index is out of array ");
            }

        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (FoodOrganization establishment in _establishments)
            {
                str.Append(establishment+ "\n");
            }
            return str.ToString();
        }
    }
}
