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

        public void Start_WhenInputStringIsValidAddProductCommand_ProductShouldBeAddedToList()
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
    }
}
