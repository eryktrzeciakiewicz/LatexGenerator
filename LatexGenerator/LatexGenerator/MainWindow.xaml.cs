﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LatexGenerator.Services;

namespace LatexGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public readonly ConfigurationBuilder ConfigBuilder;
        public MainWindow()
        {
            InitializeComponent();
            ConfigBuilder = new ConfigurationBuilder(this);
        }

        protected virtual void OnGenerateButtonClicked(object sender, EventArgs e)
        {
            var config = ConfigBuilder.BuildConfiguration();
            var fg = new FileGenerator(config);
            var file = fg.CreateFile();
            var fw = new FileWriter(file, config);
            fw.WriteFile();
        }

    }
}
