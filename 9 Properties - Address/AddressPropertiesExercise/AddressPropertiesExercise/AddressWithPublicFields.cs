using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressPropertiesExercise
{
    public class AddressWithPublicFields
    {
        private string postal_code;

        public string postalCode
        {
            get => postal_code;
            set => postal_code = value;
            
        }
    }
}
