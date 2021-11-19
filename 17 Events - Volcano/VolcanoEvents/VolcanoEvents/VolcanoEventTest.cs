using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace VolcanoEvents
{
    [TestClass]
    public class VolcanoEventTest
    {
        [TestMethod]
        public void VillagerSafeOnSmoking()
        {
            Volcano popo = new Volcano();
            Villager monday = new Villager(popo);

            Assert.IsFalse(monday.IsFleeing);

            popo.IncreaseDanger();

            Assert.IsFalse(monday.IsFleeing);
        }

        [TestMethod]
        public void VillagerFleeingOnFallingRocks()
        {
            Volcano popo = new Volcano();
            Villager monday = new Villager(popo);

            Assert.IsFalse(monday.IsFleeing);

            popo.IncreaseDanger();
            popo.IncreaseDanger();

            Assert.IsTrue(monday.IsFleeing);
        }

        [TestMethod]
        public void TreeSafeOnRocksFalling()
        {
            Volcano popo = new Volcano();
            Tree coconut = new Tree(popo);

            Assert.IsFalse(coconut.IsBurning);

            popo.IncreaseDanger();
            popo.IncreaseDanger();

            Assert.IsFalse(coconut.IsBurning);
        }

        [TestMethod]
        public void TreeBurningOnLava()
        {
            Volcano popo = new Volcano();
            Tree coconut = new Tree(popo);

            Assert.IsFalse(coconut.IsBurning);

            popo.IncreaseDanger();
            popo.IncreaseDanger();
            popo.IncreaseDanger();

            Assert.IsTrue(coconut.IsBurning);
        }

        [TestMethod]
        public void ForestBurning()
        {
            List<Tree> forest = new List<Tree>();
            Volcano popo = new Volcano();
            Villager wednesday = new Villager(popo);

            for (int i = 0; i < 5; i++)
            {
                forest.Add(new Tree(popo));
            }

            Assert.IsFalse(forest.Any(tree => tree.IsBurning));
            Assert.IsFalse(wednesday.IsFleeing);

            popo.IncreaseDanger();
            popo.IncreaseDanger();
            popo.IncreaseDanger();

            Assert.IsTrue(forest.All(tree => tree.IsBurning));
            Assert.IsTrue(wednesday.IsFleeing);
        }
    }
}
