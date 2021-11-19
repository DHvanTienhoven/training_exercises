using System;

namespace BridgeControls
{
    public enum Status
    {
        Open,
        Closed,
        Broken
    }

    public class BridgeController
    {
        public Status status;

        public BridgeController(Status initialStatus)
        {
            status = initialStatus;
        }

        public void OpenBridge()
        {
            switch(status)
                {
                case Status.Broken:
                    break;
                default:
                    status = Status.Open;
                    break;
        }
            
            // TODO: Open the bridge
        }

        public void BreakDown()
        {
            status = Status.Broken;
            // TODO: Break the bridge down
        }
    }
}
