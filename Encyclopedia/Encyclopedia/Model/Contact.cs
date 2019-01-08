using System;

namespace Encyclopedia.Model
{
    /// <summary>
    /// Represents the data in the database.
    /// </summary>
    public class Contact
    {
        #region Private variables
        private User user;
        private User contact;
        #endregion

        #region Constructors
        // default constructor
        public Contact(User user, User contact)
        {
            if (user.Id != contact.Id)
            {
                this.user = user ?? throw new ArgumentNullException(nameof(user));
                this.contact = contact ?? throw new ArgumentNullException(nameof(contact));
            }
            else
                throw new ArgumentException("The user cannot be contacts with himself.");
        }
        #endregion

        #region Properties
        public User User
        {
            get
            {
                return user;
            }
            set
            {
                if (contact.Id != value.Id)
                {
                    user = value;
                }
                else
                    throw new ArgumentException("The user cannot be contacts with himself.");
            }
        }
        public User ContactUser
        {
            get
            {
                return contact;
            }
            set
            {
                if (user.Id != value.Id)
                {
                    contact = value;
                }
                else
                    throw new ArgumentException("The user cannot be contacts with himself.");
            }
        }
        #endregion
        

        /// <summary>
        /// Overrides ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
