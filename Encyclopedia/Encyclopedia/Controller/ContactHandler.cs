using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Encyclopedia.Model;

namespace Encyclopedia.Controller
{
	class ContactHandler
	{
		// fills dynamically the parametered ListView with the user's contacts
		public static void FillContacts(ListView listView, List<User> contacts)
		{
			// empty the listview
			//listView.LargeImageList = null;
			listView.Items.Clear();

			// initialize the listview item array
			ListViewItem[] contactNames = new ListViewItem[contacts.Count];

			// adjust image properties
			ImageList contactImages = new ImageList();
			contactImages.ImageSize = new Size(96, 96);
			contactImages.ColorDepth = ColorDepth.Depth16Bit;
			
			int i = 0;
			foreach (User contact in contacts)
			{
				// add contact item
				ListViewItem contactItem = new ListViewItem(contact.Name + " " + contact.Surname);
				contactItem.ImageKey = contactItem.Text;
				contactNames[i++] = contactItem;

				// if an image is specified, add it to the image list
				if (contact.Image != null)
				{
					MemoryStream ms = new MemoryStream(contact.Image);
					contactImages.Images.Add(contactItem.ImageKey, Image.FromStream(ms));
				}
				else
				{
					// otherwise add the default avatar image to the image list
					contactImages.Images.Add(contactItem.ImageKey, Properties.Resources.default_avatar);
				}
			}

			// put in the listview the items and their images
			listView.Items.AddRange(contactNames);
			
			listView.LargeImageList = contactImages;
		}

		// fills dynamically the parametered ListView with the user's contact groups
		public static void FillGroups(ListView listView, List<ContactGroup> groups)
		{
			// empty the listview
			//listView.LargeImageList = null;
			listView.Items.Clear();
			
			// initialize the listview item array
			ListViewItem[] groupNames = new ListViewItem[groups.Count];

			// adjust image properties
			ImageList groupImages = new ImageList();
			groupImages.ImageSize = new Size(90, 90);
			groupImages.ColorDepth = ColorDepth.Depth8Bit;

			int i = 0;
			foreach (ContactGroup group in groups)
			{
				// add group item
				ListViewItem groupItem = new ListViewItem(group.Name, i);
				groupNames[i++] = groupItem;

				// add the default group image to the image list
				groupImages.Images.Add(Properties.Resources.default_group_avatar);
			}

			// put in the listview the items and their images
			listView.Items.AddRange(groupNames);

			listView.LargeImageList = groupImages;
		}

		// fills dynamically the parametered ListView with the matching user accounts based on the search string provided
		public static void FillContactSearchResults(ListView listView, string searchString)
		{
			// empty the listview
			listView.Items.Clear();

			// get the matching user accounts
			List<Account> matchingAccounts = DBConnect.GetSearchMatchingAccounts(searchString);
			
			foreach (Account account in matchingAccounts)
			{
				// add user account item name and surname
				ListViewItem accountItem = listView.Items.Add(account.User.Name + " " + account.User.Surname);
				accountItem.UseItemStyleForSubItems = false;

				// add user account subitem username
				ListViewItem.ListViewSubItem accountSubItem = accountItem.SubItems.Add(account.Username);
				accountSubItem.ForeColor = Color.LightSlateGray;
				accountSubItem.Font = new Font("Century Gothic", 12, FontStyle.Regular);

				// add user account subitem email
				accountSubItem = accountItem.SubItems.Add(account.Email);
				accountSubItem.ForeColor = Color.LightSlateGray;
				accountSubItem.Font = new Font("Century Gothic", 12, FontStyle.Regular);
			}
		}
	}
}
