namespace pr5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // Задаю переменные для ячеек таймера
        private int sec = 0;
        private int min = 0;
        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            // Увеличение переменной Секунды на 1
            sec += 1;
            // Отображение переменной в ячейке для секунд
            if (sec == 59)
            {
                sec = 0;
                min++;
                // Отображение переменной в ячейке для минут 
                txtMinutes.Text = min.ToString();
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tmrSecundomer.Enabled)
            {
                // Если включен, то текст кнопки меняется на Старт
                tmrSecundomer.Stop();
                btnStart.Text = "Старт";
            }
            else
            {
                // Если вкючен, то текст на кнопке меняется на Стоп
                tmrSecundomer.Start();
                btnStart.Text = "Стоп";
            }

        }

        private void Data_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            // остановка таймера и присвоение полям Секунды и минуты число 0 
            tmrSecundomer.Stop();
            txtSeconds.Text = "0";
            txtMinutes.Text = "0";
        }

    }

}