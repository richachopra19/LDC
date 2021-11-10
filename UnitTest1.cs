using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProcessStringRC;

namespace RichaSampleTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void WhenAllOk()
        {
            //Arrange
            string userInput = "AAAc91%cWwWkLq$1ci3_848v3d__K";
            string expectedVal = "Ac91%cWwWkLq£1c";
            ProcessString processString = new ProcessString();

            //Act
            processString.FormatString(userInput, out string processedVal);

            //Assert
            Assert.IsNotNull(processedVal);
            Assert.AreEqual(expectedVal,processedVal);
        }
    }
}
