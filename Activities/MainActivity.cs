using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Lab15.Resources.layout;

namespace Lab15
{
    [Activity(Label = "Book Inventory", MainLauncher = true)]
    public class MainActivity : Activity
    {
        // Step 2
        EditText txtEmail;
        EditText txtPassword;
        Button btnLogin;
        Button btnRegister;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        
            // Step 1
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Step 3
            txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            btnRegister = FindViewById<Button>(Resource.Id.btnRegister);

            // Step 4
            btnLogin.Click += btnLogin_Click;
            btnRegister.Click += btnRegister_Click;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(RegisterActivity));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(RegisterActivity));
        }
    }
}

