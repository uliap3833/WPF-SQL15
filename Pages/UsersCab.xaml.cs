using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_SQL
{
    /// <summary>
    /// Логика взаимодействия для UsersCab.xaml
    /// </summary>
    public partial class UsersCab : Page
    {
        private Users _user;
        public UsersCab(Users user)
        {
            InitializeComponent();
            _user = user;
            TBLOCKFIO.Text = _user.FIO;
            TBLOCKlogin.Text = "Логин: " + _user.login;
            TBLOCKGender.Text = "Пол: " + _user.Sex.name;
            switch (_user.role_id)
            {
                case 1:
                    TBLOCKrole.Text = "Администратор";
                    break;
                case 2:
                    TBLOCKrole.Text = "Обычный пользователь";
                    break;
            }
            if (_user.Photo != null && _user.Photo.Binary != null)
            {
                byte[] PhotoArr = _user.Photo.Binary;
                BitmapImage Fhoto = new BitmapImage();
                using (MemoryStream MS = new MemoryStream(PhotoArr))
                {
                    Fhoto.BeginInit();
                    Fhoto.StreamSource = MS;
                    Fhoto.CacheOption = BitmapCacheOption.OnLoad;
                    Fhoto.EndInit();
                }
                IUserPhoto.Source = Fhoto;
            }
        }

        private void BChagePhoto_Click(object sender, RoutedEventArgs e)
        {
            string path;
            Photo photo = Const.BD.Photo.FirstOrDefault(x => x.user_id == _user.user_id);
            if (photo == null)
            {
                Photo userPhoto = new Photo();
                userPhoto.user_id = _user.user_id;
                OpenFileDialog fileDialog = new OpenFileDialog();
                if (fileDialog.ShowDialog() == true)
                {
                    path = fileDialog.FileName;
                    System.Drawing.Image i = System.Drawing.Image.FromFile(path);
                    ImageConverter IConvector = new ImageConverter();
                    byte[] arr = (byte[])IConvector.ConvertTo(i, typeof(byte[]));
                    userPhoto.Binary = arr;
                    Const.BD.Photo.Add(userPhoto);
                    Const.BD.SaveChanges();
                }
            }
            else
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                if (fileDialog.ShowDialog() == true)
                {
                    path = fileDialog.FileName;
                    System.Drawing.Image i = System.Drawing.Image.FromFile(path);
                    ImageConverter IConvector = new ImageConverter();
                    byte[] arr = (byte[])IConvector.ConvertTo(i, typeof(byte[]));
                    photo.Binary = arr;
                    Const.BD.SaveChanges();
                }
            }
            Const.frame.Navigate(new UsersCab(_user));
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            EditWindow Chage = new EditWindow(_user);
            Chage.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            LogPassEdit Chage = new LogPassEdit(_user);
            Chage.ShowDialog();
            Const.frame.Navigate(new UsersCab(_user));
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            switch (_user.role_id)
            {
                case 1:
                    Const.frame.Navigate(new AdminCab(_user));
                    break;
                case 2:
                    Const.frame.Navigate(new Image());
                    break;
            }

        }
    }
}
