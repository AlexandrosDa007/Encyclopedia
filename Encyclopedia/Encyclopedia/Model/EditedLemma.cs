using System;
using System.Text;

namespace Encyclopedia.Model
{
    class EditedLemma
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
            this.originalLemma = originalLemma ?? throw new ArgumentNullException(nameof(originalLemma));
            this.editor = editor ?? throw new ArgumentNullException(nameof(editor));
            this.editedBody = Encoding.Default.GetString(editedBodyInBytes) ?? throw new ArgumentNullException(nameof(editedBodyInBytes));
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
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
                originalLemma = value;
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
                editor = value;
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
