using System;

namespace Encyclopedia.Model
{
    class ContactGroup
    {
        // fields
        private int id;
        private String name;
        private User owner;

        // constructor
        public ContactGroup(int id, string name, User owner)
        {
            Id = id;
            Name = name;
            Owner = owner;
        }

        // setters and getters
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

        // overrided ToString
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
