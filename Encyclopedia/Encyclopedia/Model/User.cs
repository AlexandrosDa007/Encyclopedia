using System;

namespace Encyclopedia.Model
{
    class User
    {
        // fields
        private int id;
        private String name;
        private String surname;
        private DateTime dateOfBirth;
        private Char gender;
        private string tel;
        private Role role;
        private EducationLevel educationLevel;
        private String description;
        private Byte[] image;

        // default constructor
        public User(int id, string name, string surname, DateTime dateOfBirth, char gender, string tel, Role role, EducationLevel educationLevel, string description, Byte[] image)
        {
            this.id = id;
            if (name.Length > 40 || name.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(name));
            }
            else
                this.name = name ?? throw new ArgumentNullException(nameof(name));
            if (surname.Length > 50 || surname.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(surname));
            }
            else
                this.surname = surname ?? throw new ArgumentNullException(nameof(surname));
            this.dateOfBirth = dateOfBirth;
            if (gender.Equals('M') || gender.Equals('F') || gender.Equals('-'))
            {
                this.gender = gender;
            }
            else
                throw new ArgumentOutOfRangeException(nameof(gender));
            this.tel = tel;
            this.role = role;
            this.educationLevel = educationLevel;
            if (description.Length <= 250)
            {
                this.description = description;
            }
            else
                throw new ArgumentOutOfRangeException(nameof(description));
            this.image = image;
        }

        // constructor with null values
        public User(int id, string name, string surname, DateTime dateOfBirth)
        {
            this.id = id;
            if (name.Length > 40)
            {
                throw new ArgumentOutOfRangeException(nameof(name));
            }
            else
                this.name = name ?? throw new ArgumentNullException(nameof(name));
            if (surname.Length > 50)
            {
                throw new ArgumentOutOfRangeException(nameof(surname));
            }
            else
                this.surname = surname ?? throw new ArgumentNullException(nameof(surname));
            this.dateOfBirth = dateOfBirth;

            // optional fields set to null
            this.gender = '-';
            this.tel = "";
            this.role = null;
            this.educationLevel = null;
            this.description = null;
            this.image = null;
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

        public String Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }

        public Char Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value.Equals('M') || value.Equals('F'))
                {
                    gender = value;
                }
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        public String Tel
        {
            get
            {
                return tel;
            }
            set
            {
                tel = value;
            }
        }

        public Role Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }

        public EducationLevel EducationLevel
        {
            get
            {
                return educationLevel;
            }
            set
            {
                educationLevel= value;
            }
        }

        public String Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public Byte[] Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }

        // overrided ToString
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
