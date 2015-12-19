using System;
using System.Collections.Generic;

namespace Coffee.Beans
{
    public sealed class Bean
    {
        #region Fields

        private Type type;
        private BeanInfo info;

        #endregion


        #region Constructors

        private Bean(Type type)
        {
            if (type == null)
                throw new BeanLoadException(new ArgumentNullException("type"));

            this.type = type;

            Initialize();
        }

        #endregion


        #region Methods

        private void Initialize()
        {
            try
            {
                info = new BeanInfo(type);
            }
            catch(Exception ex)
            {
                throw new BeanLoadException(ex);
            }
        }

        public object GetResult(object target, Dictionary<string, object> values)
        {
            try
            {
                if (values == null)
                    throw new ArgumentNullException("values");

                target = target ?? Activator.CreateInstance(type);

                foreach(var property in info.Properties)
                {
                    var info = property.Property;
                    var type = info.PropertyType;

                    string key = property.Property.Name;

                    object value;
                    values.TryGetValue(key, out value);

                    if (type.IsClass && value is Dictionary<string, object>)
                        info.SetValue(target, Fill(type, value as Dictionary<string, object>));
                    else
                        info.SetValue(target, value);
                }

                return target;
            }
            catch(Exception ex)
            {
                throw new BeanFillException(ex);
            }
        }

        public static object Fill(Type type, Dictionary<string, object> values)
        {
            return new Bean(type).GetResult(null, values);
        }

        public static T Fill<T>(T target, Dictionary<string, object> values) where T : class
        {
            return (T)new Bean(typeof(T)).GetResult(target, values);
        }

        public static T Fill<T>(Dictionary<string, object> values) where T : class
        {
            return Fill<T>(null, values);
        }

        #endregion
    }
}
