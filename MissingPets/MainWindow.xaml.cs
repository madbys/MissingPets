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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.ComponentModel;

namespace MissingPets
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            //Inititate
            this.SizeToContent = SizeToContent.WidthAndHeight;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(cmbPets.SelectedItem + " in " + cmbLocation.SelectedItem);

            if (rbtn_Lost.IsChecked == true)
            {
                MessageBox.Show("Lost " + cmbPets.SelectedItem + " in " + cmbLocation.SelectedItem);
            }
            else
            {
                MessageBox.Show("Found " + cmbPets.SelectedItem + " in " + cmbLocation.SelectedItem);
            }

        }

        /*********Properties***********/

        //public event PropertyChangedEventHandler PropertyChanged;

        //private Pets _pets;
        //public Pets Pets
        //{
        //    get
        //    {
        //        return _pets;
        //    }
        //    set
        //    {
        //        _pets = value;
        //    }
        //}


    }
}
