using System;
using System.Text;

namespace Encyclopedia.Model
{
    /// <summary>
    /// Represents the data in the database.
    /// </summary>
    public class Lemma
    {
        #region Private variables
        private String title;
        private byte[] body;
        private int categoryId;
        #endregion

        #region Constructors
        public Lemma(String title, Byte[] bodyInBytes, int categoryId)
        {
            Title = title;
            this.body = bodyInBytes ?? throw new ArgumentNullException(nameof(bodyInBytes));
            this.categoryId = categoryId;
        }
        #endregion

        #region Properties
        public String Title
        {
            get
            {
                return title;
            }
            set
            {
				title = value ?? throw new ArgumentNullException(nameof(title));
			}
        }
        public byte[] Body
        {
            get
            {
                return body;
            }
            set
            {
                body = value;
            }
        }
        public int Category
        {
            get
            {
                return categoryId;
            }
            set
            {
                categoryId = value;
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
