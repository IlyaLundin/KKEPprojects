﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalendarNotes
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class WindowWork : Window
    {
        public string source = "../../Resources/MyNotes.txt"; //Файл для записи и чтения заметок
        public WindowWork()
        {
            InitializeComponent();
            PickedDate.SelectedDate = DateTime.Today; //Установка сегодняшней даты по умолчанию
            
        }
        /// <summary>
        /// Метод записи в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMakeNote_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxNote.Text != null && TextBoxNote.Text != "") //Проверка на заполнение поля
            {
                /* Блок записи в файл
                 * Сначала вызов записи в файл с сохранением,
                   затем запись выбранной даты и заметки */
                using (StreamWriter writerFirst = new StreamWriter(source,true))
                {

                    writerFirst.WriteLine(PickedDate.SelectedDate);
                    writerFirst.WriteLine(TextBoxNote.Text);
                    writerFirst.WriteLine(" ");
                    writerFirst.Close();
                }
                MessageBox.Show("Данные успешно внесены!","Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Не все данные внесены!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        /// <summary>
        /// Метод открытия заметок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOpenNotes_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader readerFirst = new StreamReader(source, System.Text.Encoding.UTF8)) //Вызов чтения из файла
            {
                string notes;
                var resultNote = new StringBuilder();
                while (readerFirst.EndOfStream != true)
                {
                    notes = readerFirst.ReadLine();
                    resultNote.AppendLine(notes);
                }
                WindowMyNotes wMyNotes = new WindowMyNotes();
                wMyNotes.TextBlockMyNotes.Text = resultNote.ToString();
                wMyNotes.Owner = this;
                wMyNotes.Show();
            }
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        /// <summary>
        /// Метод вызова справки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonHelp_Click(object sender, RoutedEventArgs e)
        {
            WindowHelp wHelp = new WindowHelp();
            wHelp.Owner = this;
            wHelp.ShowDialog();
        }
    }
}
