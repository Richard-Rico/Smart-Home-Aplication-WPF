using System;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;


namespace SmartHomeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal Valo valot = new Valo(); //Valo.cs Object
        internal Valo valotK = new Valo(); 
        internal Thermostat lampo = new Thermostat(); //Thermostat.cs Object
        Sauna sauna= new Sauna(); //Sauna Object
        public int luku = 123;
        public DispatcherTimer tempTimer = new DispatcherTimer(); // Tick 
        public DispatcherTimer tempTimer2 = new DispatcherTimer();
        public DispatcherTimer tempTimer3 = new DispatcherTimer();

        #region int
        //Kaikki int
        int pvalo;
        int pvalo2;
        int plamp;
        int i;
        int v;
        int a;
        int b;
        int c;
        int d;
        int ta;
        int tb;
        int tc;
        int td;

        #endregion

        public MainWindow()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("wellcome to Smart Home Application");

            InitializeComponent();

            #region int % valon
            //int % valon
            pvalo = 24;
            pvalo2 = 24;
            i = 24;
            v = 0;
            a = 25;
            b = 50;
            c = 75;
            d = 100;
            #endregion

            #region int ilmastointi
            // int ilmastointi aste
            plamp = 22;
            ta = 22;
            tb = 18;
            tc = 22;
            td = 28;
            #endregion

            #region Sauna Tick
            tempTimer.Tick += WamingUp_Tick;
            tempTimer.Interval = new TimeSpan(0, 0, 1); //Tikki käy sekunnin välein

            tempTimer2.Tick += WamingUp2_Tick;
            tempTimer2.Interval = new TimeSpan(0, 0, 1);

            tempTimer3.Tick += WamingUp3_Tick;
            tempTimer.Interval = new TimeSpan(0, 0, 1);
            #endregion
        }


        #region valo Olohuone
        private void btOn_Click(object sender, RoutedEventArgs e)
        {
            valot.Start();
            MessageBox.Show("Set brightness level",
                "SmartHomeApp");
            Thread.Sleep(100);
            txValo.Text = "ON";

            if (sender == btOn)
            {
                valot.Start();
                if (valot.kytkin == true)
                {
                    btnIndicator.Background = Brushes.Yellow;
                }
            }
        }

        private void btOff_Click(object sender, RoutedEventArgs e)
        {
            if (valot.kytkin) 
            {
                valot.Stop();
                Thread.Sleep(100);
                txValo.Text = "0%";
            }
            else 
            {
                MessageBox.Show("The lights are already off","SmartHomeApp");
            }

            if (sender == btOff)
            {
                valot.Stop();
                if (valot.kytkin == false)
                {
                    btnIndicator.Background = Brushes.White;
                }
            }
        }

        private void btKirkkaus1_Click(object sender, RoutedEventArgs e)
        {
            if (valot.kytkin) 
            {
                Thread.Sleep(1200);
                txValo.Text = "";
                pvalo = a;
                txValo.Text = (pvalo).ToString() + "%";
            }
            else 
            {
                MessageBox.Show("Turn On the lights to adjust the dimming levels",
                    "SmartHomeApp");
            }
        }

        private void btKirkkaus2_Click(object sender, RoutedEventArgs e)
        {
            if (valot.kytkin)
            {
                Thread.Sleep(1200);
                txValo.Text = "";
                pvalo = b;
                txValo.Text = (pvalo).ToString() + "%";
            }
            else
            {
                MessageBox.Show("Turn on the lights to adjust the dimming levels",
                    "SmartHomeApp");
            }
        }

        private void btKirkkaus3_Click(object sender, RoutedEventArgs e)
        {
            if (valot.kytkin)
            {
                Thread.Sleep(1200);
                txValo.Text = "";
                pvalo = c;
                txValo.Text = (pvalo).ToString() + "%";
            }
            else
            {
                MessageBox.Show("Turn On the lights to adjust the dimming levels",
                    "SmartHomeApp");
            }
        }

        private void btKirkkaus4_Click(object sender, RoutedEventArgs e)
        {
            if (valot.kytkin)
            {
                Thread.Sleep(1200);
                txValo.Text = "";
                pvalo = d;
                txValo.Text = (pvalo).ToString() + "%";
            }
            else
            {
                MessageBox.Show("Turn on the lights to adjust the dimming levels",
                    "SmartHomeApp");
            }
        }

        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            if (valot.kytkin) 
            {
                txValo.Text = string.Empty;
                Thread.Sleep(500);
                txValo.Text = (++pvalo).ToString() + "%";
            }
            else 
            {
                MessageBox.Show("Turn On the lights to adjust the brightness!","SmartHomeApp");
            }
        }

        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            if (valot.kytkin)
            {
                txValo.Text = string.Empty;
                Thread.Sleep(500);
                txValo.Text = (--pvalo).ToString() + "%";
            }
            else
            {
                MessageBox.Show("Turn On the lights to adjust the brightness!", "SmartHomeApp");
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (valot.kytkin)
            {
                txValo.Text = string.Empty;
                txValo.Text = SliderValo1.Value.ToString() + "%";
            }
            else
            {
                MessageBox.Show("Turn On the lights to adjust the brightness!", "SmartHomeApp");
            }

        }
        #endregion

        #region valo keittiö
        private void btOn2_Click(object sender, RoutedEventArgs e)
        {
            valotK.Start();
            MessageBox.Show("Set brightness level",
                "SmartHomeApp");
            Thread.Sleep(100);
            txValo2.Text = "ON";

            if (sender == btOn2)
            {
                valotK.Start();
                if (valotK.kytkin == true)
                {
                    btnIndicator2.Background = Brushes.Yellow;
                }
            }
        }


        private void btOff2_Click(object sender, RoutedEventArgs e)
        {
            if (valotK.kytkin)
            {
                valotK.Stop();
                Thread.Sleep(100);
                txValo2.Text = "0%";
            }
            else
            {
                MessageBox.Show("The lights are already off", "SmartHomeApp");
            }

            if (sender == btOff2)
            {
                valotK.Stop();
                if (valotK.kytkin == false)
                {
                    btnIndicator2.Background = Brushes.White;
                }
            }
        }

        private void btKirkkausA_Click(object sender, RoutedEventArgs e)
        {
            if (valotK.kytkin)
            {
                Thread.Sleep(1200);
                txValo2.Text = "";
                pvalo2 = a;
                txValo2.Text = (pvalo2).ToString() + "%";
            }
            else
            {
                MessageBox.Show("Turn On the lights to adjust the dimming levels",
                    "SmartHomeApp");
            }
        }

        private void btKirkkausB_Click(object sender, RoutedEventArgs e)
        {
            if (valotK.kytkin)
            {
                Thread.Sleep(1200);
                txValo2.Text = "";
                pvalo2 = b;
                txValo2.Text = (pvalo2).ToString() + "%";
            }
            else
            {
                MessageBox.Show("Turn on the lights to adjust the dimming levels",
                    "SmartHomeApp");
            }
        }

        private void btKirkkausC_Click(object sender, RoutedEventArgs e)
        {
            if (valotK.kytkin)
            {
                Thread.Sleep(1200);
                txValo2.Text = "";
                pvalo2 = c;
                txValo2.Text = (pvalo2).ToString() + "%";
            }
            else
            {
                MessageBox.Show("Turn On the lights to adjust the dimming levels",
                    "SmartHomeApp");
            }
        }

        private void btKirkkausD_Click(object sender, RoutedEventArgs e)
        {
            if (valotK.kytkin)
            {
                Thread.Sleep(1200);
                txValo2.Text = "";
                pvalo2 = d;
                txValo2.Text = (pvalo2).ToString() + "%";
            }
            else
            {
                MessageBox.Show("Turn on the lights to adjust the dimming levels",
                    "SmartHomeApp");
            }
        }

        private void btnUp2_Click(object sender, RoutedEventArgs e)
        {
            if (valotK.kytkin)
            {
                txValo2.Text = string.Empty;
                Thread.Sleep(500);
                txValo2.Text = (++pvalo2).ToString() + "%";
            }
            else
            {
                MessageBox.Show("Turn On the lights to adjust the brightness!", "SmartHomeApp");
            }
        }

        private void btnDown2_Click(object sender, RoutedEventArgs e)
        {
            if (valotK.kytkin)
            {
                txValo2.Text = string.Empty;
                Thread.Sleep(500);
                txValo2.Text = (--pvalo2).ToString() + "%";
            }
            else
            {
                MessageBox.Show("Turn On the lights to adjust the brightness!", "SmartHomeApp");
            }
        }

        private void Slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (valotK.kytkin)
            {
                txValo2.Text = string.Empty;
                txValo2.Text = SliderValo2.Value.ToString() + "%";
            }
            else
            {
                MessageBox.Show("Turn On the lights to adjust the brightness!", "SmartHomeApp");
            }
        }
        #endregion

        #region Ilmastointi
        private void btOnTemp_Click(object sender, RoutedEventArgs e)
        {
            lampo.Start();
            MessageBox.Show("Starting air conditioning",
                "SmartHomeApp");
            Thread.Sleep(1200);
            txIlmastointi.Text = (plamp).ToString() + "°C";

            if (lampo.setting == true)
            {
                btnIndicatorTemp.Background = Brushes.GreenYellow;
            }
          
        }

        private void btOffTemp_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("You are shutting down the air conditioning. Are you sure you want to close the system?", "SmartHomeApp", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                MessageBox.Show("the air conditioning is still on!", "SmartHomeApp");
            }
            else if (lampo.setting)
            {
                lampo.Stop();
                Thread.Sleep(800);
                MessageBox.Show("Heating off!",
                   "SmartHomeApp");
                Thread.Sleep(1200);
                txIlmastointi.Text = String.Empty;
                txIlmastointi.Text = "°C";
                if (lampo.setting == false)
                {
                    btnIndicatorTemp.Background = Brushes.White;
                }
            }
            else
            {
                MessageBox.Show("The air conditioning is already off", "SmartHomeApp");
            }

            //if (sender == btOffTemp)
            //{
            //    lampo.Stop();
            //    if (lampo.setting == false)
            //    {
            //        btnIndicatorTemp.Background = Brushes.White;
            //    }
            //}

        }

        private void btTemp1_Click(object sender, RoutedEventArgs e)
        {
            if (lampo.setting)

            {
                txIlmastointi.Text = string.Empty;
                Thread.Sleep(1000);
                plamp = tb;
                txIlmastointi.Text = (plamp).ToString() + "°C";
            }
            else
            {
                MessageBox.Show("Turn on the air conditioning to set the temperature",
                    "SmartHomeApp");
            }
        }

        private void btTemp2_Click(object sender, RoutedEventArgs e)
        {
            if (lampo.setting)

            {
                txIlmastointi.Text = string.Empty;
                Thread.Sleep(1000);
                plamp = tc;
                txIlmastointi.Text = (plamp).ToString() + "°C";
            }
            else
            {
                MessageBox.Show("Turn on the air conditioning to set the temperature",
                    "SmartHomeApp");
            }
        }

        private void btTemp3_Click(object sender, RoutedEventArgs e)
        {
            if (lampo.setting)

            {
                txIlmastointi.Text = string.Empty;
                Thread.Sleep(1000);
                plamp = td;
                txIlmastointi.Text = (plamp).ToString() + "°C";
            }
            else
            {
                MessageBox.Show("Turn on the air conditioning to set the temperature",
                    "SmartHomeApp");
            }
        }

        private void btnHeatUp_Click(object sender, RoutedEventArgs e)
        {
            if (lampo.setting)

            {
                txIlmastointi.Text = string.Empty;
                Thread.Sleep(1000);
                txIlmastointi.Text = (++plamp).ToString() + "°C";

            }
            else
            {
                MessageBox.Show("Turn on the air conditioning to set the temperature",
                    "SmartHomeApp");
            }
        }

        private void btnHeatDown_Click(object sender, RoutedEventArgs e)
        {
            if (lampo.setting)

            {
                txIlmastointi.Text = string.Empty;
                Thread.Sleep(1000);
                txIlmastointi.Text = (--plamp).ToString() + "°C";

            }
            else
            {
                MessageBox.Show("Turn on the air conditioning to set the temperature",
                    "SmartHomeApp");
            }
        }
        #endregion

        #region Sauna lampötilat
        private void WamingUp_Tick(object sender, EventArgs e)
        {
            sauna.Aste = sauna.Aste + .50;
            Thread.Sleep(500);
            lbSauna.Content = sauna.Aste + "°C";

            if (sauna.Aste > 59.5)
            {
                txSaunailmoitus.Text = "";
                txSaunailmoitus.AppendText("Temperature reached");
                tempTimer.Stop();
            }
        }
        private void WamingUp2_Tick(object sender, EventArgs e)
        {
            sauna.Aste = sauna.Aste + 0.50;
            Thread.Sleep(500);
            lbSauna.Content = sauna.Aste + "°C";

            if (sauna.Aste > 79.5)
            {
                txSaunailmoitus.Text = "";
                txSaunailmoitus.AppendText("Temperature reached");
                tempTimer2.Stop();
            }
        }
        private void WamingUp3_Tick(object sender, EventArgs e) 
        {
            sauna.Aste = sauna.Aste + 0.50;
            Thread.Sleep(500);
            lbSauna.Content = sauna.Aste + "°C";

            if (sauna.Aste > 99.5)
            {
                txSaunailmoitus.Text = "";
                txSaunailmoitus.AppendText("Temperature reached");
                tempTimer3.Stop();
            }
        }

        #endregion

        #region Sauna
        private void btOnSauna_Click(object sender, RoutedEventArgs e)
        {

            sauna.Start();
            MessageBox.Show("Heating up the sauna, please set temperature!",
                "SmartHomeApp");
            txSaunailmoitus.Text = String.Empty;
            {
                if (sauna.running == true)
                {
                    txSaunailmoitus.AppendText("Sauna On");
                    btnIndicatorSauna.Background = Brushes.OrangeRed;
                }
            }
           
        }

        private void btOffSauna_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("You are shutting down the Sauna. Are you sure you want to close the system?", "SmartHomeApp", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                MessageBox.Show("the Sauna is still on!", "SmartHomeApp");
            }
            else if (sauna.running)
            {
                sauna.Stop();
                MessageBox.Show("Sauna is turning off!",
                   "SmartHomeApp");
                Thread.Sleep(1000);
                txSaunailmoitus.Text = String.Empty;
                lbSauna.Content = "°C";
                if (sauna.running == false)
                {
                    tempTimer.Stop();
                    tempTimer2.Stop();
                    tempTimer3.Stop();
                    btnIndicatorSauna.Background = Brushes.White;
                }
            }
            else
            {
                MessageBox.Show("The Sauna is already off", "SmartHomeApp");
            }
        }

        private void btTempSauna1_Click(object sender, RoutedEventArgs e)
        {
            if (sauna.running)
            {
                tempTimer.Start();
                tempTimer2.Stop();
                tempTimer3.Stop();
                MessageBox.Show("Setting temperature to 60 °C");
                Thread.Sleep(150);
                lbSauna.Content = sauna.Aste + "°C";
            }
            else
            {
                MessageBox.Show("Turn On the Sauna to set the temperature!",
                    "SmartHomeApp");
            }
        }

        private void btTempSauna2_Click(object sender, RoutedEventArgs e)
        {
            if (sauna.running)
            {
                tempTimer.Stop();
                tempTimer2.Start();
                tempTimer3.Stop();
                MessageBox.Show("Setting temperature to 80 °C");
                Thread.Sleep(150);
                lbSauna.Content = sauna.Aste + "°C";
            }
            else
            {
                MessageBox.Show("Turn On the Sauna to set the temperature!",
                    "SmartHomeApp");
            }
        }

        private void btTempSauna3_Click(object sender, RoutedEventArgs e)
        {
            if (sauna.running)
            {
                tempTimer.Stop();
                tempTimer2.Stop();
                tempTimer3.Start();
                MessageBox.Show("Setting temperature to 100 °C");
                Thread.Sleep(150);
                lbSauna.Content = sauna.Aste + "°C";
            }
            else
            {
                MessageBox.Show("Turn On the Sauna to set the temperature!",
                    "SmartHomeApp");
            }
        }

        #endregion

       
    }
}
