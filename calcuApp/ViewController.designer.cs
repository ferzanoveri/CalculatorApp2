// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace calcuApp
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton addOutlet { get; set; }

		[Outlet]
		AppKit.NSButton divideOutlet { get; set; }

		[Outlet]
		AppKit.NSTextField InfoLabel { get; set; }

		[Outlet]
		AppKit.NSButton multiplyOutlet { get; set; }

		[Outlet]
		AppKit.NSButton substractOutlet { get; set; }

		[Outlet]
		AppKit.NSTextField TextInput { get; set; }

		[Outlet]
		AppKit.NSTextField TextInput2 { get; set; }

		[Action ("addAction:")]
		partial void addAction (AppKit.NSButton sender);

		[Action ("divideAction:")]
		partial void divideAction (AppKit.NSButton sender);

		[Action ("multiplyAction:")]
		partial void multiplyAction (AppKit.NSButton sender);

		[Action ("PushButton:")]
		partial void PushButton (AppKit.NSButton sender);

		[Action ("ResetButton:")]
		partial void ResetButton (AppKit.NSButton sender);

		[Action ("substractAction:")]
		partial void substractAction (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (InfoLabel != null) {
				InfoLabel.Dispose ();
				InfoLabel = null;
			}

			if (addOutlet != null) {
				addOutlet.Dispose ();
				addOutlet = null;
			}

			if (substractOutlet != null) {
				substractOutlet.Dispose ();
				substractOutlet = null;
			}

			if (multiplyOutlet != null) {
				multiplyOutlet.Dispose ();
				multiplyOutlet = null;
			}

			if (divideOutlet != null) {
				divideOutlet.Dispose ();
				divideOutlet = null;
			}

			if (TextInput != null) {
				TextInput.Dispose ();
				TextInput = null;
			}

			if (TextInput2 != null) {
				TextInput2.Dispose ();
				TextInput2 = null;
			}
		}
	}
}
