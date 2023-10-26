using System;

using AppKit;
using Foundation;

namespace calcuApp
{
	public partial class ViewController : NSViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}
		int step = 0;
		int num1, num2;

        partial void PushButton(NSButton sender)
        {
			int num1 = Convert.ToInt16(TextInput.StringValue);
            int num2 = Convert.ToInt16(TextInput2.StringValue);
            if (selected == 0)
			{
				SetText(Convert.ToString(num1 + num2));
			}else if (selected == 1)
            {
                SetText(Convert.ToString(num1 - num2));
            }else if (selected == 2)
            {
                SetText(Convert.ToString(num1 * num2));
            }else if (selected == 3)
            {
				float num3 = (float)num1 / num2;
                SetText(Convert.ToString(num3));
            }
			TextInput.StringValue = "";
			TextInput2.StringValue = "";
		}

		private void SetText(string text)
		{
			InfoLabel.StringValue = text;
		}

		int selected = 0;

        partial void addAction(NSButton sender)
        {
            SetRadio(addOutlet);
			selected = 0;
        }

        partial void substractAction(NSButton sender)
        {
            SetRadio(substractOutlet);
			selected = 1;
        }

        partial void multiplyAction(NSButton sender)
        {
			SetRadio(multiplyOutlet);
			selected = 2;
        }

        partial void divideAction(NSButton sender)
        {
			SetRadio(divideOutlet);
			selected = 3;
        }

		public void SetRadio(NSButton selected)
		{
            substractOutlet.State = NSCellStateValue.Off;
            multiplyOutlet.State = NSCellStateValue.Off;
            addOutlet.State = NSCellStateValue.Off;
            divideOutlet.State = NSCellStateValue.Off;
			selected.State = NSCellStateValue.On;
        }
    }
}
