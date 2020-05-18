namespace FbotIceChat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Moq;
    using IceChatPlugin;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class JugadorTest
    {
        //var PluginRepository = new Mock<IPluginIceChat>(MockBehavior.Strict);
        [TestMethod]
        public void Jugador_Nuevo_Ok()
        {
            #region Arrange
            var PluginRepository = new Mock<IPluginIceChat>(MockBehavior.Strict);
            #endregion

            #region Acts
            var actual = 
            #endregion

            #region Asserts
            #endregion
        }
    }
}
