namespace WFAAsyncSync_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Bir metodun asenkron cal�sabilmesini istiyorsan�z o metot geriye deger d�nd�rse de d�nd�rmese de �nce Task tipi ile yarat�lmal�d�r...Task tipi  yarat�ld�ktan sonra metot eger geriye deger d�nd�rmeyecekse Task'e baska bir sey yaz�lmaz...Eger geriye deger d�nd�recekse o deger tipi Task'e generic olarak verilir..

        Task SelamlaAsync()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(10000);
                MessageBox.Show("Async olarak cagrildigim icin gorevim kimseyi engellemedi");
            });
        }

        public void Selamla()
        {
            Thread.Sleep(10000);
            MessageBox.Show("Hello World");
        }

        public int KareAl(int sayi)
        {
            Thread.Sleep(10000);
            return sayi * sayi;
        }

        private async void btnSim_Click(object sender, EventArgs e) //await keyword'u kullan�lacak ise ilgili metodun cagr�ld�g� alan�n async keyword'une sahip olmas� gerekir...
        {
            await SelamlaAsync();
            MessageBox.Show("Gorevim bitti!!");
        }

        private void btnSelam_Click(object sender, EventArgs e)
        {
            Selamla();
        }
    }
}
