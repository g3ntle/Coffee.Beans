using System;

namespace Coffee.Beans.Example
{
    [BeanObject]
    public sealed class Person
    {
        #region Properties

        [BeanProperty]
        public string FirstName { get; set; }
        [BeanProperty]
        public string LastName { get; set; }
        [BeanProperty]
        public int Age { get; set; }
        [BeanProperty]
        public Wallet Wallet { get; set; }

        #endregion


        #region Methods

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age} {Wallet}";
        }

        #endregion
    }
}
