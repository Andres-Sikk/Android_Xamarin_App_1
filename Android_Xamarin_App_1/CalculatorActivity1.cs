using Android.App;
using Android.OS;
using Android.Widget;
using System;

namespace Android_Xamarin_App_1
{
    [Activity(Label = "CalculatorActivity1")]
    public class CalculatorActivity1 : Activity
    {
        EditText _calcNumber1;
        EditText _calcNumber2;
        TextView _calcAnswer;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.calculator_layout);
            _calcNumber1 = FindViewById<EditText>(Resource.Id.calcNumber1);
            _calcNumber2 = FindViewById<EditText>(Resource.Id.calcNumber2);
            _calcAnswer = FindViewById<TextView>(Resource.Id.calcAnswer);
            var calcButton = FindViewById<Button>(Resource.Id.calcButton);
            calcButton.Click += CalcAddNumbers;
        }
        private void CalcAddNumbers(object sender, EventArgs e)
        {
            _calcAnswer.Text = (int.Parse(_calcNumber1.Text) + int.Parse(_calcNumber2.Text)).ToString();
        }
    }
}