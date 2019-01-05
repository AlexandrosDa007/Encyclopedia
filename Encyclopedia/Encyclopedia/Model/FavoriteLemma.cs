﻿using System;

namespace Encyclopedia.Model
{
    public class FavoriteLemma
    {
        // fields
        private string lemmaTitle;
        private User user;
        private DateTime createdAt;

        // constructor
        public FavoriteLemma(string lemmaTitle, User user, DateTime createdAt)
        {
            Title = lemmaTitle;
            User = user;
            CreatedAt = createdAt;
        }

        // setters and getters
        public string Title
        {
            get
            {
                return lemmaTitle;
            }
            set
            {
                lemmaTitle = value ?? throw new ArgumentNullException(nameof(lemmaTitle));
			}
        }

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
