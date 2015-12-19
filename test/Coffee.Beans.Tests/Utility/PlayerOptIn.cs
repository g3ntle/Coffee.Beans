using System;

namespace Coffee.Beans.Tests.Utility
{
    [BeanObject(BeanPolicy.OptIn)]
    public class PlayerOptIn : Player
    {
        [BeanProperty]
        public new int? Score { get; set; }
    }
}
