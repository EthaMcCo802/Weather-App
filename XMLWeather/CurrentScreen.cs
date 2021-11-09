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
        //Global variables
        public static string input;
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
            displayForecast();
        }
        public void DisplayCurrent()
        {
            //Displays the current weather forecast from the api
            cityOutput.Text = Form1.days[0].location;
            currentDateLabel.Text = Form1.days[0].date;
            tempLabel.Text = $"{Form1.days[0].currentTemp}°";
            minOutput.Text = $"{Form1.days[0].tempLow}°";
            maxOutput.Text = $"{Form1.days[0].tempHigh}°";
            //Displays the weather conditions
            Conditions();
        }

        public void displayForecast()
        {
            //Displays the upcoming weather forecast
            date1.Text = Form1.days[1].date;
            min1.Text = $"{Form1.days[1].tempLow}°";
            max1.Text = $"{ Form1.days[1].tempHigh}°";

            date2.Text = Form1.days[2].date;
            min2.Text = $"{Form1.days[2].tempLow}°";
            max2.Text = $"{Form1.days[2].tempHigh}°";

            date3.Text = Form1.days[3].date;
            min3.Text = $"{Form1.days[3].tempLow}°";
            max3.Text = $"{Form1.days[3].tempHigh}°";
        }

        //A method for all the weather conditions
        private void Conditions()
        {
            #region Clear
            if (Form1.days[0].condition == 800)
            {
                icon.Image = Properties.Resources.ClearSky;
            }

            if (Form1.days[1].condition == 800)
            {
                icon1.Image = Properties.Resources.ClearSky;
            }

            if (Form1.days[2].condition == 800)
            {
                icon2.Image = Properties.Resources.ClearSky;
            }

            if (Form1.days[3].condition == 800)
            {
                icon3.Image = Properties.Resources.ClearSky;
            }
            #endregion
            #region Clouds
            if (Form1.days[0].condition == 801)
            {
                icon.Image = Properties.Resources.FewClouds;
            }
            if (Form1.days[0].condition == 802)
            {
                icon.Image = Properties.Resources.ScatteredClouds;
            }
            else if (Form1.days[0].condition == 803)
            {
                icon.Image = Properties.Resources.BrokenClouds;
            }
            else if (Form1.days[0].condition == 804)
            {
                icon.Image = Properties.Resources.BrokenClouds;
            }

            if (Form1.days[1].condition == 801)
            {
                icon1.Image = Properties.Resources.FewClouds;
            }
            if (Form1.days[0].condition == 802)
            {
                icon.Image = Properties.Resources.ScatteredClouds;
            }
            else if (Form1.days[1].condition == 803)
            {
                icon1.Image = Properties.Resources.BrokenClouds;
            }
            else if (Form1.days[1].condition == 804)
            {
                icon1.Image = Properties.Resources.BrokenClouds;
            }

            if (Form1.days[2].condition == 801)
            {
                icon2.Image = Properties.Resources.FewClouds;
            }
            if (Form1.days[0].condition == 802)
            {
                icon.Image = Properties.Resources.ScatteredClouds;
            }
            else if (Form1.days[2].condition == 803)
            {
                icon2.Image = Properties.Resources.BrokenClouds;
            }
            else if (Form1.days[2].condition == 804)
            {
                icon2.Image = Properties.Resources.BrokenClouds;
            }

            if (Form1.days[3].condition == 801)
            {
                icon3.Image = Properties.Resources.FewClouds;
            }
            if (Form1.days[0].condition == 802)
            {
                icon.Image = Properties.Resources.ScatteredClouds;
            }
            else if (Form1.days[3].condition == 803)
            {
                icon3.Image = Properties.Resources.BrokenClouds;
            }
            else if (Form1.days[3].condition == 804)
            {
                icon3.Image = Properties.Resources.BrokenClouds;
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

            if (Form1.days[1].condition == 200)
            {
                icon1.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[1].condition == 201)
            {
                icon1.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[1].condition == 202)
            {
                icon1.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[1].condition == 210)
            {
                icon1.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[1].condition == 211)
            {
                icon1.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[1].condition == 212)
            {
                icon1.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[1].condition == 221)
            {
                icon1.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[1].condition == 230)
            {
                icon1.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[1].condition == 231)
            {
                icon1.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[1].condition == 232)
            {
                icon1.Image = Properties.Resources.Thunderstorm;
            }

            if (Form1.days[2].condition == 200)
            {
                icon2.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[2].condition == 201)
            {
                icon2.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[2].condition == 202)
            {
                icon2.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[2].condition == 210)
            {
                icon2.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[2].condition == 211)
            {
                icon2.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[2].condition == 212)
            {
                icon2.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[2].condition == 221)
            {
                icon2.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[2].condition == 230)
            {
                icon2.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[2].condition == 231)
            {
                icon2.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[2].condition == 232)
            {
                icon2.Image = Properties.Resources.Thunderstorm;
            }

            if (Form1.days[3].condition == 200)
            {
                icon3.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[3].condition == 201)
            {
                icon3.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[3].condition == 202)
            {
                icon3.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[3].condition == 210)
            {
                icon3.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[3].condition == 211)
            {
                icon3.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[3].condition == 212)
            {
                icon3.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[3].condition == 221)
            {
                icon3.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[3].condition == 230)
            {
                icon3.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[3].condition == 231)
            {
                icon3.Image = Properties.Resources.Thunderstorm;
            }
            else if (Form1.days[3].condition == 232)
            {
                icon3.Image = Properties.Resources.Thunderstorm;
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

            if (Form1.days[1].condition == 300)
            {
                icon1.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[1].condition == 301)
            {
                icon1.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[1].condition == 302)
            {
                icon1.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[1].condition == 310)
            {
                icon1.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[1].condition == 311)
            {
                icon1.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[1].condition == 312)
            {
                icon1.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[1].condition == 313)
            {
                icon1.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[1].condition == 314)
            {
                icon1.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[1].condition == 321)
            {
                icon1.Image = Properties.Resources.ShowerRain;
            }

            if (Form1.days[2].condition == 300)
            {
                icon2.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[2].condition == 301)
            {
                icon2.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[2].condition == 302)
            {
                icon2.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[2].condition == 310)
            {
                icon2.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[2].condition == 311)
            {
                icon2.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[2].condition == 312)
            {
                icon2.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[2].condition == 313)
            {
                icon2.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[2].condition == 314)
            {
                icon2.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[2].condition == 321)
            {
                icon2.Image = Properties.Resources.ShowerRain;
            }

            if (Form1.days[3].condition == 300)
            {
                icon3.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[3].condition == 301)
            {
                icon3.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[3].condition == 302)
            {
                icon3.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[3].condition == 310)
            {
                icon3.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[3].condition == 311)
            {
                icon3.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[3].condition == 312)
            {
                icon3.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[3].condition == 313)
            {
                icon3.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[3].condition == 314)
            {
                icon3.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[3].condition == 321)
            {
                icon3.Image = Properties.Resources.ShowerRain;
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

            if (Form1.days[1].condition == 500)
            {
                icon1.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[1].condition == 501)
            {
                icon1.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[1].condition == 502)
            {
                icon1.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[1].condition == 503)
            {
                icon1.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[0].condition == 504)
            {
                icon1.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[1].condition == 511)
            {
                icon1.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[1].condition == 520)
            {
                icon1.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[1].condition == 521)
            {
                icon1.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[1].condition == 522)
            {
                icon1.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[1].condition == 531)
            {
                icon1.Image = Properties.Resources.Rain;
            }

            if (Form1.days[2].condition == 500)
            {
                icon2.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[2].condition == 501)
            {
                icon2.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[2].condition == 502)
            {
                icon2.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[2].condition == 503)
            {
                icon2.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[2].condition == 504)
            {
                icon2.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[2].condition == 511)
            {
                icon2.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[2].condition == 520)
            {
                icon2.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[2].condition == 521)
            {
                icon2.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[2].condition == 522)
            {
                icon2.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[2].condition == 531)
            {
                icon2.Image = Properties.Resources.Rain;
            }

            if (Form1.days[3].condition == 500)
            {
                icon3.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[3].condition == 501)
            {
                icon3.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[3].condition == 502)
            {
                icon3.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[3].condition == 503)
            {
                icon3.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[3].condition == 504)
            {
                icon3.Image = Properties.Resources.Rain;
            }
            else if (Form1.days[3].condition == 511)
            {
                icon3.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[3].condition == 520)
            {
                icon3.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[3].condition == 521)
            {
                icon3.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[3].condition == 522)
            {
                icon3.Image = Properties.Resources.ShowerRain;
            }
            else if (Form1.days[3].condition == 531)
            {
                icon3.Image = Properties.Resources.Rain;
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

            if (Form1.days[1].condition == 600)
            {
                icon1.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[1].condition == 601)
            {
                icon1.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[1].condition == 602)
            {
                icon1.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[1].condition == 611)
            {
                icon1.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[1].condition == 612)
            {
                icon1.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[1].condition == 613)
            {
                icon1.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[1].condition == 615)
            {
                icon1.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[1].condition == 616)
            {
                icon1.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[1].condition == 620)
            {
                icon1.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[1].condition == 621)
            {
                icon1.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[1].condition == 622)
            {
                icon1.Image = Properties.Resources.Snow;
            }

            if (Form1.days[2].condition == 600)
            {
                icon2.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[2].condition == 601)
            {
                icon2.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[2].condition == 602)
            {
                icon2.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[2].condition == 611)
            {
                icon2.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[2].condition == 612)
            {
                icon2.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[2].condition == 613)
            {
                icon2.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[2].condition == 615)
            {
                icon2.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[2].condition == 616)
            {
                icon2.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[2].condition == 620)
            {
                icon2.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[2].condition == 621)
            {
                icon2.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[2].condition == 622)
            {
                icon2.Image = Properties.Resources.Snow;
            }

            if (Form1.days[3].condition == 600)
            {
                icon3.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[3].condition == 601)
            {
                icon3.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[3].condition == 602)
            {
                icon3.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[3].condition == 611)
            {
                icon3.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[3].condition == 612)
            {
                icon3.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[3].condition == 613)
            {
                icon3.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[3].condition == 615)
            {
                icon3.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[3].condition == 616)
            {
                icon3.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[3].condition == 620)
            {
                icon3.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[3].condition == 621)
            {
                icon3.Image = Properties.Resources.Snow;
            }
            else if (Form1.days[3].condition == 622)
            {
                icon3.Image = Properties.Resources.Snow;
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

            if (Form1.days[1].condition == 701)
            {
                icon1.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[1].condition == 711)
            {
                icon1.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[1].condition == 721)
            {
                icon1.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[1].condition == 731)
            {
                icon1.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[1].condition == 741)
            {
                icon1.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[1].condition == 751)
            {
                icon1.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[1].condition == 761)
            {
                icon1.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[1].condition == 762)
            {
                icon1.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[1].condition == 771)
            {
                icon1.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[1].condition == 781)
            {
                icon1.Image = Properties.Resources.Mist;
            }

            if (Form1.days[2].condition == 701)
            {
                icon2.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[2].condition == 711)
            {
                icon2.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[2].condition == 721)
            {
                icon2.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[2].condition == 731)
            {
                icon2.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[2].condition == 741)
            {
                icon2.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[2].condition == 751)
            {
                icon2.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[2].condition == 761)
            {
                icon2.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[2].condition == 762)
            {
                icon2.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[2].condition == 771)
            {
                icon2.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[2].condition == 781)
            {
                icon2.Image = Properties.Resources.Mist;
            }

            if (Form1.days[3].condition == 701)
            {
                icon3.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[3].condition == 711)
            {
                icon3.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[3].condition == 721)
            {
                icon3.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[3].condition == 731)
            {
                icon3.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[3].condition == 741)
            {
                icon3.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[3].condition == 751)
            {
                icon3.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[3].condition == 761)
            {
                icon3.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[3].condition == 762)
            {
                icon3.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[3].condition == 771)
            {
                icon3.Image = Properties.Resources.Mist;
            }
            else if (Form1.days[3].condition == 781)
            {
                icon3.Image = Properties.Resources.Mist;
            }
            #endregion
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            //Checks to see if a valid city has been entered and displays an error message if not
            try
            {
                Form1.city = locationInput.Text;

                Form1.days.Clear();

                Form1.ExtractForecast();
                Form1.ExtractCurrent();
                Conditions();
                DisplayCurrent();
                displayForecast();
            }
            catch
            {
                locationInput.Text = "Error";
            }
        }
        
    }
}
