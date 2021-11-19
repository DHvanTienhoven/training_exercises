using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClassExercise
{
    public class Person
    {
        private int age;

        public Person(int initial_age)
        {
            age = initial_age;
        }


        public void BirthdayParty()
    {
           age ++;
    }
        public int GetAge()
        {
            return age;
        }
    }
}
