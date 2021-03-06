﻿using DatBindingDemo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DatBindingDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        //private readonly int readOnlyNum = GenNum();
        //private const int sonctNum = 7;
        /*
        private static int GenNum()
        {
            return -13;
        }
        /*
         * Data Binding needs 3 things
         * 1) A Source
         *      Set the Source property of the DataBinding object Directly
         *      Set the DataContext Property of the Dependent
         *      Set the ElementName property of the DataBinding object
         * 2) A Path
         *      This refers to the property of the source object (or the entire source itself)
         * 3) A Mode
         *      Determines the Modality Binding
        */
       
        private Dragon sourceDragon = new Dragon()
        {
            Name = "Toothless",
            Age = 17,
            CanFly = true,
            ScaleColor = "NightFury Black"
        };

        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = sourceDragon;

            //Binding newBinding = new Binding();
            //newBinding.Source = sourceDragon;
            //newBinding.Path = new PropertyPath("Name");
            //newBinding.Mode = BindingMode.TwoWay;


            //NameTextBox.SetBinding(TextBox.TextProperty, newBinding);

            //AgeTextBox.DataContext = sourceDragon;
        }
    }
}
