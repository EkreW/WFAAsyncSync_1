namespace WFAAsyncSync_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Bir metodun asenkron calýsabilmesini istiyorsanýz o metot geriye deger döndürse de döndürmese de önce Task tipi ile yaratýlmalýdýr...Task tipi  yaratýldýktan sonra metot eger geriye deger döndürmeyecekse Task'e baska bir sey yazýlmaz...Eger geriye deger döndürecekse o deger tipi Task'e generic olarak verilir..

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

        private async void btnSim_Click(object sender, EventArgs e) //await keyword'u kullanýlacak ise ilgili metodun cagrýldýgý alanýn async keyword'une sahip olmasý gerekir...
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
