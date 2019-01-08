using System;

namespace Encyclopedia.Model
{
    /// <summary>
    /// Represents the data in the database.
    /// </summary>
    public class ContactGroup
    {
        #region Private variables
        private int id;
        private String name;
        private User owner;
        #endregion

        #region Constructors
        public ContactGroup(int id, string name, User owner)
        {
            Id = id;
            Name = name;
            Owner = owner;
        }
        #endregion


        #region Properties
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
				name = value ?? throw new ArgumentNullException(nameof(name));
            }
        }
        public User Owner
        {
            get
            {
                return owner;
            }
            set
            {
				owner = value ?? throw new ArgumentNullException(nameof(owner));
            }
        }
        #endregion

        /// <summary>
        /// Overrides the ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
