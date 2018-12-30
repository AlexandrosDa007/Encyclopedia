using System;
using System.Linq;

namespace Encyclopedia.Model
{
    public class User
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
        private byte[] image;

        // default constructor
        public User(int id, string name, string surname, DateTime dateOfBirth, char gender, string tel, Role role, EducationLevel educationLevel, string description, byte[] image)
        {
			Id = id;
			Name = name;
			Surname = surname;
			DateOfBirth = dateOfBirth;
			Gender = gender;
            Tel = tel;
            Role = role;
            EducationLevel = educationLevel;
			Description = description;
            Image = image;
        }

        // constructor with null values
        public User(int id, string name, string surname, DateTime dateOfBirth)
        {
            Id = id;
			Name = name;
			Surname = surname;
            DateOfBirth = dateOfBirth;

            // optional fields set to null
            Gender = '-';
            Tel = "";
            Role = null;
            EducationLevel = null;
            Description = "";
            Image = null;
        }

		public User(int id, string name, string surname, DateTime dateOfBirth, byte[] image)
		{
			Id = id;
			Name = name;
			Surname = surname;
			DateOfBirth = dateOfBirth;

			// optional fields set to null
			Gender = '-';
			Tel = "";
			Role = null;
			EducationLevel = null;
			Description = "";

			Image = image;
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
				if (value.Length > 40 || value.Length == 0)
				{
					throw new ArgumentOutOfRangeException(nameof(name));
				}
				else
					name = value ?? throw new ArgumentNullException(nameof(name));
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
				if (value.Length > 50 || value.Length == 0)
				{
					throw new ArgumentOutOfRangeException(nameof(surname));
				}
				else
					surname = value ?? throw new ArgumentNullException(nameof(surname));
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
				if (value.Equals('M') || value.Equals('F') || value.Equals('-'))
				{
					gender = value;
				}
				else
					throw new ArgumentOutOfRangeException(nameof(gender));
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
				if (value.Length != 10 || !value.All(char.IsNumber))
				{
					tel = "__________";
				}
				else
					tel = value ?? throw new ArgumentNullException(nameof(tel));
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
				if (value.Length <= 250)
				{
					description = value;
				}
				else
					throw new ArgumentOutOfRangeException(nameof(description));
            }
        }

        public byte[] Image
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
