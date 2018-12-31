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
			// get the user's contacts
			List<User> contacts = DBConnect.GetContacts(account.User.Id);
			ListViewItem[] contactNames = new ListViewItem[contacts.Count];

			// adjust image properties
			ImageList contactImages = new ImageList();
			contactImages.ImageSize = new Size(96, 96);
			contactImages.ColorDepth = ColorDepth.Depth32Bit;
			
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
			}

			// put in the list view the items and their images
			listView.Items.AddRange(contactNames);

			listView.LargeImageList = contactImages;
		}
	}
}
