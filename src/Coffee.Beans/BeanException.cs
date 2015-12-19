using System;

namespace Coffee.Beans
{
    public abstract class BeanException : Exception
    {
        #region Constructors

        public BeanException() : base() { }
        public BeanException(string message) : base(message) { }
        public BeanException(string message, Exception inner) : base(message, inner) { }

        #endregion
    }
}
