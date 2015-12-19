using System;

namespace Coffee.Beans.Tests.Utility
{
    [BeanObject(BeanPolicy.OptOut)]
    public class PlayerOptOut : Player
    {
        [BeanProperty]
        public new string NickName { get; set; }
    }
}
