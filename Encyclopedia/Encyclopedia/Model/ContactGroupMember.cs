using System;

namespace Encyclopedia.Model
{
	/// <summary>
	/// Represents the data in the database.
	/// </summary>
	public class ContactGroupMember
	{
		#region Private variables
		private ContactGroup group;
		private User contact;
		#endregion

		#region Constructors
		public ContactGroupMember(ContactGroup group, User contact)
		{
			Group = group;
			Contact = contact;
		}
		#endregion

		#region Properties
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
