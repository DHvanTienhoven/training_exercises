namespace StaticPetsExercise
{
    public class Pet
    {
        public static int _numberofPetsBorn = 0;
        public string _name;

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
