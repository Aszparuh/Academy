namespace IntergalacticTravel.Tests.TeleportStation
{
    using System.Collections.Generic;
    using Contracts;
    using Mocked;
    using Moq;
    using NUnit.Framework;
    using IntergalacticTravel;
    using System;
    using Exceptions;

    [TestFixture]
    public class TeleportStationTests
    {
        [Test]
        public void Constructor_ShouldSetUpAllFields_WhenNewTeleportStationIsCreatedWith_ValidParametersPassedToConstructor()
        {
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IEnumerable<IPath>>();
            var mockedLocation = new Mock<ILocation>();

            var station = new MockedTeleportStation(mockedOwner.Object, mockedGalacticMap.Object, mockedLocation.Object);

            Assert.AreSame(mockedOwner.Object, station.BusinessOwner);
            Assert.AreSame(mockedGalacticMap.Object, station.GalacticMap);
            Assert.AreSame(mockedLocation.Object, station.Location);
        }

        [Test]
        public void TeleportUnit_ShouldThrowArgumentNullException_WithMessageThatContainsStringunitToTeleport_WhenUnitToTeleportIsNull()
        {
            var expectedString = "unitToTeleport";
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IEnumerable<IPath>>();
            var mockedLocation = new Mock<ILocation>();
            var mockedTargetLocation = new Mock<ILocation>();

            var station = new TeleportStation(mockedOwner.Object, mockedGalacticMap.Object, mockedLocation.Object);

            var exception = Assert.Throws<ArgumentNullException>(() => station.TeleportUnit(null, mockedTargetLocation.Object));
            StringAssert.Contains(expectedString, exception.Message);
        }

        [Test]
        public void TeleportUnit_ShouldThrowArgumentNullException_WithMessageThatContainsStringDestination_WhenDestinationIsNull()
        {
            var expectedString = "destination";
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IEnumerable<IPath>>();
            var mockedLocation = new Mock<ILocation>();
            var mockedUnitToTeleport = new Mock<IUnit>();

            var station = new TeleportStation(mockedOwner.Object, mockedGalacticMap.Object, mockedLocation.Object);

            var exception = Assert.Throws<ArgumentNullException>(() => station.TeleportUnit(mockedUnitToTeleport.Object, null));
            StringAssert.Contains(expectedString, exception.Message);
        }

        [Test]
        public void TeleportUnit_ShouldThrowTeleportOutOfRangeException_WithmessageThatContainsUnitToTeleportCurrentLocation_WhenUnitTryingToUseTeleportStationFromDistantLocation()
        {
            var expectedString = "nitToTeleport.CurrentLocation";
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IEnumerable<IPath>>();
            var mockedStationLocation = new Mock<ILocation>();
            var mockedDestination = new Mock<ILocation>();

            var mockedGalaxy = new Mock<IGalaxy>();
            mockedGalaxy.SetupGet(x => x.Name).Returns("Test");

            var mockedUnitPlanet = new Mock<IPlanet>();
            mockedUnitPlanet.SetupGet(x => x.Name).Returns("Earth");
            mockedUnitPlanet.SetupGet(x => x.Galaxy).Returns(mockedGalaxy.Object);
             var mockedUnitLocation = new Mock<ILocation>();
            mockedUnitLocation.SetupGet(x => x.Planet).Returns(mockedUnitPlanet.Object);

            var mockedStationPlanet = new Mock<IPlanet>();
            mockedStationPlanet.SetupGet(x => x.Name).Returns("Mars");
            mockedStationPlanet.SetupGet(x => x.Galaxy).Returns(mockedGalaxy.Object);
            mockedStationLocation.SetupGet(x => x.Planet).Returns(mockedStationPlanet.Object);
            var station = new TeleportStation(mockedOwner.Object, mockedGalacticMap.Object, mockedStationLocation.Object);

            var mockedUnit = new Mock<IUnit>();
            mockedUnit.SetupGet(x => x.CurrentLocation).Returns(mockedUnitLocation.Object);

            var exception = Assert.Throws<TeleportOutOfRangeException>(() => station.TeleportUnit(mockedUnit.Object, mockedDestination.Object));
            StringAssert.Contains(expectedString, exception.Message);
        }

        //[Test]
        //public void TeleportUnit_ShouldThrowInvalidTeleportationLocationException_WithMessageThatContainsUnitsWillOverlap_WhenTeleportingToAnotherUnitLocation()
        //{
        //    var expectedString = "units will overlap";
        //    var mockedOwner = new Mock<IBusinessOwner>();
        //    var mockedStationLocation = new Mock<ILocation>();

        //    var mockedDestination = new Mock<ILocation>();
        //    var mockedPath = new Mock<IPath>();
        //    var mockedCoordinates = new Mock<IGPSCoordinates>();
        //    mockedCoordinates.SetupGet(x => x.Latitude).Returns(5d);
        //    mockedCoordinates.SetupGet(x => x.Longtitude).Returns(15d);

        //    var mockedGalaxy = new Mock<IGalaxy>();
        //    mockedGalaxy.SetupGet(x => x.Name).Returns("Test");

        //    var mockedUnitPlanet = new Mock<IPlanet>();
        //    mockedUnitPlanet.SetupGet(x => x.Name).Returns("Earth");
        //    mockedUnitPlanet.SetupGet(x => x.Galaxy).Returns(mockedGalaxy.Object);
        //    var mockedUnitLocation = new Mock<ILocation>();
        //    mockedUnitLocation.SetupGet(x => x.Planet).Returns(mockedUnitPlanet.Object);

        //    var mockedStationPlanet = new Mock<IPlanet>();
        //    mockedStationPlanet.SetupGet(x => x.Name).Returns("Mars");
        //    mockedStationPlanet.SetupGet(x => x.Galaxy).Returns(mockedGalaxy.Object);
        //    mockedStationLocation.SetupGet(x => x.Planet).Returns(mockedUnitPlanet.Object);

        //    var mockedTargetLocation = new Mock<ILocation>();
        //    mockedTargetLocation.SetupGet(x => x.Coordinates).Returns(mockedCoordinates.Object);
        //    mockedPath.SetupGet(x => x.TargetLocation).Returns(mockedTargetLocation.Object);

        //    var pathList = new List<IPath>()
        //    {
        //       mockedPath.Object
        //    };

        //    var mockedUnit = new Mock<IUnit>();
        //    mockedUnit.SetupGet(x => x.CurrentLocation).Returns(mockedTargetLocation.Object);

        //    var station = new TeleportStation(mockedOwner.Object, pathList, mockedStationLocation.Object);


        //    var exception = Assert.Throws<InvalidTeleportationLocationException>(() => station.TeleportUnit(mockedUnit.Object, mockedStationLocation.Object));
        //    StringAssert.Contains(expectedString, exception.Message);
        //}
    }
}
