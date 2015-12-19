using System;

namespace Coffee.Beans
{
    public sealed class BeanLoadException : BeanException
    {
        #region Constants

        private const string DefaultMessage = "Unable to load Bean";

        #endregion


        #region Constructors

        public BeanLoadException() : base() { }
        public BeanLoadException(string message) : base(message) { }
        public BeanLoadException(Exception inner) : base(DefaultMessage, inner) { }
        public BeanLoadException(string message, Exception inner) : base(message, inner) { }

        #endregion
    }
}
