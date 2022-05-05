using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для NotePage.xaml
    /// </summary>
    public partial class NotePage : Page
    {
        ApplicationContext db;
        public NotePage()
        {
            InitializeComponent();
            db = new ApplicationContext();
            LV_Note.ItemsSource = db.Notes.ToList();
        }
        
        private void edit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new EditNote((sender as Button).DataContext as Note));
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddNote());
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            var delnotes = LV_Note.SelectedItems.Cast<Note>().ToList();

            if (delnotes.Count == 0)
                MessageBox.Show("Выбери заметки для удаления");
            else
            {
                if (MessageBox.Show($"Вы точно хотите удалить следующие {delnotes.Count()} элементов", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        db.Notes.RemoveRange(delnotes);
                        db.SaveChanges();
                        MessageBox.Show("Данные удалены!");
                        Manager.MainFrame.Navigate(new NotePage());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());

                    }
                }
            }
        }

        private void rep_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/Kass101/Notes.git") { UseShellExecute = true });
        }
    }
}
