using Coffee.Beans.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Coffee.Beans
{
    public sealed class BeanInfo
    {
        #region Fields

        private BeanPolicy _policy;
        private IEnumerable<BeanProperty> _properties;

        #endregion


        #region Constructors

        public BeanInfo(Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            var attribute = type.GetCustomAttribute<BeanObjectAttribute>();
            _policy = attribute?.Policy ?? BeanPolicy.None;

            var properties = type.GetProperties();
            _properties = Filter(properties);
        }

        #endregion

        #region Constructors

        public BeanPolicy Policy
        {
            get
            {
                return _policy;
            }
        }

        public IEnumerable<BeanProperty> Properties
        {
            get
            {
                return _properties;
            }
        }

        #endregion

        #region Methods

        private IEnumerable<BeanProperty> Filter(PropertyInfo[] properties)
        {
            switch(_policy)
            {
                default:
                    return properties
                        .Select(p => new BeanProperty(p));
                case BeanPolicy.OptIn:
                    return properties
                        .Where(p => p.GetCustomAttribute<BeanPropertyAttribute>() != null)
                        .Select(p => new BeanProperty(p));
                case BeanPolicy.OptOut:
                    return properties
                        .Where(p => p.GetCustomAttribute<BeanPropertyAttribute>() == null)
                        .Select(p => new BeanProperty(p));
            }
        }

        #endregion
    }
}
