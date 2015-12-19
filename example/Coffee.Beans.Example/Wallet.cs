using System;

namespace Coffee.Beans.Example
{
    [BeanObject]
    public class Wallet
    {
        #region Properties

        [BeanProperty]
        public double Balance { get; set; }

        #endregion


        #region Methods

        public override string ToString()
        {
            return $"${Balance}";
        }

        #endregion
    }
}
