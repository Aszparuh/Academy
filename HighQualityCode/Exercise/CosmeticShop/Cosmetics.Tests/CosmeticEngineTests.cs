namespace Cosmetics.Tests
{
    using System.Collections.Generic;
    using Contracts;
    using Mocked;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class CosmeticEngineTests
    {
        [Test]
        public void Start_WhenInputStringIsValidCreateCategoryCommand_CategoryShouldBeAddedToList()
        {
            // Arrange
            string categoryName = "For Female";

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedShoppingCart = new Mock<IShoppingCart>();
            var mockedCommandParser = new Mock<ICommandParser>();

            var mockedCommand = new Mock<ICommand>();
            mockedCommand.SetupGet(x => x.Name).Returns("CreateCategory");
            mockedCommand.SetupGet(x => x.Parameters).Returns(new List<string>() { categoryName });
            mockedCommandParser.Setup(x => x.ReadCommands()).Returns(new List<ICommand>() { mockedCommand.Object });

            var mockedCategory = new Mock<ICategory>();
            mockedCategory.SetupGet(x => x.Name).Returns(categoryName);
            mockedFactory.Setup(x => x.CreateCategory(It.IsAny<string>())).Returns(mockedCategory.Object);

            var engine = new MockedEngine(mockedFactory.Object, mockedShoppingCart.Object, mockedCommandParser.Object);

            // Act
            engine.Start();

            // Assert
            Assert.IsTrue(engine.Categories.ContainsKey(categoryName));
            Assert.AreSame(mockedCategory.Object, engine.Categories[categoryName]);
        }

        [Test]
        public void Start_WhenInputStringIsValidAddProductCommand_ProductShouldBeAddedToList()
        {
            // Arrange
            string categoryName = "For Female";
            string productName = "Test";

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedShoppingCart = new Mock<IShoppingCart>();
            var mockedCommandParser = new Mock<ICommandParser>();
            var mockedShampoo = new Mock<IShampoo>();

            var mockedCommand = new Mock<ICommand>();
            mockedCommand.SetupGet(x => x.Name).Returns("AddToCategory");
            mockedCommand.SetupGet(x => x.Parameters).Returns(new List<string>() { categoryName, productName });
            mockedCommandParser.Setup(x => x.ReadCommands()).Returns(new List<ICommand>() { mockedCommand.Object });

            var mockedCategory = new Mock<ICategory>();
            mockedCategory.SetupGet(x => x.Name).Returns(categoryName);
            mockedFactory.Setup(x => x.CreateCategory(It.IsAny<string>())).Returns(mockedCategory.Object);

            var engine = new MockedEngine(mockedFactory.Object, mockedShoppingCart.Object, mockedCommandParser.Object);
            engine.Categories.Add(categoryName, mockedCategory.Object);
            engine.Products.Add(productName, mockedShampoo.Object);

            // Act
            engine.Start();

            // Assert
            mockedCategory.Verify(x => x.AddProduct(mockedShampoo.Object), Times.Once);
        }

        [Test]
        public void Start_WhenInputStringIsValidAddProductCommand_ProductShouldBeRemovedFromList()
        {
            // Arrange
            var commandName = "RemoveFromCategory";
            var productName = "SomeProduct";
            var categoryName = "TestCategory";

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedShoppingCart = new Mock<IShoppingCart>();

            var mockedCommand = new Mock<ICommand>();
            mockedCommand.SetupGet(x => x.Name).Returns(commandName);
            mockedCommand.SetupGet(x => x.Parameters).Returns(new List<string>() { categoryName, productName });

            var mockedParser = new Mock<ICommandParser>();
            mockedParser.Setup(x => x.ReadCommands()).Returns(new List<ICommand>() { mockedCommand.Object });

            var mockedProduct = new Mock<IProduct>();
            var mockedCategory = new Mock<ICategory>();

            var mockedEngine = new MockedEngine(mockedFactory.Object, mockedShoppingCart.Object, mockedParser.Object);
            mockedEngine.Categories.Add(categoryName, mockedCategory.Object);
            mockedEngine.Products.Add(productName, mockedProduct.Object);

            // Act
            mockedEngine.Start();

            // Assert
            mockedCategory.Verify(x => x.RemoveProduct(It.IsAny<IProduct>()), Times.Once);
        }

        [Test]
        public void Start_WhenInputStringIsValidShowCategoryCommand_RespectiveCategoryPrintMethodShouldBeInvoked()
        {
            var commandName = "ShowCategory";
            var categoryName = "TestName";

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedShoppingCart = new Mock<IShoppingCart>();
            var mockedParser = new Mock<ICommandParser>();
            var mockedCategory = new Mock<ICategory>();
            var mockedCommand = new Mock<ICommand>();

            mockedCommand.SetupGet(x => x.Name).Returns(commandName);
            mockedCommand.SetupGet(x => x.Parameters).Returns(new List<string>() { categoryName });
            mockedParser.Setup(x => x.ReadCommands()).Returns(new List<ICommand>() { mockedCommand.Object });
            mockedCategory.SetupGet(x => x.Name).Returns(categoryName);

            var mockedEngine = new MockedEngine(mockedFactory.Object, mockedShoppingCart.Object, mockedParser.Object);
            mockedEngine.Categories.Add(categoryName, mockedCategory.Object);
            mockedEngine.Start();

            mockedCategory.Verify(x => x.Print(), Times.Once);
        }

        [Test]
        public void Start_WhenInputStringIsValidCreateShampooCommand_ShampooShouldBeAddedToProducts()
        {
            // ShampooName Brand Price Gender Milimeters Usage
            // TestName TestBrand 20 men 50 everyday
            var commandName = "CreateShampoo";
            var shampooName = "TestName";
            var shampooBrand = "TestBrand";
            var shampooPrice = "20";
            var shampooGender = "men";
            var shampooMilimeters = "50";
            var shampooUsage = "everyday";

            var mockedShampoo = new Mock<IShampoo>();
            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedShoppingCart = new Mock<IShoppingCart>();
            var mockedParser = new Mock<ICommandParser>();
            var mockedCommand = new Mock<ICommand>();

            mockedCommand.SetupGet(x => x.Name).Returns(commandName);
            mockedCommand.SetupGet(x => x.Parameters).Returns(new List<string>() { shampooName, shampooBrand, shampooPrice, shampooGender, shampooMilimeters, shampooUsage });
            mockedParser.Setup(x => x.ReadCommands()).Returns(new List<ICommand>() { mockedCommand.Object });
            mockedFactory.Setup(x => x.CreateShampoo(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<decimal>(),
                It.IsAny<Common.GenderType>(),
                It.IsAny<uint>(),
                It.IsAny<Common.UsageType>()))
                .Returns(mockedShampoo.Object);

            var mockedEngine = new MockedEngine(mockedFactory.Object, mockedShoppingCart.Object, mockedParser.Object);
            mockedEngine.Start();

            Assert.IsTrue(mockedEngine.Products.ContainsKey(shampooName));
            Assert.AreSame(mockedShampoo.Object, mockedEngine.Products[shampooName]);
        }

        [Test]
        public void Start_WhenInputStringIsValidCreateCreateToothpasteCommand_ToothpasteShouldBeAddedToProducts()
        {
            var commandName = "CreateToothpaste";
            var toothpasteName = "TestName";
            var toothpasteBrand = "TestBrand";
            var toothpastePrice = "20";
            var toothpasteType = "men";
            var toothpasteIngrediants = "indrediantOne ingrediantTwo";

            var mockedToothpaste = new Mock<IToothpaste>();
            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedShoppingCart = new Mock<IShoppingCart>();
            var mockedParser = new Mock<ICommandParser>();
            var mockedCommand = new Mock<ICommand>();

            mockedCommand.SetupGet(x => x.Name).Returns(commandName);
            mockedCommand.SetupGet(x => x.Parameters).Returns(new List<string>() { toothpasteName, toothpasteBrand, toothpastePrice, toothpasteType, toothpasteIngrediants });
            mockedParser.Setup(x => x.ReadCommands()).Returns(new List<ICommand>() { mockedCommand.Object });
            mockedFactory.Setup(x => x.CreateToothpaste(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<decimal>(),
                It.IsAny<Common.GenderType>(),
                It.IsAny<IList<string>>()))
                .Returns(mockedToothpaste.Object);

            var mockedEngine = new MockedEngine(mockedFactory.Object, mockedShoppingCart.Object, mockedParser.Object);
            mockedEngine.Start();

            Assert.IsTrue(mockedEngine.Products.ContainsKey(toothpasteName));
            Assert.AreSame(mockedToothpaste.Object, mockedEngine.Products[toothpasteName]);
        }

        [Test]
        public void Start_WhenInputStringIsValidAddToShoppingCartCommand_ProductShouldBeAddedToShoppingCart()
        {
            var commandName = "AddToShoppingCart";
            var productName = "TestProduct";

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedShoppingCart = new Mock<IShoppingCart>();
            var mockedParser = new Mock<ICommandParser>();
            var mockedShampoo = new Mock<IShampoo>();
            var mockedCommand = new Mock<ICommand>();

            mockedCommand.SetupGet(x => x.Name).Returns(commandName);
            mockedCommand.SetupGet(x => x.Parameters).Returns(new List<string>() { productName });
            mockedParser.Setup(x => x.ReadCommands()).Returns(new List<ICommand>() { mockedCommand.Object });

            var mockedEngine = new MockedEngine(mockedFactory.Object, mockedShoppingCart.Object, mockedParser.Object);
            mockedEngine.Products.Add(productName, mockedShampoo.Object);
            mockedEngine.Start();

            mockedShoppingCart.Verify(x => x.AddProduct(It.IsAny<IProduct>()), Times.Once);
        }

        [Test]
        public void Start_WhenInputStringIsValidRemoveFromShoppingCartCommand_ProductShouldBeRemovedFromShoppingCart()
        {
            var commandName = "RemoveFromShoppingCart";
            var productName = "TestProduct";

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedShoppingCart = new Mock<IShoppingCart>();
            var mockedParser = new Mock<ICommandParser>();
            var mockedShampoo = new Mock<IShampoo>();
            var mockedCommand = new Mock<ICommand>();

            mockedCommand.SetupGet(x => x.Name).Returns(commandName);
            mockedCommand.SetupGet(x => x.Parameters).Returns(new List<string>() { productName });
            mockedParser.Setup(x => x.ReadCommands()).Returns(new List<ICommand>() { mockedCommand.Object });
            mockedShoppingCart.Setup(x => x.ContainsProduct(mockedShampoo.Object)).Returns(true);

            var mockedEngine = new MockedEngine(mockedFactory.Object, mockedShoppingCart.Object, mockedParser.Object);
            mockedEngine.Products.Add(productName, mockedShampoo.Object);
            mockedEngine.Start();

            mockedShoppingCart.Verify(x => x.RemoveProduct(It.IsAny<IProduct>()), Times.Once);
        }
    }
}
