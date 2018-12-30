using System;

namespace Encyclopedia.Model
{
    public class Contact
    {
        // fields
        private User user;
        private User contact;
        private ContactGroup contactGroup;

        // default constructor
        public Contact(User user, User contact, ContactGroup contactGroup)
        {
            if (user.Id != contact.Id)
            {
                this.user = user ?? throw new ArgumentNullException(nameof(user));
                this.contact = contact ?? throw new ArgumentNullException(nameof(contact));
            }
            else
                throw new ArgumentException("The user cannot be contacts with himself.");
            ContactGroup = contactGroup ?? throw new ArgumentNullException(nameof(contactGroup));
        }

        // constructor with null values
        public Contact(User user, User contact)
        {
            if (user.Id != contact.Id)
            {
                this.user = user ?? throw new ArgumentNullException(nameof(user));
                this.contact = contact ?? throw new ArgumentNullException(nameof(contact));
            }
            else
                throw new ArgumentException("The user cannot be contacts with himself.");

            ContactGroup = null;
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

        public ContactGroup ContactGroup
        {
            get
            {
                return contactGroup;
            }
            set
            {
                contactGroup = value;
            }
        }

        // overrided ToString
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
