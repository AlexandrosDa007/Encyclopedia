using System;
using System.Text;

namespace Encyclopedia.Model
{
    class Lemma
    {
        // fields
        private String title;
        private String body;
        //Changed the category to integer 
        private int categoryId;

        // constructor
        public Lemma(String title, Byte[] bodyInBytes, int categoryId)
        {
            this.title = title ?? throw new ArgumentNullException(nameof(title));
            this.body = Encoding.Default.GetString(bodyInBytes) ?? throw new ArgumentNullException(nameof(bodyInBytes));
            this.categoryId = categoryId;
        }

        // setters and getters
        public String Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public String Body
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

        // overrided ToString
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
