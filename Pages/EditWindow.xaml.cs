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

namespace WPF_SQL
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        private static EditWindow W;
        private Users _user;
        public EditWindow(Users user)
        {
            InitializeComponent();
            W = this;
            _user = user;
            TBOXName.Text = _user.first_name;
            TBOXSeсondname.Text = _user.last_name;
            TBOXSurname.Text = _user.otc;

            CBgender.ItemsSource = Const.BD.Sex.ToList();
            CBgender.SelectedValuePath = "id";
            CBgender.DisplayMemberPath = "Gender1";
            CBgender.SelectedIndex = _user.sex_id - 1;

        }

        private void Drag(object sender, RoutedEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                EditWindow.W.DragMove();
            }
        }

        private void Bchange_Click(object sender, RoutedEventArgs e)
        {
            _user.first_name = TBOXName.Text;
            _user.last_name = TBOXSurname.Text;
            _user.otc = TBOXSeсondname.Text;
            _user.sex_id = CBgender.SelectedIndex + 1;
            Const.BD.SaveChanges();
            MessageBox.Show("Изменения сохранены", "", MessageBoxButton.OK);
            Const.frame.Navigate(new UsersCab(_user));
            this.Close();
        }

        private void Lback_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
