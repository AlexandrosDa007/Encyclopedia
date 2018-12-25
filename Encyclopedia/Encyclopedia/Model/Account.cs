using System;
using System.Net.Mail;

namespace Encyclopedia.Model
{
    class Account
    {
        // fields
        private User user;
        private String username;
        private String saltedPasswordHash; // Hash value
		private String passwordSalt;
		private String email;
        private DateTime createdAt;

        // constructor
        public Account(User user, string username, string saltedPasswordHash, string passwordSalt, string email, DateTime createdAt)
        {
            User = user;
			Username = username;
			SaltedPasswordHash = saltedPasswordHash;
			PasswordSalt = passwordSalt;
			Email = email;
            CreatedAt = createdAt;
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
				user = value ?? throw new ArgumentNullException(nameof(user));
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
				if (value.Length > 40 || value.Length < 2) // the username must be at least 2 characters
				{
					throw new ArgumentOutOfRangeException(nameof(username));
				}
				else
					username = value ?? throw new ArgumentNullException(nameof(username));
            }
        }

        public String SaltedPasswordHash
		{
            get
            {
                return saltedPasswordHash;
            }
            set
            {
				if (value.Length != 64)
				{
					throw new ArgumentOutOfRangeException(nameof(saltedPasswordHash));
				}
				else
					saltedPasswordHash = value ?? throw new ArgumentNullException(nameof(saltedPasswordHash));
            }
        }

		public String PasswordSalt
		{
			get
			{
				return passwordSalt;
			}
			set
			{
				if (value.Length != 24)
				{
					throw new ArgumentOutOfRangeException(nameof(passwordSalt));
				}
				else
					passwordSalt = value ?? throw new ArgumentNullException(nameof(passwordSalt));
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
				MailAddress m = new MailAddress(value); // this line will determine if the email is in valid format

				email = value ?? throw new ArgumentNullException(nameof(email));
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
