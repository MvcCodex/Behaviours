using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Samples
{
    public class ButtonValidationBehavior : Behavior<Button>
    {
       // public delegate  Button HandleBtnClicked (object sender,EventArgs e)
        static readonly BindablePropertyKey IsValidPropertyKey = BindableProperty.CreateReadOnly("IsValid", typeof(bool),
                                                                                     typeof(ButtonValidationBehavior), false);

        public static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;

        public static readonly BindableProperty CompareToEntryProperty = BindableProperty.Create("CompareToEntry", typeof(Entry),
                                                                                            typeof(PasswordValidator), null);

        public bool CompareToEntry
        {
            get { return (bool)base.GetValue(IsValidProperty); }
            private set { base.SetValue(IsValidPropertyKey, value); }
        }
        public bool IsValid
        {
            get { return (bool)base.GetValue(IsValidProperty); }
             set { base.SetValue(IsValidPropertyKey, value); }
        }

        protected override void OnAttachedTo(Button bindable)
        {
            bindable.Clicked += HandleBtnClicked;
            base.OnAttachedTo(bindable);
        }
        protected override void OnDetachingFrom(Button bindable)
        {
            bindable.Clicked -= HandleBtnClicked;
            base.OnDetachingFrom(bindable);
        }
        void HandleBtnClicked(object sender, EventArgs e)
        {
            bool naigate = false;          
            naigate = CompareToEntry;
            if (naigate)
            {
               // Navigation.PushAsync(new RegistrationFormVAlidation());
            }
        }

    }
}
