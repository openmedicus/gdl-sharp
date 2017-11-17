// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdl {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class DockPaned : Gdl.DockItem {

		public DockPaned (IntPtr raw) : base(raw) {}

		[DllImport("libgdl-3-5.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdl_dock_paned_new(int orientation);

		public DockPaned (Gtk.Orientation orientation) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (DockPaned)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("orientation");
				vals.Add (new GLib.Value (orientation));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gdl_dock_paned_new((int) orientation);
		}

		[GLib.Property ("position")]
		public uint Position {
			get {
				GLib.Value val = GetProperty ("position");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("position", val);
				val.Dispose ();
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GdlDockPanedClass {
		}

		static uint class_offset = ((GLib.GType) typeof (Gdl.DockItem)).GetClassSize ();
		static Dictionary<GLib.GType, GdlDockPanedClass> class_structs;

		static GdlDockPanedClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GdlDockPanedClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GdlDockPanedClass class_struct = (GdlDockPanedClass) Marshal.PtrToStructure (class_ptr, typeof (GdlDockPanedClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GdlDockPanedClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgdl-3-5.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdl_dock_paned_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdl_dock_paned_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
