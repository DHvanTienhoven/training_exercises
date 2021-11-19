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
    }
}
