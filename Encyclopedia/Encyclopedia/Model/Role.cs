using System;

namespace Encyclopedia.Model
{
    public class Role
    {
        // fields
        private int id;
        private String name;

        // constructor
        public Role(int id, string name)
        {
            this.id = id;
            this.name = name ?? throw new ArgumentNullException(nameof(name));
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

        // overrided ToString
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
