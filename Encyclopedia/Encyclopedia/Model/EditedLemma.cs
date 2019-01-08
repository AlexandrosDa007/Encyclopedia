using System;
using System.Text;

namespace Encyclopedia.Model
{
    /// <summary>
    /// Represents the data in the database.
    /// </summary>
    public class EditedLemma
    {
        #region Private variables
        private string lemmaTitle;
        private User editor;
        private String editedBody;
        private DateTime createdAt;
        private DateTime updatedAt;
        #endregion

        #region Constructors
        public EditedLemma(string lemmaTitle, User editor, Byte[] editedBodyInBytes, DateTime createdAt, DateTime updatedAt)
        {
            LemmaTitle = lemmaTitle;
            Editor = editor;
            if (editedBodyInBytes == null)
                this.editedBody = null;
            else
                this.editedBody = Encoding.UTF8.GetString(editedBodyInBytes) ?? throw new ArgumentNullException(nameof(editedBodyInBytes));
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
        #endregion

        #region Properties
        public string LemmaTitle
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
        public User Editor
        {
            get
            {
                return editor;
            }
            set
            {
				editor = value ?? throw new ArgumentNullException(nameof(editor));
			}
        }
        public String Body
        {
            get
            {
                return editedBody;
            }
            set
            {
                editedBody = value;
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
        public DateTime UpdatedAt
        {
            get
            {
                return updatedAt;
            }
            set
            {
                updatedAt = value;
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
