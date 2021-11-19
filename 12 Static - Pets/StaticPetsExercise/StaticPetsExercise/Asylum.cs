using System.Collections.Generic;

namespace StaticPetsExercise
{
    public class Asylum
    {
        private List<Pet> petsList = new List<Pet>();

        public void AddPet(Pet newPet)
        {
            petsList.Add(newPet);
        }

        public int Count
        {
            get { return petsList.Count; }
        }
    }
}
