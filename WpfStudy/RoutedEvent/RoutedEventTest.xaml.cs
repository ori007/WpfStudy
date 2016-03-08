using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfStudy.RoutedEvent
{
    /// <summary>
    /// RoutedEventTest.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class RoutedEventTest : Window
    {
        //public ObservableCollection<EventMessage> EventList
        //{
        //    get;
        //    set;
        //}

        List<EventMessage> EventList = new List<EventMessage>();

        public RoutedEventTest()
        {
            InitializeComponent();
            WindowBubbling.MouseRightButtonDown += WindowBubbling_MouseRightButtonDown;

        }

        private void WindowBubbling_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void btnPuckMan_Click(object sender, RoutedEventArgs e)
        {
            EventList.Add(new EventMessage() { Sender = sender.ToString(), Sourceinfo = e.Source.ToString(), OriginalSource = e.OriginalSource.ToString() });
            this.Binding();
        }
        //message = "#" + " Sender: " + sender.ToString() + "\r\n" +
        //        " Source: " + e.Source + "\r\n" +
        //        " Original Source: " + e.OriginalSource;

        private void SomethingClicked(object sender, RoutedEventArgs e)
        {
            EventList.Add(new EventMessage() { Sender = sender.ToString(), Sourceinfo = e.Source.ToString(), OriginalSource = e.OriginalSource.ToString() });
            e.Handled = true;
            this.Binding();
        }

        private void Binding()
        {
            grdView.ItemsSource = null;
            grdView.ItemsSource = EventList;
        }
    }


    public class EventMessage
    {
        private string sender;
        public string Sender
        {
            get
            {
                return sender;
            }
            set
            {
                sender = value;
            }
        }

        private string source;
        public string Sourceinfo
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
            }
        }

        private string originalsource;
        public string OriginalSource
        {
            get
            {
                return originalsource;
            }
            set
            {
                originalsource = value;
            }
        }
    }

}
