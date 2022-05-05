using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для EditNote.xaml
    /// </summary>
    public partial class EditNote : Page
    {
        private Note _currentNote = new Note();
        ApplicationContext db;
        public EditNote(Note selectednote)
        {
            InitializeComponent();
            db = new ApplicationContext();
            if (selectednote != null)
                _currentNote = selectednote;

            DataContext = _currentNote;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            EditNote note = new EditNote(new Note
            {
                id = _currentNote.id,
                Describe = _currentNote.Describe,
                Title = _currentNote.Title
            });

            // получаем измененный объект
            _currentNote = db.Notes.Find(note._currentNote.id);
            if (_currentNote != null)
            {
                _currentNote.id = note._currentNote.id;
                _currentNote.Title = note._currentNote.Title;
                _currentNote.Describe = note._currentNote.Describe;
                db.Entry(_currentNote).State = EntityState.Modified;
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
    }
}
