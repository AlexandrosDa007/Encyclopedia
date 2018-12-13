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
            this.id = id;
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.owner = owner ?? throw new ArgumentNullException(nameof(owner));
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
                name = value;
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
                owner = value;
            }
        }

        // overrided ToString
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
