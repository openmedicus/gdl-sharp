// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdl {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gdl.DockBarStyleGType))]
	public enum DockBarStyle {

		Icons,
		Text,
		Both,
		Auto,
	}

	internal class DockBarStyleGType {
		[DllImport ("libgdl-3-5.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdl_dock_bar_style_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdl_dock_bar_style_get_type ());
			}
		}
	}
#endregion
}
