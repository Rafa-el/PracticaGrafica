using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();

	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void presionar (object sender, EventArgs e)
	{
		if (pass.Text.Trim() == "practica") {
			MessageDialog dialogo;
			dialogo = new MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Bienvenido");
			dialogo.Run();
			dialogo.Destroy();

		} else {

			MessageDialog dialogo;
			dialogo = new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Contraseña invalida");
			dialogo.Run();
			dialogo.Destroy();

		}
	}

}
