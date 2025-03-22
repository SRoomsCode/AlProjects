using Removeduplicatesnamespace;

namespace ConsoleAppRemoveDuplicate.Tests
{
    [TestClass]
    public class RemoveDuplicatesTest
    {
        [TestMethod]
        public void TestRemoveDuplicates()
        {
            ListProcessor listProcessor = new ListProcessor();
            listProcessor.ProcessList();
            
            // Arrange
            // var removeDuplicates = new RemoveDuplicates();
            // var input = new int[] { 1, 2, 2, 3, 4, 4, 5 };
            // var expected = new int[] { 1, 2, 3, 4, 5 };

            // Act
            // var result = removeDuplicates.Remove(input);

            // Assert
            // CollectionAssert.AreEqual(expected, result);
        }
    }

    internal class TestMethodAttribute : Attribute
    {
    }

    internal class TestClassAttribute : Attribute
    {
    }
}
