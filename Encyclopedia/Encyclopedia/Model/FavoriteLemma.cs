using System;

namespace Encyclopedia.Model
{
    class FavoriteLemma
    {
        // fields
        private Lemma lemma;
        private User user;
        private DateTime createdAt;

        // constructor
        public FavoriteLemma(Lemma lemma, User user, DateTime createdAt)
        {
            Lemma = lemma;
            User = user;
            CreatedAt = createdAt;
        }

        // setters and getters
        public Lemma Lemma
        {
            get
            {
                return lemma;
            }
            set
            {
				lemma = value ?? throw new ArgumentNullException(nameof(lemma));
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
