using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public static string input;
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
            displayForecast();
            input = locationInput.Text;
        }
        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            currentDateLabel.Text = Form1.days[0].date;
            tempLabel.Text = $"°{Form1.days[0].currentTemp}";
            minOutput.Text = $"°{Form1.days[0].tempLow}";
            maxOutput.Text = $"°{Form1.days[0].tempHigh}";
            Conditions();
        }

        public void displayForecast()
        {

            date1.Text = Form1.days[1].date;
            min1.Text = $"°{Form1.days[1].tempLow}";
            max1.Text = $"°{ Form1.days[1].tempHigh}";

            date2.Text = Form1.days[2].date;
            min2.Text = $"°{Form1.days[2].tempLow}";
            max2.Text = $"°{Form1.days[2].tempHigh}";
        }

        //A method for all the weather conditions
        private void Conditions()
        {
            #region Clear
            if (Form1.days[0].condition == 800)
            {
                icon.Image = Properties.Resources.ClearSky;
            }
            #endregion
            #region Clouds
            else if (Form1.days[0].condition == 801)
            {
                icon.Image = Properties.Resources.FewClouds;
            }
            else if (Form1.days[0].condition == 803)
            {
                icon.Image = Properties.Resources.BrokenClouds;
            }
            else if (Form1.days[0].condition == 804)
            {
                icon.Image = Properties.Resources.BrokenClouds;
            }
            #endregion
            #region Thunderstorm
            if (Form1.days[0].condition == 200)
            {
                icon.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[0].condition == 201)
            {
                icon.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[0].condition == 202)
            {
                icon.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[0].condition == 210)
            {
                icon.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[0].condition == 211)
            {
                icon.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[0].condition == 212)
            {
                icon.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[0].condition == 221)
            {
                icon.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[0].condition == 230)
            {
                icon.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[0].condition == 231)
            {
                icon.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[0].condition == 232)
            {
                icon.Image = Properties.Resources.Thunderstorm;
            }
            #endregion
            #region Drizzle
            if (Form1.days[0].condition == 300)
            {
                icon.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[0].condition == 301)
            {
                icon.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[0].condition == 302)
            {
                icon.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[0].condition == 310)
            {
                icon.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[0].condition == 311)
            {
                icon.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[0].condition == 312)
            {
                icon.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[0].condition == 313)
            {
                icon.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[0].condition == 314)
            {
                icon.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[0].condition == 321)
            {
                icon.Image = Properties.Resources.ShowerRain;
            }
            #endregion
            #region Rain
            if (Form1.days[0].condition == 500)
            {
                icon.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[0].condition == 501)
            {
                icon.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[0].condition == 502)
            {
                icon.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[0].condition == 503)
            {
                icon.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[0].condition == 504)
            {
                icon.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[0].condition == 511)
            {
                icon.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[0].condition == 520)
            {
                icon.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[0].condition == 521)
            {
                icon.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[0].condition == 522)
            {
                icon.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[0].condition == 531)
            {
                icon.Image = Properties.Resources.Rain;
            }
            #endregion
            #region Snow
            if (Form1.days[0].condition == 600)
            {
                icon.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[0].condition == 601)
            {
                icon.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[0].condition == 602)
            {
                icon.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[0].condition == 611)
            {
                icon.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[0].condition == 612)
            {
                icon.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[0].condition == 613)
            {
                icon.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[0].condition == 615)
            {
                icon.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[0].condition == 616)
            {
                icon.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[0].condition == 620)
            {
                icon.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[0].condition == 621)
            {
                icon.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[0].condition == 622)
            {
                icon.Image = Properties.Resources.Snow;
            }
            #endregion
            #region Mist
            if (Form1.days[0].condition == 701)
            {
                icon.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[0].condition == 711)
            {
                icon.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[0].condition == 721)
            {
                icon.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[0].condition == 731)
            {
                icon.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[0].condition == 741)
            {
                icon.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[0].condition == 751)
            {
                icon.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[0].condition == 761)
            {
                icon.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[0].condition == 762)
            {
                icon.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[0].condition == 771)
            {
                icon.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[0].condition == 781)
            {
                icon.Image = Properties.Resources.Mist;
            }
            #endregion
        }
    }
}
