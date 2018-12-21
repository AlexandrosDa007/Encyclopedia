using System;
using System.Net.Mail;

namespace Encyclopedia.Model
{
    class Account
    {
        // fields
        private User user;
        private String username;
        private String password; // Hash value
        private String email;
        private DateTime createdAt;

        // constructor
        public Account(User user, string username, string password, string email, DateTime createdAt)
        {
            this.user = user ?? throw new ArgumentNullException(nameof(user));
			if (username.Length > 40 || username.Length < 2) // the username must be at least 2 characters
			{
				throw new ArgumentOutOfRangeException(nameof(username));
			}
			else
				this.username = username ?? throw new ArgumentNullException(nameof(username));
			this.password = password ?? throw new ArgumentNullException(nameof(password));
            try
            {
                MailAddress m = new MailAddress(email); // this line will determine if the email is in valid format

                this.email = email ?? throw new ArgumentNullException(nameof(email)); // it must also be unique
            }
            catch (FormatException)
            {
                throw new ArgumentException(nameof(email));
            }
            this.createdAt = createdAt;
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
                user = value;
            }
        }

        public String Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public String Email
        {
            get
            {
                return email;
            }
            set
            {
                try
                {
                    MailAddress m = new MailAddress(value);

                    email = value;
                }
                catch (FormatException)
                {
                    throw new ArgumentException(nameof(value));
                }
            }
        }

        public DateTime CreatedAt
        {
            get
            {
                return createdAt;
            }
            set
            {
                createdAt = value;
            }
        }

        // overrided ToString
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
