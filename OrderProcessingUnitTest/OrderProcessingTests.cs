using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessingConsoleApp;

namespace OrderProcessingUnitTest
{
    [TestClass]
    public class OrderProcessingTests
    {

        [TestMethod]
        public void ShouldReturnVideoSlipOnly()
        {
            var result = OrderProcessor.GetProductType("Random");
            Assert.AreEqual("Random", result.ItemName);
            Assert.AreEqual("Generated a packing slip.", result.Activities[0]);
            Assert.AreEqual(1, result.Activities.Count);

        }

        [TestMethod]
        public void ShouldReturnVideoLearningToSkiSlipOnly()
        {
            var result = OrderProcessor.GetProductType("video");
            Assert.AreEqual("Learning To Ski", result.ItemName);
            Assert.AreEqual("Generated a packing slip.", result.Activities[0]);
            Assert.AreEqual("'First Aid' video added to the packing slip", result.Activities[1]);
            Assert.AreEqual(2, result.Activities.Count);
        }

        [TestMethod]
        public void ShouldReturnUpgradeSlipOnly()
        {
            var result = OrderProcessor.GetProductType("Random");
            Assert.IsNull(result.ItemName);
            Assert.AreEqual("Generated a packing slip.", result.Activities[0]);
            Assert.AreEqual("Apply the upgrade", result.Activities[1]);
            Assert.AreEqual("Mail Sent", result.Activities[2]);
            Assert.AreEqual(3, result.Activities.Count);

        }

        [TestMethod]
        public void ShouldReturnMembershipSlip()
        {
            var result = OrderProcessor.GetProductType("Membership");
            Assert.IsNull(result.ItemName);
            Assert.AreEqual("Generated a packing slip.", result.Activities[0]);
            Assert.AreEqual("Activate that membership", result.Activities[1]);
            Assert.AreEqual("Mail Sent", result.Activities[2]);
            Assert.AreEqual(3, result.Activities.Count);

        }

        [TestMethod]
        public void ShouldReturnBookSlipOnly()
        {
            var result = OrderProcessor.GetProductType("Book");
            Assert.AreEqual("Random", result.ItemName);
            Assert.AreEqual("Generated a packing slip for shipping.", result.Activities[0]);
            Assert.AreEqual("Commission payment to the agent", result.Activities[1]);
            Assert.AreEqual("Create a duplicate packing slip for the royalty department.", result.Activities[2]);
            Assert.AreEqual(3, result.Activities.Count);

        }

        [TestMethod]
        public void ShouldReturnOther()
        {
            var result = OrderProcessor.GetProductType("other");
            Assert.AreEqual("Random", result.ItemName);
            Assert.AreEqual("Generated a packing slip for shipping.", result.Activities[0]);
            Assert.AreEqual("Commission payment to the agent", result.Activities[1]);
            Assert.AreEqual(2, result.Activities.Count);

            result = OrderProcessingConsoleApp.OrderProcessor.GetProductType("Random");
            Assert.AreEqual("Random", result.ItemName);
            Assert.AreEqual("Generated a packing slip for shipping.", result.Activities[0]);
            Assert.AreEqual("Commission payment to the agent", result.Activities[1]);
            Assert.AreEqual(2, result.Activities.Count);
        }
    }
}

