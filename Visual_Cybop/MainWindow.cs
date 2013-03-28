using System;
using Gtk;
using Cairo;
using Visual_Cybop;

using System.Runtime.Remoting.Contexts;
using System.Collections.Generic;

public partial class MainWindow: Gtk.Window
{	
	List<Modell> list = null;
	int movingItemIndex = -1;
	PointD tempMousPos = new PointD(-1,-1);

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		list = new List<Modell>();
		
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnDrawMainButtonPressEvent (object o, ButtonPressEventArgs args)
	{
        label1.Text = string.Format("X: {0} Y: {1}", args.Event.X, args.Event.Y);
		int index = IsOnElement(args.Event.X,args.Event.Y);
		if (index > -1) {
			label3.Text = "Drin!";
			tempMousPos.X = args.Event.X - list[index].PosX;
			tempMousPos.Y = args.Event.Y - list[index].PosY;
			StartDragDrop(index);
		}
		else
		{
			label3.Text = "Draußen =(";
		}
	}

	protected void OnDrawMainButtonReleaseEvent (object o, ButtonReleaseEventArgs args)
	{
		EndDragDrop(args.Event.X, args.Event.Y);
	}

	private void StartDragDrop(int index)
	{
		movingItemIndex = index;
	}

	private void EndDragDrop(double x, double y)
	{
		if (movingItemIndex > -1) {
			list.Add(new Modell(x - tempMousPos.X, y - tempMousPos.Y, list[movingItemIndex].Width, list[movingItemIndex].Height));
			list.RemoveAt(movingItemIndex);
		}
		movingItemIndex = -1;
		Redraw();
	}

	private void DrawRectangle (Modell modell)
	{
		DrawRectangle(modell.PosX, modell.PosY, modell.Width, modell.Height);
	}

	private void DrawRectangle (double posX, double posY, double width, double height)
	{
		Cairo.Context cr =  Gdk.CairoHelper.Create(DrawMain.GdkWindow);
		
		cr.LineWidth = 1;
		cr.SetSourceRGB(0.7, 0.2, 0.0);
		
		//int width, height;
		//width = Allocation.Width;
		//height = Allocation.Height;

		Cairo.PointD pd = new PointD(posX,posY);
		cr.Rectangle(pd, width, height);



		//cr.Arc(0, 0, (width < height ? width : height) / 2 - 10, 0, 2*Math.PI);
		cr.StrokePreserve();
		
		cr.SetSourceRGB(0.3, 0.4, 0.6);
		cr.Fill();
	}

	private int IsOnElement (double x, double y)
	{
        
		int index = -1;
		foreach (Modell modell in list) {
			if ((x > modell.PosX && y > modell.PosY) && (x < modell.PosX + modell.Width && y < modell.PosY + modell.Height))
            {
				index = list.IndexOf(modell);
			}
		}
		return index;
	}

	protected void OnDrawMainMotionNotifyEvent (object o, MotionNotifyEventArgs args)
	{
		label2.Text = string.Format("X: {0} Y: {1}", args.Event.X, args.Event.Y);
	}

	protected void OnBtnAddRectClicked (object sender, EventArgs e)
	{
		list.Add(new Modell(10, 10, 50, 50));
		Redraw();
	}

	private void Redraw()
	{
		DrawMain.GdkWindow.Clear();
		foreach (Modell modell in list) {
			DrawRectangle(modell);
		}
	}

	protected void OnDrawMainExposeEvent (object o, ExposeEventArgs args)
	{
		Redraw();
	}
}
