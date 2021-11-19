using System;

namespace BridgeControls
{
    public enum Status
    {
        Open,
        Closed,
        Broken
    }

    // TODO: Fix this enum
    public enum ErrorReason
    {
        None,
        PowerOutage,
        BrokenEngine,
        NeedsOil,
        CracksInRoad
    }

    public class BridgeController
    {
        public Status status;
        public ErrorReason reason;

        public BridgeController(Status initialStatus)
        {
            status = initialStatus;
        }

        public void OpenBridge()
        {
            // TODO: Open the bridge
        }

        public void BreakDown(ErrorReason theReason)
        {
            // TODO: Break the bridge down
        }
    }
}
