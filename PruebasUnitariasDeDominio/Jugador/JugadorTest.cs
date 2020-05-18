using System;
using TVG.DOMINIO.MODEL;
using Xunit;

namespace PruebasUnitariasDeDominio.Jugador
{
    public class JugadorTest
    {
        /// <summary>
        /// Se da de alta un nick válido
        /// </summary>
        [Fact]
        public void ElNickEsValido()
        {
            //Arrange
            const string nick = "PruebaOk";
            const string nickExpect = "PruebaOk";
            var sut = new JugadorBase(nick);
            //Act
            var act = sut.Nick;
            // Assert
            Assert.NotNull(sut);
            Assert.Equal(nickExpect, act.ToString());
        }


        /// <summary>
        /// NO se puede dar de alta un nick que tenga menos del mínimo de caracteres permitidos.
        /// </summary>
        [Fact]
        public void ElNickNoPuedeSerMenorQueElMinimoPermitido()
        {
            //Arrange
            const string nick = "X";
            InvalidCastException errorExpect = null;

            //Act
            JugadorBase act = null;
            try
            {
                act = new JugadorBase(nick);
            }
            catch (InvalidCastException ix)
            {
                errorExpect = ix;
            }
            catch (Exception)
            {
                throw;
            }
            // Assert
            Assert.Null(act);
            Assert.NotNull(errorExpect);
        }

        /// <summary>
        /// NO se puede dar de alta un nick que tenga más del máximo  de caracteres permitidos.
        /// </summary>
        [Fact]
        public void ElNickNoPuedeSerMayorQueElMaximoPermitido()
        {
            //Arrange
            const string nick = "XXXXXXXXXXXXXXXXXXXXXXXXXX";
            InvalidCastException errorExpect = null;

            //Act
            JugadorBase act = null;
            try
            {
                act = new JugadorBase(nick);
            }
            catch (InvalidCastException ix)
            {
                errorExpect = ix;
            }
            catch (Exception)
            {
                throw;
            }
            // Assert
            Assert.Null(act);
            Assert.NotNull(errorExpect);
        }
    }
}
