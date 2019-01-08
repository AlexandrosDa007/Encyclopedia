using System;

namespace Encyclopedia.Model
{
    /// <summary>
    /// Represents the data in the database.
    /// </summary>
    public class EducationLevel
    {
        #region Private variables
        private int id;
        private String name;
        #endregion

        #region Constructors
        public EducationLevel(int id, string name)
        {
            Id = id;
            Name = name;
        }
        #endregion

        #region Properties
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
				name = value ?? throw new ArgumentNullException(nameof(name));
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
