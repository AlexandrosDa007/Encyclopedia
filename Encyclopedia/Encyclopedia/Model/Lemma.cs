﻿using System;
using System.Text;

namespace Encyclopedia.Model
{
    public class Lemma
    {
        // fields
        private String title;
        private String body;
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
