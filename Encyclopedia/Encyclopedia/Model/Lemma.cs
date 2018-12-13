using System;
using System.Text;

namespace Encyclopedia.Model
{
    class Lemma
    {
        // fields
        private String title;
        private String body;
        private Category category;

        // constructor
        public Lemma(String title, Byte[] bodyInBytes, Category category)
        {
            this.title = title ?? throw new ArgumentNullException(nameof(title));
            this.body = Encoding.Default.GetString(bodyInBytes) ?? throw new ArgumentNullException(nameof(bodyInBytes));
            this.category = category ?? throw new ArgumentNullException(nameof(category));
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

        public Category Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        // overrided ToString
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
