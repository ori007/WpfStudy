﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfStudy
{
    /// <summary>
    /// ControlTemplate.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ControlTemplate : Window
    {
        public ControlTemplate()
        {
            InitializeComponent();
        }

        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("클릭 되었습니다.");
        }
    }
}
