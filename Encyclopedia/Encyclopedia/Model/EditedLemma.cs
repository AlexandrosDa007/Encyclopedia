using System;
using System.Text;

namespace Encyclopedia.Model
{
    public class EditedLemma
    {
        // fields
        private Lemma originalLemma;
        private User editor;
        private String editedBody;
        private DateTime createdAt;
        private DateTime updatedAt;

        // constructor
        public EditedLemma(Lemma originalLemma, User editor, Byte[] editedBodyInBytes, DateTime createdAt, DateTime updatedAt)
        {
            OriginalLemma = originalLemma;
            Editor = editor;
            this.editedBody = Encoding.UTF8.GetString(editedBodyInBytes) ?? throw new ArgumentNullException(nameof(editedBodyInBytes));
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        // setters and getters
        public Lemma OriginalLemma
        {
            get
            {
                return originalLemma;
            }
            set
            {
				originalLemma = value ?? throw new ArgumentNullException(nameof(originalLemma));
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

        // overrided ToString
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
