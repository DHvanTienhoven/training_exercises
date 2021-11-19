using Microsoft.VisualStudio.TestTools.UnitTesting;
using BridgeControls;

namespace BridgeControlsTest
{
    [TestClass]
    public class BridgeControllerTest
    {
        [TestMethod]
        public void ClosedBridge_OpenBridge_OpensIt()
        {
            BridgeController controller = new BridgeController(Status.Closed);
            controller.OpenBridge();

            Assert.AreEqual(Status.Open, controller.status);
        }

        [TestMethod]
        public void BrokenBridge_OpenBridge_StillBroken()
        {
            BridgeController controller = new BridgeController(Status.Broken);
            controller.OpenBridge();

            Assert.AreEqual(Status.Broken, controller.status);
        }

        [TestMethod]
        public void BrokenBridge_GetStatus_NeedsOil()
        {
            BridgeController controller = new BridgeController(Status.Open);

            // TODO: Fill in what breaks down
            controller.BreakDown(TODO);

            Assert.AreEqual(Status.Broken, controller.status);
            Assert.AreEqual(ErrorReason.NeedsOil, controller.reason);
        }

        [TestMethod]
        public void BrokenBridge_GetStatus_NeedsOilAndPowerOutage()
        {
            BridgeController controller = new BridgeController(Status.Open);

            // TODO: Fill in what breaks down
            controller.BreakDown(TODO);

            Assert.AreEqual(Status.Broken, controller.status);
            Assert.IsTrue(controller.reason.HasFlag(ErrorReason.NeedsOil));
            Assert.IsTrue(controller.reason.HasFlag(ErrorReason.PowerOutage));
            Assert.IsFalse(controller.reason.HasFlag(ErrorReason.BrokenEngine));
            Assert.IsFalse(controller.reason.HasFlag(ErrorReason.CracksInRoad));

            Assert.AreEqual("PowerOutage, NeedsOil", controller.reason.ToString());
        }
    }
}
