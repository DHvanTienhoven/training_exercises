using System.Collections.Generic;

namespace StaticPetsExercise
{
    public class PetShop
    {
        private static List<Pet> petsList = new List<Pet>();

        public void AddPet(Pet newPet )
        {
            petsList.Add(newPet);
        }

        public static int Count
        {
            get { return petsList.Count; }
        }
    }
}
