
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.DrawingArea DrawMain;
	private global::Gtk.Label label2;
	private global::Gtk.Label label1;
	private global::Gtk.Label label3;
	private global::Gtk.Button btn_AddRect;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.DrawMain = new global::Gtk.DrawingArea ();
		this.DrawMain.WidthRequest = 500;
		this.DrawMain.HeightRequest = 500;
		this.DrawMain.Events = ((global::Gdk.EventMask)(774));
		this.DrawMain.Name = "DrawMain";
		this.fixed1.Add (this.DrawMain);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.DrawMain]));
		w1.X = 17;
		w1.Y = 17;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("label2");
		this.fixed1.Add (this.label2);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label2]));
		w2.X = 535;
		w2.Y = 20;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
		this.fixed1.Add (this.label1);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label1]));
		w3.X = 534;
		w3.Y = 42;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("label2");
		this.fixed1.Add (this.label3);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label3]));
		w4.X = 534;
		w4.Y = 64;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btn_AddRect = new global::Gtk.Button ();
		this.btn_AddRect.CanFocus = true;
		this.btn_AddRect.Events = ((global::Gdk.EventMask)(256));
		this.btn_AddRect.Name = "btn_AddRect";
		this.btn_AddRect.UseUnderline = true;
		this.btn_AddRect.Label = global::Mono.Unix.Catalog.GetString ("Add Rectangle");
		this.fixed1.Add (this.btn_AddRect);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btn_AddRect]));
		w5.X = 522;
		w5.Y = 114;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 656;
		this.DefaultHeight = 517;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.DrawMain.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnDrawMainButtonPressEvent);
		this.DrawMain.MotionNotifyEvent += new global::Gtk.MotionNotifyEventHandler (this.OnDrawMainMotionNotifyEvent);
		this.DrawMain.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnDrawMainButtonReleaseEvent);
		this.DrawMain.ExposeEvent += new global::Gtk.ExposeEventHandler (this.OnDrawMainExposeEvent);
		this.btn_AddRect.Clicked += new global::System.EventHandler (this.OnBtnAddRectClicked);
	}
}
