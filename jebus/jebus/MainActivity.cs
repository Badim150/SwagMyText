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
				String output = input.ToLower();
				output = output.Replace("hi there","sup sup,");
				output = output.Replace("hi","yo");
				output = output.Replace("man", "Swagger");
				output = output.Replace("lady", "Bitch");
				output = output.Replace("woman", "Bitch");
				output = output.Replace("cool", "swaggy");
				output = output.Replace("dude", "boy");
				output = output.Replace("bro", "mah nigah");
				output = output.Replace("I went", "i gone");
				output = output.Replace("hot", "fucking hot");
				output = output.Replace("dat ass", "THAT HOLLY ASS");
				output = output.Replace("ass", "booty");
				output = output.Replace("dad", "old man");
				output = output.Replace("mom", "nigah");
				output = output.Replace("for sure", "foh shizzlee");
				output = output.Replace("friend", "bro");
				output = output.Replace("my", "mah");
				output = output.Replace("girlfriend", "biAtch");
				output = output.Replace("girl", "gurl");
				output = output.Replace("boobs", "tyttehs");
				output = output.Replace("brother", "brah");
				output = output.Replace("sure", "shizzlee");
				output = output.Replace("teacher", "teach");
				output = output.Replace("police", "popo");
				output = output.Replace("my car", "mah ride");
				output = output.Replace("your car", "yo ride");
				output = output.Replace("hooker", "hookah");
				output = output.Replace("my car", "mah ride");
				output = output.Replace(" to ", " 2 ");
				output = output.Replace(" today ", " 2day ");
				output = output.Replace("wait", "w8");
				output = output.Replace("on my way", "OMW");
				output = output.Replace("Be right back", "BRB");
				output = output.Replace("see you", "C U");
				output = output.Replace("love", "<3");
				output = output.Replace("cya", "cya bitch");
				output = output.Replace("see ya", "cya");
				FindViewById<EditText> (Resource.Id.outputText).Text = output; 
			};
		}
	}
}

