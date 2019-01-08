using System;

namespace Encyclopedia.Model
{
    /// <summary>
    /// Represents the data in the database.
    /// </summary>
    public class FavoriteLemma
    {
        #region Private variables
        private string lemmaTitle;
        private User user;
        private DateTime createdAt;
        #endregion

        #region Constructors
        public FavoriteLemma(string lemmaTitle, User user, DateTime createdAt)
        {
            Title = lemmaTitle;
            User = user;
            CreatedAt = createdAt;
        }
        #endregion

        #region Properties
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
        #endregion

        /// <summary>
        /// Overrides the ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
