using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MySqlConnector;
namespace sql
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
      
        }
       

        private void b_login_Clicked(object sender, EventArgs e)
        {
            var koneksi = new MySqlConnection(Properties.Resources.db_con);

            koneksi.Open();

            var cmd = new MySqlCommand("select * from pengguna where email='"+ t_email.Text+"' and password='"+ t_password.Text + "'",koneksi);
            var rd = cmd.ExecuteReader();   

            if(rd.Read()) 
            {
                DisplayAlert("information","login success","OK");
            }
            else
            {
                DisplayAlert("warning","login data not found","ok");
            }
        }
    }
}
