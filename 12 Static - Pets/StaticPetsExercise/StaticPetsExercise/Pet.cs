namespace StaticPetsExercise
{
    public class Pet
    {
        public int _numberofPetsBorn = 0;
        public static string _name;

        public Pet()
        {
            _numberofPetsBorn++;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public static int NumberOfPetsBorn
        {
            get { return _numberofPetsBorn;  }
        }
    }
}
