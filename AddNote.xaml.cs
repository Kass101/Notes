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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AddNote.xaml
    /// </summary>
    public partial class AddNote : Page
    {
        private Note _currentNote = new Note();
        ApplicationContext db;
        public AddNote()
        {
            InitializeComponent();
            db = new ApplicationContext();

            DataContext = _currentNote;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(title.Text) && string.IsNullOrEmpty(describe.Text))
                MessageBox.Show("Заполните поля");
            else
            {
                //добавление
                db.Notes.Add(_currentNote);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Информация сохранена");
                    Manager.MainFrame.Navigate(new NotePage());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new NotePage());
        }

        private void bold_Click(object sender, RoutedEventArgs e)
        {
            String sSelectedText = describe.SelectedText;
            MessageBox.Show(sSelectedText);
        }
    }
}
