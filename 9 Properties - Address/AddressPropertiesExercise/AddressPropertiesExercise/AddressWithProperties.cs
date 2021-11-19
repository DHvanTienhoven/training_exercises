using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressPropertiesExercise
{
    public class AddressWithProperties
    {
        private string postal_code;

        public string PostalCode
        {
            get => postal_code;
            set
            {
                if (AddressUtilities.IsPostalCode(value))

                {
                    postal_code = value;
                }
            }
        }
    }
}
