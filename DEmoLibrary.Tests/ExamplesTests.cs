using System;
using Xunit;

namespace DemoLibrary.Tests
{
    public class ExamplesTests
    {
        [Fact]
        public void ExampleLoadTextFile_ValidNameShouldWork()
        {
            string actual = Examples.ExampleLoadTextFile("This is a valid name");

            Assert.True(actual.Length > 0);
        }

        [Fact]
        public void ExampleLoadTextFile_InValidNameShouldWork()
        {
            Assert.Throws <ArgumentException> (
                "file",
                () => Examples.ExampleLoadTextFile(""));
        }
    }
}
