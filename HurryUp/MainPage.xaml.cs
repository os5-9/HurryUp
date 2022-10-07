using System;
using Xamarin.Forms;

namespace HurryUp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void places_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (places.SelectedIndex)
            {
                case 0:
                    roadTimePicker.Time = new TimeSpan(0, 40, 0);
                    break;
                case 1:
                    roadTimePicker.Time = new TimeSpan(1, 10, 0);
                    break;
                case 2:
                    roadTimePicker.Time = new TimeSpan(0, 30, 0);
                    break;
                case 3:
                    roadTimePicker.Time = new TimeSpan(0, 40, 0);
                    break;
            }
        }

        private void btnCalculate_Clicked(object sender, EventArgs e)
        {
            TimeSpan preparing = new TimeSpan(0, 40, 0);
            if ((needTimePicker.Time != TimeSpan.Zero) && (roadTimePicker.Time != TimeSpan.Zero))
            {
                TimeSpan startTime = needTimePicker.Time - roadTimePicker.Time - preparing;
                TimeSpan outTime = needTimePicker.Time - roadTimePicker.Time;
                answer.Text = $"Необходимо начать  собираться в {startTime} и выйти из дома в {outTime}. При условии что на сборы потребуется {preparing}";
            }
        }
    }
}
