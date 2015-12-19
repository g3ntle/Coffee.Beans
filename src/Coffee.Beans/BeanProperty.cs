using System;
using System.Reflection;

namespace Coffee.Beans
{
    public sealed class BeanProperty
    {
        #region Fields

        private PropertyInfo _property;
        
        #endregion


        #region Constructors

        public BeanProperty(PropertyInfo property)
        {
            if (property == null)
                throw new ArgumentNullException("property");

            _property = property;
        }

        #endregion


        #region Properties

        public PropertyInfo Property
        {
            get
            {
                return _property;
            }
        }

        #endregion
    }
}
