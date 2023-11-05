namespace pr5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // ����� ���������� ��� ����� �������
        private int sec = 0;
        private int min = 0;
        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            // ���������� ���������� ������� �� 1
            sec += 1;
            // ����������� ���������� � ������ ��� ������
            if (sec == 59)
            {
                sec = 0;
                min++;
                // ����������� ���������� � ������ ��� ����� 
                txtMinutes.Text = min.ToString();
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tmrSecundomer.Enabled)
            {
                // ���� �������, �� ����� ������ �������� �� �����
                tmrSecundomer.Stop();
                btnStart.Text = "�����";
            }
            else
            {
                // ���� ������, �� ����� �� ������ �������� �� ����
                tmrSecundomer.Start();
                btnStart.Text = "����";
            }

        }

        private void Data_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            // ��������� ������� � ���������� ����� ������� � ������ ����� 0 
            tmrSecundomer.Stop();
            txtSeconds.Text = "0";
            txtMinutes.Text = "0";
        }

    }

}