﻿using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Builder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SimpleIoc.Default.Register<IIface,Iface>();

            IocConsumer iocConsumer = new IocConsumer();
            int a = iocConsumer.D(3);
            Buildable buildableOne = new Buildable.Builder().FromInt(1).Build();
            //Buildable buildableTwo = new Buildable(); //(Invalid, Private) 
            Buildable buildableTwo = new Buildable.Builder().Build();
            Buildable buildableThree = new Buildable.Builder().FromInt(3).Build();
        }
    }
}
