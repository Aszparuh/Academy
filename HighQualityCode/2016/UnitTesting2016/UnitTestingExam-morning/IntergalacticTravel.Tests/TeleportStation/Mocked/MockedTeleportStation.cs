namespace IntergalacticTravel.Tests.TeleportStation.Mocked
{
    using System.Collections.Generic;
    using Contracts;
    using IntergalacticTravel;

    public class MockedTeleportStation : TeleportStation
    {
        public MockedTeleportStation(IBusinessOwner owner, IEnumerable<IPath> galacticMap, ILocation location)
            : base(owner, galacticMap, location)
        {
        }

        public IBusinessOwner BusinessOwner
        {
            get
            {
                return this.owner;
            }
        }

        public IEnumerable<IPath> GalacticMap
        {
            get
            {
                return this.galacticMap;
            }
        }

        public ILocation Location
        {
            get
            {
                return this.location;
            }
        }
    }
}
