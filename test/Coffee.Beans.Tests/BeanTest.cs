using Coffee.Beans.Tests.Utility;
using Coffee.Beans.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Coffee.Beans.Tests
{
    [TestClass]
    public class BeanTest
    {
        #region Fields

        private Dictionary<string, object> values;

        #endregion


        #region Methods

        [TestInitialize]
        public void Initialize()
        {
            values = new Dictionary<string, object>()
            {
                { "NickName", "John" },
                { "Score", 1337 }
            };
        }

        [TestMethod]
        public void ShouldFill()
        {
            var player = Bean.Fill<Player>(values);

            Assert.AreEqual("John", player.NickName, "NickName should be John");
            Assert.AreEqual(1337, player.Score, "Score should be 1337");
        }

        [TestMethod]
        public void ShouldOptIn()
        {
            var player = Bean.Fill<PlayerOptIn>(values);

            Assert.AreEqual(1337, player.Score, "Score should be 1337");
            Assert.AreEqual(null, player.NickName, "NickName should be null");
        }

        [TestMethod]
        public void ShouldOptOut()
        {
            var player = Bean.Fill<PlayerOptOut>(values);

            Assert.AreEqual(1337, player.Score, "Score should be 1337");
            Assert.AreEqual(null, player.NickName, "NickName should be null");
        }

        #endregion
    }
}
