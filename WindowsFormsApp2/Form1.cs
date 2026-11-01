using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2.FolderforModel; // Подключение модели

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Создаем экземпляр контекста базы данных
        public static Model1 DB = new Model1();

        // 2. Загружаем все мотоциклы из БД в список
        List<Table_Motorbike> Motorbikes = DB.Table_Motorbike.ToList();

        // 3. Переменная для хранения номера текущей карточки
        int AccNumber = 0;

        // Метод для заполнения карточек данными
        private void Loading()
        {
            // Заполняем первую карточку
            userControl11.Fill(Motorbikes[AccNumber]);
            // Заполняем вторую карточку (следующий по списку)
            userControl12.Fill(Motorbikes[AccNumber + 1]);
        }

        // Метод для перелистывания (принимает true - вправо, false - влево)
        private void Loading(bool Incr)
        {
            if (Incr == true && Motorbikes.Count > AccNumber + 2)
                AccNumber++; // Листаем вправо, если есть куда
            else if (Incr == false && AccNumber - 1 >= 0)
                AccNumber--; // Листаем влево, если не в начале
            else
                return; // Если дальше некуда, ничего не делаем

            Loading(); // Обновляем содержимое карточек
        }

        // Это событие загрузки формы (оно у тебя уже есть, просто добавляем код внутрь)
        private void Form1_Load(object sender, EventArgs e)
        {
            Loading();
            comboBoxBrand.Items.Add("(Все)");
            var brands = DB.Table_Motorbike.Select(x => x.Model).Distinct().OrderBy(x => x);
            foreach (var b in brands)
            {
                comboBoxBrand.Items.Add(b);
            }
            comboBoxBrand.SelectedIndex = 0; // При запуске сразу показываем первые две карточки
        }

        // Событие нажатия на кнопку "Вправо" (если ты её создала, название может быть buttonRight_Click)

        // Событие нажатия на кнопку "Влево"
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            Loading(false);
        }

        private void buttonRight_Click_1(object sender, EventArgs e)
        {
            Loading(true);
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            var query = DB.Table_Motorbike.AsQueryable();
            if (comboBoxBrand.SelectedIndex > 0)
            {
                string brand = comboBoxBrand.SelectedItem.ToString();
                query = query.Where(m => m.Brand == brand);
            }
            if (double.TryParse(textBoxPriceMin.Text, out double minPrice))
            {
                query = query.Where(m => m.Price >= minPrice);
            }
            if (double.TryParse(textBoxPriceMax.Text, out double maxPrice))
            {
                query = query.Where(m => m.Price <= maxPrice);
            }
            Motorbikes = query.ToList();
            AccNumber = 0;
            if (Motorbikes.Count >= 2)
            {
                Loading();
            }
            else if (Motorbikes.Count == 1)
            {
                userControl11.Fill(Motorbikes[0]);
                MessageBox.Show("Найден только 1 мотоцикл.");
            }
            else
            {
                MessageBox.Show("По вашему запросу ничего не найдено.");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxBrand.SelectedIndex = 0;
            textBoxPriceMin.Clear();
            textBoxPriceMax.Clear();
            Motorbikes = DB.Table_Motorbike.ToList();
            AccNumber = 0;
            Loading();
        }
    }
}