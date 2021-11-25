using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace JobsExercise
{
    [TestClass]
    public class WorkerTest
    {
        [TestMethod]
        public void LetThemAllHaveLunch()
        {
            List<Worker> workers = new List<Worker>
            {
                new ConstructionWorker(),
                new OfficeClerk()
            };

            int numberOfWorkersHavingLunch = 0;

            foreach(Worker worker in workers)
            {
                worker.LunchBreak();
                numberOfWorkersHavingLunch++;
            }
            // TODO: Go over the list of workers and let them all have a lunchbreak.
            // Increment the counter for every lunchbreak you are calling.


            Assert.AreEqual(workers.Count, numberOfWorkersHavingLunch);
        }

        [TestMethod]
        public void CountNumberOfOfficeClerks()
        {
            List<Worker> workers = new List<Worker>
            {
                new ConstructionWorker(),
                new ConstructionWorker(),
                new OfficeClerk(),
                new ConstructionWorker(),
                new OfficeClerk()
            };

            int numberOfClerks = 0;
            // TODO: Go over the list of workers and count the number of OfficeClerks. Use the is-keyword.

            foreach(Worker worker in workers)
            {
                if(worker is OfficeClerk)
                {
                    numberOfClerks++;
                }
            }

            Assert.AreEqual(2, numberOfClerks);
        }

        [TestMethod]
        public void LetAllBuildersBuild()
        {
            List<Worker> workers = new List<Worker>
            {
                new ConstructionWorker(),
                new ConstructionWorker(),
                new OfficeClerk(),
                new ConstructionWorker(),
                new OfficeClerk()
            };

            int numberOfConstructionWorkersBuilding = 0;
            // TODO: Let all construction workers in the list build on their building.
            // Increment the counter for every build function you are calling.

            foreach(ConstructionWorker worker in workers.OfType<ConstructionWorker>())
            {
          
                    worker.Build();
                    numberOfConstructionWorkersBuilding++;
            
            }
            

            Assert.AreEqual(3, numberOfConstructionWorkersBuilding);
        }
    }
}
