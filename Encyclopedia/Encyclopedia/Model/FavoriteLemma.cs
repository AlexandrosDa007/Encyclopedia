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
            this.lemma = lemma ?? throw new ArgumentNullException(nameof(lemma));
            this.user = user ?? throw new ArgumentNullException(nameof(user));
            this.createdAt = createdAt;
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
                lemma = value;
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
                user = value;
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
