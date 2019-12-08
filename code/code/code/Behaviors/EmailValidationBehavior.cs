using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace code.Behaviors
{
    public class EmailValidationBehavior : Behavior<Entry>
    {
        const string emailRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";


        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += HandleTextChanged;
            base.OnAttachedTo(bindable);
        }

        void HandleTextChanged(object sender, TextChangedEventArgs e)
        {
            bool IsValid = false;
            IsValid = (Regex.IsMatch(e.NewTextValue, emailRegex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)));
            ((Entry)sender).TextColor = IsValid ? Color.Default : Color.Red;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= HandleTextChanged;
            base.OnDetachingFrom(bindable);
        }
    }
}

