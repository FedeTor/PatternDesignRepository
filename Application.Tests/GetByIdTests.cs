using Application.UseCase;
using Domain.Domain.Interfaces.IRepositorySqlServer;
using Domain.Entities;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tests
{
    [TestFixture]
    public class GetByIdTests
    {
        private Mock<IRepository> _productRepositoryMock;
        private Mock<ILogger<GetById>> _loggerMock;
        private GetById _getByIdService;

        [SetUp]
        public void SetUp()
        {
            _productRepositoryMock = new Mock<IRepository>();
            _loggerMock = new Mock<ILogger<GetById>>();
            _getByIdService = new GetById(_productRepositoryMock.Object, _loggerMock.Object);
        }

        [Test]
        public async Task GetByIdAsync_ProductExists_ReturnsSuccessResult()
        {
            // Arrange
            int productId = 1;
            var product = Product.Create("Product Test", 100);
            _productRepositoryMock.Setup(repo => repo.GetById(productId)).ReturnsAsync(product);

            // Act
            var result = await _getByIdService.GetByIdAsync(productId);

            // Assert
            Assert.That(result.Success, Is.True);
            Assert.That(result.Message, Is.EqualTo("Producto encontrados."));
            Assert.That(result.Data, Is.EqualTo(product));
        }

        [Test]
        public async Task GetByIdAsync_ProductDoesNotExist_ReturnsNullDataInSuccessResult()
        {
            // Arrange
            int productId = 1;
            _productRepositoryMock.Setup(repo => repo.GetById(productId)).ReturnsAsync((Product)null);

            // Act
            var result = await _getByIdService.GetByIdAsync(productId);

            // Assert
            Assert.That(result.Success, Is.True);
            Assert.That(result.Message, Is.EqualTo("Producto encontrados."));
            Assert.That(result.Data, Is.Null);
        }

        [Test]
        public async Task GetByIdAsync_ExceptionThrown_ReturnsErrorResult()
        {
            // Arrange
            int productId = 1;
            _productRepositoryMock.Setup(repo => repo.GetById(productId)).ThrowsAsync(new Exception("Database error"));

            // Act
            var result = await _getByIdService.GetByIdAsync(productId);

            // Assert
            Assert.That(result.Success, Is.False);
            Assert.That(result.Message, Is.EqualTo("Error al obtener los productos: Database error"));
            Assert.That(result.Data, Is.Null);
        }
    }
}
