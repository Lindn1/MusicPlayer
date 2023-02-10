using System.Windows.Forms;

namespace MusikSpelare_Cskarp
{
	internal class DoubleClickButton : Button
	{
		public DoubleClickButton()
		{
			SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
		}
	}
}
