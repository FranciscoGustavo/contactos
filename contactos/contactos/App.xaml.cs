using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace contactos
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new contactos.MainPage();
		}

        public static string Ruta_DB;

        public App(String ruta_id)
        {
            InitializeComponent();

            MainPage = new contactos.MainPage();

            Ruta_DB = ruta_id;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
