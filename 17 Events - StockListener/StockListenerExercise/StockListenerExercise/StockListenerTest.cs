using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StockListenerExercise
{
    [TestClass]
    public class StockListenerTest
    {
        [TestMethod]
        public void SellsOnHighPrice()
        {
            Stock euros = new Stock(14);
            Broker euroBroker = new Broker(euros);

            Assert.IsFalse(euroBroker.IsSelling);

            euros.Price = 500;

            Assert.IsTrue(euroBroker.IsSelling);
        }

        [TestMethod]
        public void BothBrokersSellOnHighPrice()
        {
            Stock euros = new Stock(32);
            Broker euroBroker1 = new Broker(euros);
            Broker euroBroker2 = new Broker(euros);

            euros.Price = 300;

            Assert.IsTrue(euroBroker1.IsSelling);
            Assert.IsTrue(euroBroker2.IsSelling);
        }

        [TestMethod]
        public void BrokerIsSellingFromTheStart()
        {
            Stock euros = new Stock(101);
            Broker broker = new Broker(euros);

            Assert.IsTrue(broker.IsSelling);
        }

        [TestMethod]
        public void StopsSellingOnLowPrice()
        {
            Stock euros = new Stock(34);
            Broker euroBroker = new Broker(euros);

            euros.Price = 300;

            Assert.IsTrue(euroBroker.IsSelling);

            euros.Price = 100;

            Assert.IsFalse(euroBroker.IsSelling);
        }

        [TestMethod]
        public void BothStockAndExchangeChanges()
        {
            Stock euros = new Stock(600);
            Stock rupees = new Stock(3);

            MoneyExchange exchange = new MoneyExchange(euros, rupees);
            Broker broker = new Broker(rupees);

            Assert.IsTrue(exchange.ExchangeRate > 1);

            rupees.Price = 800;

            Assert.IsFalse(exchange.ExchangeRate > 1);
            Assert.IsTrue(broker.IsSelling);
        }
    }
}
