using System;

namespace Coffee.Beans.Tests.Utility
{
    [BeanObject]
    public class Player
    {
        #region Properties

        public string NickName { get; set; }
        public int? Score { get; set; }

        #endregion
    }
}
