using contactos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace contactos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NuevoContactoPage : ContentPage
	{
		public NuevoContactoPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs args)
        {
            Contacto nuevoContacto = new Contacto()
            {
                Nombre = nombreEntry.Text,
                Apellido = apellidoEntry.Text,
                Telefono = telefonoEntry.Text,
                Email = emailEntry.Text
            };

            using (var conn = new SQLite.SQLiteConnection(App.Ruta_DB))
            {
                conn.CreateTable<Contacto>();
                conn.Insert(nuevoContacto);
            }
           
        }

    }
}