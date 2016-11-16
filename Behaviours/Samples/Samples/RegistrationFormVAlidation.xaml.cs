using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Samples
{
    public partial class RegistrationFormVAlidation : ContentPage
    {
        public RegistrationFormVAlidation()
        {
            InitializeComponent();
        }
        protected async void btn_Submit(object sender, EventArgs e)
        {
           await DisplayAlert("RegistrationForm", "Registration success","OK");
        }
    }
}
