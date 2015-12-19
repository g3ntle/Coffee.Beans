using System;

namespace Coffee.Beans
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class BeanPropertyAttribute : Attribute
    {
        #region Constructors

        public BeanPropertyAttribute() { }

        #endregion
    }
}
