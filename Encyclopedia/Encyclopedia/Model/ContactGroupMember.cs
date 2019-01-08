using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encyclopedia.Model
{
	class ContactGroupMember
	{
		// fields
		private ContactGroup group;
		private User contact;

		// constructor
		public ContactGroupMember(ContactGroup group, User contact)
		{
			Group = group;
			Contact = contact;
		}

		// setters and getters
		public ContactGroup Group
		{
			get
			{
				return group;
			}
			set
			{
				group = value ?? throw new ArgumentNullException(nameof(group));
			}
		}

		public User Contact
		{
			get
			{
				return contact;
			}
			set
			{
				contact = value ?? throw new ArgumentNullException(nameof(contact));
			}
		}

		// overrided ToString
		public override string ToString()
		{
			return base.ToString();
		}
	}
}
