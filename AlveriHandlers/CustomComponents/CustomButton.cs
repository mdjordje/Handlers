using System;
using System.ComponentModel;
using Microsoft.Maui.Controls.Platform;

namespace AlveriHandlers.CustomComponents
{
    public class CustomButton : View
    {
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(CustomButton), "");

        //public CustomButton(Context context) : base() { }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
    }
}

