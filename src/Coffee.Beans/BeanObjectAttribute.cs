using System;

namespace Coffee.Beans
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class BeanObjectAttribute : Attribute
    {
        #region Constructors

        public BeanObjectAttribute(BeanPolicy policy = BeanPolicy.None)
        {
            Policy = policy;
        }

        #endregion


        #region Properties

        public BeanPolicy Policy { get; set; }

        #endregion
    }
}
