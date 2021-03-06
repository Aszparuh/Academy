﻿namespace Cars.Tests
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Cars.Contracts;
    using Cars.Controllers;
    using Cars.Models;
    using Helpers;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class CarsControllerTests
    {
        [Test]
        public void IndexShouldReturnAllCars()
        {
            var list = new List<Car>()
            {
                new Car(),
                new Car(),
                new Car()
            };
            var mock = new Mock<ICarsRepository>();
            mock.Setup(x => x.All()).Returns(list);
            var controller = new CarsController(mock.Object);

            var viewModel = (ICollection<Car>)controller.Index().Model;

            Assert.AreEqual(3, viewModel.Count);
        }

        [Test]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var mock = new Mock<ICarsRepository>();
            mock.Setup(x => x.Add(null)).Throws<ArgumentNullException>();
            var controller = new CarsController(mock.Object);

            Car car = null;

            Assert.Throws<ArgumentNullException>(() => controller.Add(car));
        }

        [Test]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var mock = new Mock<ICarsRepository>();
            var controller = new CarsController(mock.Object);

            var car = new Car
            {
                Id = 15,
                Make = string.Empty,
                Model = "330d",
                Year = 2014
            };

            Assert.Throws<ArgumentNullException>(() => controller.Add(car));
        }

        [Test]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var mock = new Mock<ICarsRepository>();
            var controller = new CarsController(mock.Object);

            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = string.Empty,
                Year = 2014
            };

            Assert.Throws<ArgumentNullException>(() => controller.Add(car));
        }

        [Test]
        public void AddingCarShouldReturnADetail()
        {
            var list = new List<Car>()
            {
                new Car(),
                new Car(),
                new Car()
            };
            var mock = new Mock<ICarsRepository>();
            mock.Setup(x => x.Add(It.IsNotNull<Car>())).Callback<Car>((Car c) => list.Add(c));
            mock.Setup(x => x.GetById(It.IsAny<int>())).Returns((int i) => list.Where(c => c.Id == i).Single());
            var controller = new CarsController(mock.Object);

            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };
            var viewModel = controller.Add(car);

            EqualityChecker.AreEqualByJson(car, (Car)viewModel.Model);
        }

        [Test]
        public void RepositorySearchShouldBeCalledOnceWhenControllerSearch()
        {
            var mock = new Mock<ICarsRepository>();
            var controller = new CarsController(mock.Object);
            controller.Search(string.Empty);

            mock.Verify(x => x.Search(It.IsAny<string>()), Times.Exactly(1));
        }

        [Test]
        public void SearchShouldReturnAllTheCarsIfNullOrEmptyStringIsPassed()
        {
            var list = new List<Car>()
            {
                new Car(),
                new Car(),
                new Car()
            };
            var mock = new Mock<ICarsRepository>();
            mock.Setup(x => x.Search(It.IsAny<string>())).Returns(list);
            var controller = new CarsController(mock.Object);

            var viewModel = controller.Search(null);
            var returnedList = (List<Car>)viewModel.Model;

            Assert.AreEqual(list.Count, returnedList.Count);
        }

        [Test]
        public void SearchShouldReturnAllTheCarsWithSearchedTermModel()
        {
            var list = new List<Car>()
            {
                new Car()
                {
                    Model = "303"
                },
                new Car()
                {
                    Model = "303"
                },
                new Car()
                {
                    Model = "Clio"
                }
            };
            var expectedList = new List<Car>()
            {
                new Car()
                {
                    Model = "303"
                },
                new Car()
                {
                    Model = "303"
                }
            };
            var mock = new Mock<ICarsRepository>();
            mock.Setup(x => x.Search(It.IsAny<string>())).Returns((string st) =>
            {
                return list.Where(c => c.Make == st || c.Model == st).ToList();
            });
            var controller = new CarsController(mock.Object);
            var searchTerm = "303";

            var returnedList = (IEnumerable<Car>)controller.Search(searchTerm).Model;

            Assert.AreEqual(true, returnedList.All(c => c.Model == searchTerm));
        }

        [Test]
        public void SortByMakeSholdReturnSortedByMake()
        {
            var list = new List<Car>()
            {
                new Car()
                {
                    Make = "BMW",
                    Year = 2000
                },
                new Car()
                {
                    Make = "Mercedes",
                    Year = 1996
                },
                new Car()
                {
                    Make = "Renault",
                    Year = 1982
                }
            };
            var mock = new Mock<ICarsRepository>();
            mock.Setup(x => x.SortedByMake()).Returns(list.OrderBy(c => c.Make).ToList());
            var controller = new CarsController(mock.Object);

            var viewModel = controller.Sort("make");

            CollectionAssert.AreEqual(list.OrderBy(c => c.Make), (List<Car>)viewModel.Model);
        }

        [Test]
        public void SortByYearSholdReturnSortedByYear()
        {
            var list = new List<Car>()
            {
                new Car()
                {
                    Make = "BMW",
                    Year = 2000
                },
                new Car()
                {
                    Make = "Mercedes",
                    Year = 1996
                },
                new Car()
                {
                    Make = "Renault",
                    Year = 1982
                }
            };
            var mock = new Mock<ICarsRepository>();
            mock.Setup(x => x.SortedByYear()).Returns(list.OrderBy(c => c.Year).ToList());
            var controller = new CarsController(mock.Object);

            var viewModel = controller.Sort("year");

            CollectionAssert.AreEqual(list.OrderBy(c => c.Year), (List<Car>)viewModel.Model);
        }
    }
}
