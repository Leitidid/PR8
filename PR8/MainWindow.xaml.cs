using GEOMR;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int start = int.Parse(txtStart.Text);
                int step = int.Parse(txtStep.Text);

                GeometricProgression gp = new GeometricProgression(start, step);
                StringBuilder sb = new StringBuilder();
                gp.Reset();
                for (int i = 0; i < 10; i++) // Выведем 10 членов прогрессии
                {
                    sb.AppendLine(gp.Next.ToString());
                }
                txtResult.Text = sb.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите числа" );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка {ex.Message}");
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            string developer = "Дудина Екатерина";
            int job = 8;
            string task = " Создать интерфейс – серия чисел (см. лекцию). Создать класс – геометрическая \r\nпрогрессия. Класс должен включать конструктор. Сравнение производить по шагу \r\nпрогрессии.";
            MessageBox.Show($"Разработчик: {developer}\nНомер работы: {job}\nЗадание: {task}", "О программе");
        }
        // "Выход"
        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
  //fdfd