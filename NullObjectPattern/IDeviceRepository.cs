using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    public interface IDeviceRepository
    {
        IDevice GetDeviceByName (string name);
    }

    public class DeviceRepository : IDeviceRepository
    {
        private List<IDevice> _devicesList;

        public DeviceRepository ()
        {
            _devicesList = new List<IDevice>
            {
                new RealDevice() { Name = "Camera" },
                new RealDevice() { Name = "Gripper" }
            };
        }

        public IDevice GetDeviceByName (string name)
        {
            IDevice device = _devicesList.SingleOrDefault(dev => dev.Name == name);

            // Do the null check here instead of in the client code.
            if (device == null)
            {
                device = new NullDevice();
            }

            return device;
        }
    }
}
