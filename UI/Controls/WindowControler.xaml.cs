using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using DomainModel;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// Interaction logic for TopMenu.xaml
    /// </summary>
    public partial class WindowController : UserControl
    {
        public static string DropDownSelection = string.Empty;

        public WindowController()
        {
            InitializeComponent();
        }

        public void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
           // List<string> DropDownFilterOptions = interaction.GetDepartments("message/getdepartments").Result;
            //var combo = sender as ComboBox;
            //combo.ItemsSource = DropDownFilterOptions;
            //combo.SelectedIndex = 0;

        }

        public void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var SelectedComboItem = sender as ComboBox;
            DropDownSelection = SelectedComboItem.SelectedItem as string;
            //MessageBox.Show(DropDownSelection);
            //MessageListDesignModel obj = new MessageListDesignModel();

        }
    }
}
