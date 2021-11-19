using System;

namespace JobsExercise
{
    public class ConstructionWorker : Worker
    {
        int _percentageDone = 0;

        public void Build()
        {
            if (_percentageDone < 100)
            {
                _percentageDone += 10;
            }
            Console.WriteLine("Building at {0}%", _percentageDone);
        }
    }
}
