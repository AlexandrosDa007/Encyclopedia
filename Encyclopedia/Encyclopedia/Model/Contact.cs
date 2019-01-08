using System;

namespace Encyclopedia.Model
{
    public class Contact
    {
        // fields
        private User user;
        private User contact;

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

        // setters and getters
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

        // overrided ToString
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
