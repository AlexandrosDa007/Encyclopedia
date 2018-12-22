using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encyclopedia.Model;
using System.Windows.Forms;

namespace Encyclopedia.Controller
{
	class DynamicUIControlsHandler
	{
		// fills dynamically the parametered ComboBox
		public static void FillEducationLevels(ComboBox comboBox)
		{
			comboBox.Items.Clear();
			String[] educationLevelArray = DBConnect.GetEducationLevels();

			comboBox.Items.AddRange(educationLevelArray);
		}

		// fills dynamically the parametered ComboBox
		public static void FillRoles(ComboBox comboBox)
		{
			comboBox.Items.Clear();
			String[] roleArray = DBConnect.GetRoles();

			comboBox.Items.AddRange(roleArray);
		}
	}
}
