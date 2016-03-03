using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
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
    /// CarList.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CarList : Window
    {
        public CarList()
        {
            //InitializeComponent();
        }
    }

    public class Cars : ObservableCollection<Car>
    {
    }


    public class Car
    {
        string company = string.Empty;
        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }

        string carname = string.Empty;
        public string CarName
        {
            get
            {
                return carname;
            }
            set
            {
                carname = value;
            }
        }
        public Car() : this(string.Empty,string.Empty)
        {
        }
        public Car(string company, string carName)
        {
            this.Company = company;
            this.CarName = carName;
        }
    }

}
