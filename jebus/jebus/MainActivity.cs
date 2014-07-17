using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace jebus
{
	[Activity (Label = "jebus", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			button.Click += delegate {
				String input = FindViewById<AutoCompleteTextView> (Resource.Id.inputText).Text;
				String output = input.Replace("hi there","sup sup");
				output = output.Replace("hi","yo");
				output = output.Replace("man", "Swagger");
				output = output.Replace("girl", "bitch");
				output = output.Replace("lady", "bitch");
				output = output.Replace("woman", "bitch");
				output = output.Replace("cool", "swaggy");
				output = output.Replace("dude", "nigger");
				FindViewById<EditText> (Resource.Id.outputText).Text = output; 
			};
		}
	}
}

