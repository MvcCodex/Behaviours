using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Samples
{
    public partial class Validationform : ContentPage
    {
        ButtonValidationBehavior btnb = null;
        public Validationform()
        {
            InitializeComponent();
            //btnb = new Samples.ButtonValidationBehavior();
         
        }

        protected void btn_Submit(object sender, EventArgs e)
        {
            bool naigate = false;
            naigate = ConfirmpwdValidator.IsValid && pwdValidator.IsValid;
            if (naigate)
            {
                Navigation.PushAsync(new RegistrationFormVAlidation());
            }
           
        }
    }
}
