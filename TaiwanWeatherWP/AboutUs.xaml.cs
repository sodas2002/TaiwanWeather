﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using Clarity.Phone.Controls;

namespace TaiwanWeatherWP {
    public partial class AboutUs : AnimatedBasePage {
        public AboutUs() {
            InitializeComponent();
            AnimationContext = LayoutRoot;
        }

        private void LabWebSite_Click(object sender, RoutedEventArgs e) {
            WebBrowserTask labWeb = new WebBrowserTask();
            labWeb.URL = "http://www.ntumobile.org/";
            labWeb.Show();
        }
    }
}