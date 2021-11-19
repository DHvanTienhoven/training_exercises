using System.Text.RegularExpressions;

namespace AddressPropertiesExercise
{
    public class AddressUtilities
    {
        public static bool IsPostalCode(string postalCode)
        {
            Regex regex = new Regex("^[0-9]{4}[A-Z]{2}$");
            return regex.IsMatch(postalCode);
        }
    }
}
