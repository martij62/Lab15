using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Lab15.Resources.layout
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {

        EditText txtEmail;
        EditText txtPassword;
        Button btnRegister;
        EditText txtConfirmPassword;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Register);

            txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            btnRegister = FindViewById<Button>(Resource.Id.btnRegister);
            txtConfirmPassword = FindViewById<EditText>(Resource.Id.txtConfirmPassword);
        }
    }
}