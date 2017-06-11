using PrdEditor.Controls;
using PrdEditor.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrdEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ApplicationUtil applicationUtil = ApplicationUtil.Instance;
        private ConfigDatabaseControl configDatabase = ConfigDatabaseControl.getInstance();

        public MainWindow()
        {
            InitializeComponent();
            init();
            initMainWindowLayout();
        }

        private void init()
        {
            initLanguageDictionaryResource();         
            applicationUtil.ApplicationName = this.Resources["applicationName"].ToString();            
        }

        private void initMainWindowLayout() {
            this.Title = applicationUtil.ApplicationName;                
        }

        private void initLanguageDictionaryResource()
        {
            ResourceDictionary dictionary = new ResourceDictionary();
            switch (Thread.CurrentThread.CurrentCulture.ToString())
            {
                case "hu-HU" :
                    dictionary.Source = new Uri("..\\Resources\\StringResources.xaml", UriKind.Relative);
                    break;
                case "en-US":
                    dictionary.Source = new Uri("..\\Resources\\StringResources-en.xaml", UriKind.Relative);
                    break;
                default:
                    dictionary.Source = new Uri("..\\Resources\\StringResources.xaml", UriKind.Relative);
                    break;
            }
            this.Resources.MergedDictionaries.Add(dictionary);
        }        

    }
}
