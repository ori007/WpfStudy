using System;
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

namespace WpfStudy.Converter
{
    /// <summary>
    /// DateConverter.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class DateConverter : Window
    {
        public DateConverter()
        {
            InitializeComponent();
            this.Loaded += DateConverter_Loaded;
        }

        private void DateConverter_Loaded(object sender, RoutedEventArgs e)
        {
            List<Memo> lst = new List<Memo>()
            {
                new Memo { Num =1 , Title = "테스트", PostDate = DateTime.Now.AddDays(-2) },
                new Memo { Num =2 , Title = "으아으아", PostDate = DateTime.Now.AddDays(-1) },
                new Memo { Num =3 , Title = "탈출탈출", PostDate = DateTime.Now },
            };

            lstMemo.ItemsSource = lst;
        }
    }

    public class Memo
    {
        public int Num { get; set; }
        public string Title { get; set; }
        public DateTime PostDate { get; set; }
    }
}
