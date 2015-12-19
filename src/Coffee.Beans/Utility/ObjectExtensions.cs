using System;
using System.Collections.Generic;

namespace Coffee.Beans.Utility
{
    public static class ObjectExtensions
    {
        #region Methods

        public static T Fill<T>(this T instance, Dictionary<string, object> values) where T : class
        {
            return Bean.Fill<T>(instance, values);
        }

        #endregion
    }
}
