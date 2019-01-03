using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Encyclopedia.Model;

namespace Encyclopedia.Controller
{
	class ContactHandler
	{
		// fills dynamically the parametered ListView
		public static void FillContacts(ListView listView, Account account)
		{
			// empty the list view
			//listView.LargeImageList = null;
			listView.Items.Clear();

			// get the user's contacts
			List<User> contacts = DBConnect.GetContacts(account.User.Id);
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
					contactImages.Images.Add(contactItem.ImageKey, Properties.Resources.default_avatar);
				}
			}

			// put in the list view the items and their images
			listView.Items.AddRange(contactNames);
			
			listView.LargeImageList = contactImages;
		}

		// fills dynamically the parametered ListView
		public static void FillGroups(ListView listView, Account account)
		{
			// empty the list view
			//listView.LargeImageList = null;
			listView.Items.Clear();

			// get the user's contact groups
			List<string> groups = DBConnect.GetContactGroups(account.User.Id);
			ListViewItem[] groupNames = new ListViewItem[groups.Count];

			// adjust image properties
			ImageList groupImages = new ImageList();
			groupImages.ImageSize = new Size(90, 90);
			groupImages.ColorDepth = ColorDepth.Depth8Bit;

			int i = 0;
			foreach (string groupName in groups)
			{
				// add contact item
				ListViewItem groupItem = new ListViewItem(groupName, i);
				groupNames[i++] = groupItem;

				// add the default image to the image list
				groupImages.Images.Add(Properties.Resources.default_group_avatar);
			}

			// put in the list view the items and their images
			listView.Items.AddRange(groupNames);

			listView.LargeImageList = groupImages;
		}
	}
}
