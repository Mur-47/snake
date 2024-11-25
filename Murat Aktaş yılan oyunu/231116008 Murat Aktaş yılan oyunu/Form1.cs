namespace _231116008_Murat_Aktaş_yılan_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Panel parca;
        Panel elma = new Panel();
        List<Panel> yilan = new List<Panel>();

        string yon = "sağ";
        private void label3_Click(object sender, EventArgs e)
        {
            paneliTemizle();
            label2.Text = "0";
            parca = new Panel();
            parca.Location = new Point(200, 200);
            parca.Size = new Size(20, 20);
            parca.BackColor = Color.Black;
            yilan.Add(parca);
            panel1.Controls.Add(yilan[0]);

            timer1.Start();
            elmaOlustur();

        }
        void puanKontrol() {
            int puan = int.Parse(label2.Text);
            if (puan==100)
            {
                label4.Text = "ERİ LEN YUSUFİ SEN ADAMSIN HE";
                label4.Visible = true;
                timer1.Stop();
            }
        }
        void carpismaKontrol()
        {
            for (int i = 2; i < yilan.Count; i++)
            {
                if (yilan[0].Location == yilan[i].Location)
                {
                    label4.Visible = true;
                    label4.Text = "ÖLDÜN ÇIK";
                    timer1.Stop();
                }
            }
        }
        void paneliTemizle() 
        {
            panel1.Controls.Clear();
            yilan.Clear();
            label4.Visible= false;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int locX = yilan[0].Location.X;
            int locY = yilan[0].Location.Y;
            elmaYedimmi();
            hareket();
            carpismaKontrol();
            puanKontrol();

            if (yon == "sağ")
            {
                if (locX < 880)
                {
                    locX += 20;
                }
                else
                {
                    locX = 0;
                }
            }
            if (yon == "sol")
            {
                if (locX > 0)
                {
                    locX -= 20;
                }
                else
                {
                    locX = 880;
                }

            }
            if (yon == "aşağı")
            {
                if (locY < 880)
                {
                    locY += 20;
                }
                else
                {
                    locY = 0;
                }
            }
            if (yon == "yukarı")
            {
                if (locY > 0)
                {
                    locY -= 20;
                }
                else
                {
                    locY = 880;
                }
            }
            yilan[0].Location = new Point(locX, locY);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D && yon != "sol")
            {
                yon = "sağ";
            }
            if (e.KeyCode == Keys.W && yon != "aşağı")
            {
                yon = "yukarı";
            }
            if (e.KeyCode == Keys.A && yon !="sağ")
            {
                yon = "sol";
            }
            if (e.KeyCode == Keys.S&& yon != "yukarı")
            {
                yon = "aşağı";
            }
        }
        void elmaOlustur()
        {
            Random rnd = new Random();
            int elmaX, elmaY;
            elmaX = rnd.Next(580);
            elmaY = rnd.Next(580);

            elmaX -= elmaX % 20;
            elmaY -= elmaY % 20;
            elma.Size = new Size(20, 20);
            elma.Location = new Point(elmaX, elmaY);
            elma.BackColor = Color.Purple;
            panel1.Controls.Add(elma);

        }

        void elmaYedimmi()

        {
            int puan = int.Parse(label2.Text);
            if (yilan[0].Location == elma.Location)
            {
                panel1.Controls.Remove(elma);
                puan += 10;
                label2.Text = puan.ToString();
                elmaOlustur();
                parcaEkle();
            }
        }
        void parcaEkle()
        {
            Panel ekParca = new Panel();
            ekParca.Size = new Size(20, 20);
            ekParca.BackColor = Color.Green;
            yilan.Add(ekParca);
            panel1.Controls.Add(ekParca);
        }
        void hareket()
        {
            for (int i = yilan.Count - 1; i > 0; i--)
            {
                yilan[i].Location = yilan[i - 1].Location;
            }
        }
    }
}