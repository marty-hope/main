using System.Extensions;
using System.Text;
using NUnit.Framework;

namespace System.Test
{
    [TestFixture]
    public class StringBuilderTest
    {
        private StringBuilder _sut;
        [SetUp]
        public void Setup()
        {
            _sut = new StringBuilder();
        }
        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
        [Test]
        public void AppendFormatLineTest()
        {
            var expectedvalue = "test" + Environment.NewLine;
            var actualValue = _sut.AppendFormattedLine("{0:s}", "test");
            Assert.AreEqual(expectedvalue, actualValue.ToString());
        }
    }
}
