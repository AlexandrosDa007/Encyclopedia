using System;
using System.Text;

namespace Encyclopedia.Model
{
    public class Lemma
    {
        // fields
        private String title;
        private String body;
		//Changed the category to integer
		// !! It MUST be instance of Category, that's the point of MVC.
		// You can construct the object like "new Category(id, "")",
		// it doesn't really matter (even thought the main point is to preserve consistency and uphold the constraints) but it has to be type of Category.
		// Change it back whenever you can.
        private int categoryId;

        // constructor
        public Lemma(String title, Byte[] bodyInBytes, int categoryId)
        {
            Title = title;
            this.body = Encoding.UTF8.GetString(bodyInBytes) ?? throw new ArgumentNullException(nameof(bodyInBytes));
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
				title = value ?? throw new ArgumentNullException(nameof(title));
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
