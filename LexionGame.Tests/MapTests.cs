using LexiconGame.ConsoleGame.Extensions;
using LexiconGame.ConsoleGame.Services;
using Microsoft.Extensions.Configuration;
using Moq;

namespace LexionGame.Tests
{
    public class MapTests
    {
        //1. Service
        //[Fact]
        //public void Constructor_SetCorrectWidth()
        //{
        //    const int expectedWidth = 10;
        //    const int expectedHeight = 10;

        //    var mapServiceMock = new Mock<IMapService>();
        //    mapServiceMock.Setup(x => x.GetMap()).Returns((expectedWidth, expectedHeight));

        //    var map = new Map(mapServiceMock.Object);

        //    Assert.Equal(expectedWidth, map.Width);
        //} 
        

        //2. Interface
        //[Fact]
        //public void Constructor_SetCorrectWidth()
        //{
        //    const int expectedWidth = 10;

        //    var iconfigMock = new Mock<IConfiguration>();
        //    var getMapSizeMock = new Mock<IGetMapSize>();

        //    getMapSizeMock.Setup(x => x.GetMapSizeFor(iconfigMock.Object, It.IsAny<string>())).Returns(expectedWidth);
        //    TestExtensions.Implementation = getMapSizeMock.Object;

        //    var map = new Map(iconfigMock.Object);

        //    Assert.Equal(expectedWidth, map.Width);
        //} 
        
        //3. Func
        [Fact]
        public void Constructor_SetCorrectWidth()
        {
            const int expectedWidth = 10;

            var iconfigMock = new Mock<IConfiguration>();

            TestExtensions.Implementation = (iconfig, value) => expectedWidth;

            var map = new Map(iconfigMock.Object);

            Assert.Equal(expectedWidth, map.Width);
        }
    }
}