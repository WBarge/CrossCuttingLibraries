using System.Text;
using CrossCutting.Extensions;
using FluentAssertions;

namespace CrossCutting.Tests.Extensions
{
    [TestFixture, Description("ByteExtensions tests")]
    public class ByteExtensionsTests
    {
        [Test,Description("Test byte array to a string")]
        public void FromArrayToString_ValidValue_Success()
        {
            const string TEST_VALUE = "testValue";
            byte[] testData = Encoding.Unicode.GetBytes(TEST_VALUE);
            string result = testData.FromArrayToString();
            result.Should().BeEquivalentTo(TEST_VALUE);
        }
    }
}