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
    /// Логика взаимодействия для OrderTable.xaml
    /// </summary>
    public partial class CelebrationTable : Page
    {
        int f = 0, s = 0, curord;
        PageChange _PageChange = new PageChange();
        List<Record> StartFilter = Const.BD.Record.ToList();
        List<Record> OrderFilter;
        public CelebrationTable()
        {
            InitializeComponent();
            OrderFilter = StartFilter;
            LVCelebration.ItemsSource = StartFilter;
            List<Color> ColorsList = Const.BD.Color.ToList();
            CBColors.Items.Add("Все");
            for (int i = 0; i < ColorsList.Count; i++)
            {
                CBColors.Items.Add(ColorsList[i].name);
            }
            CBColors.SelectedIndex = 0;
            CBSort.SelectedIndex = 0;
            DataContext = _PageChange;
            curord = OrderFilter.Count();
        }



        private void TextBlock_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;
            int ind = Convert.ToInt32(tb.Uid);
            List<Record> a = Const.BD.Record.Where(x => x.user_id == ind).ToList();
            string str = "Вечеринка: ";
            if (a.Count != 0)
            {
                foreach (Record item in a)
                {
                    str += item.Parties.name + "|";
                }
                str = str.Substring(0, str.Length - 1);
                tb.Text = str;
            }
            else
                tb.Text = "Ничего нет";
        }

        private void Lback_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Const.frame.Navigate(new AdminCab());
        }

        private void Ladd_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Const.frame.Navigate(new ChangeAdd());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender;
            int ind = Convert.ToInt32(B.Uid);
            Record Delete = Const.BD.Record.FirstOrDefault(y => y.id == ind);
            Const.BD.Record.Remove(Delete);
            Const.BD.SaveChanges();
            Const.frame.Navigate(new CelebrationTable());
            MessageBox.Show("Запись удалена", "", MessageBoxButton.OK);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender;
            int ind = Convert.ToInt32(B.Uid);
            Record Update = Const.BD.Record.FirstOrDefault(y => y.id == ind);
            Const.frame.Navigate(new ChangeAdd(Update));
        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender;
            int ind = Convert.ToInt32(B.Uid);
            if (B.Background == Brushes.Black)
            {
                B.Foreground = Brushes.White;
            }
            else if (B.Background == Brushes.White)
            {
                B.Foreground = Brushes.Black;
            }
            else if (B.Background == Brushes.SeaGreen)
            {
                B.Foreground = Brushes.Yellow;
            }
            else
            {
                B.Foreground = Brushes.Black;
            }
        }

        private void Filter()
        {
            int index = CBColors.SelectedIndex;
            if (CBColors.SelectedIndex != 0)
            {
                OrderFilter = StartFilter.Where(x => x.Parties.color_id == index).ToList();
            }
            else
            {
                OrderFilter = StartFilter;
            }
            if (!string.IsNullOrWhiteSpace(TBOXSearch.Text))
            {
                OrderFilter = OrderFilter.Where(x => x.FIO.Contains(TBOXSearch.Text) ||
                x.FIO.ToLower().Contains(TBOXSearch.Text) ||
                x.FIO.ToUpper().Contains(TBOXSearch.Text)).ToList();
            }
            if (CheckBAllPhoto.IsChecked == true)
            {
                OrderFilter = OrderFilter.Where(x => x.party_date > DateTime.Now).ToList();
            }
            if (f == 0)
            {
                LVCelebration.ItemsSource = OrderFilter;
                f++;
            }
            else
            {
                _PageChange.CurrentPage = 1;
                _PageChange.CountOrder = curord;
                _PageChange.Countlist = OrderFilter.Count;
                LVCelebration.ItemsSource = OrderFilter.Skip(_PageChange.CurrentPage * _PageChange.CountOrder - _PageChange.CountOrder).Take(_PageChange.CountOrder).ToList();
                _PageChange.sketch();
            }
        }

        private void CBColors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void TBOXSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void CheckBAllPhoto_Checked(object sender, RoutedEventArgs e)
        {
            Filter();
        }

        private void CheckBAllPhoto_Unchecked(object sender, RoutedEventArgs e)
        {
            Filter();
        }

        private void CBSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sort();
            if (s == 0)
            {
                LVCelebration.Items.Refresh();
                s++;
            }
            else
            {
                _PageChange.CurrentPage = 1;
                _PageChange.CountOrder = curord;
                _PageChange.Countlist = OrderFilter.Count;
                LVCelebration.ItemsSource = OrderFilter.Skip(_PageChange.CurrentPage * _PageChange.CountOrder - _PageChange.CountOrder).Take(_PageChange.CountOrder).ToList();
                _PageChange.sketch();
            }

        }

        private void BUp_Click(object sender, RoutedEventArgs e)
        {
            sort();
            _PageChange.CurrentPage = 1;
            _PageChange.CountOrder = curord;
            _PageChange.Countlist = OrderFilter.Count;
            LVCelebration.ItemsSource = OrderFilter.Skip(_PageChange.CurrentPage * _PageChange.CountOrder - _PageChange.CountOrder).Take(_PageChange.CountOrder).ToList();
            _PageChange.sketch();
        }

        private void BDown_Click(object sender, RoutedEventArgs e)
        {
            sort();
            OrderFilter.Reverse();
            _PageChange.CurrentPage = 1;
            _PageChange.CountOrder = curord;
            _PageChange.Countlist = OrderFilter.Count;
            LVCelebration.ItemsSource = OrderFilter.Skip(_PageChange.CurrentPage * _PageChange.CountOrder - _PageChange.CountOrder).Take(_PageChange.CountOrder).ToList();
            _PageChange.sketch();
        }

        private int sort()
        {
            switch (CBSort.SelectedIndex)
            {
                case 0:
                    OrderFilter.Sort((x, y) => x.Parties.color_id.CompareTo(y.Parties.color_id));
                    return 0;

                case 1:
                    OrderFilter.Sort((x, y) => x.party_date.CompareTo(y.party_date));
                    return 1;

                case 2:
                    OrderFilter.Sort((x, y) => x.FIO.CompareTo(y.FIO));
                    return 2;

                case -1:
                    return -1;

                default:
                    return -2;
            }
        }

        private void PaginCountAllOrders_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (PaginCountAllOrders.Text != "")
                {
                    _PageChange.CountOrder = Convert.ToInt32(PaginCountAllOrders.Text);
                    curord = _PageChange.CountOrder;
                }
                else
                {
                    OrderFilter = StartFilter;
                    _PageChange.CountOrder = OrderFilter.Count;
                    curord = _PageChange.CountOrder;
                }
                _PageChange.Countlist = OrderFilter.Count;
                _PageChange.CurrentPage = 1;
                LVCelebration.ItemsSource = OrderFilter.Skip(_PageChange.CurrentPage * _PageChange.CountOrder - _PageChange.CountOrder).Take(_PageChange.CountOrder).ToList();
                _PageChange.sketch();
            }
            catch
            {
                MessageBox.Show("Значение не может быть меньше 0", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                PaginCountAllOrders.Text = "";
            }
        }

        private void GoPage_MouseDown(object sender, RoutedEventArgs e)
        {
            TextBlock TBLOCK = (TextBlock)sender;
            switch (TBLOCK.Uid)
            {
                case "prev":
                    _PageChange.CurrentPage--;
                    break;
                case "next":
                    _PageChange.CurrentPage++;
                    break;
                default:
                    _PageChange.CurrentPage = Convert.ToInt32(TBLOCK.Text);
                    break;
            }
            LVCelebration.ItemsSource = OrderFilter.Skip(_PageChange.CurrentPage * _PageChange.CountOrder - _PageChange.CountOrder).Take(_PageChange.CountOrder).ToList();
            _PageChange.sketch();
        }
    }
}
