using FluentAssertions;
using Marketplace.API.Controllers;
using Marketplace.Core;
using Moq;

namespace Marketplace.UnitTests.Controllers;

public class ProductTest
{
    [Fact]
    public void GetAll_OnSuccess_Returns200Status()
    {

        //Arrange
        var productCore = new Mock<IProductCore>();

        //Todo: Unit test

        //productCore.Setup(core => core.GetProducts())
        //    .Returns()

        //var productsController = new ProductsController(productCore.Object);

        //Act
        //var sut = productsController.Get();

        //Assert

        //sut.Should().BeOfType()

    }
}