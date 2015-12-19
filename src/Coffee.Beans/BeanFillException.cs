using System;

namespace Coffee.Beans
{
    public sealed class BeanFillException : BeanException
    {
        #region Constants

        private const string DefaultMessage = "Unable to fill Bean";

        #endregion


        #region Constructors

        public BeanFillException() : base() { }
        public BeanFillException(string message) : base(message) { }
        public BeanFillException(Exception inner) : base(DefaultMessage, inner) { }
        public BeanFillException(string message, Exception inner) : base(message, inner) { }

        #endregion
    }
}
