Rekening rekening = new Rekening("121212");

bool ulang = true;
int jumlah;
string pilihan;

while (ulang)
{
    Console.WriteLine("Menu ATM ");
    Console.WriteLine("1. Display Info \n2. Setor Uang \n3. Tarik Uang \n4. Keluar");
    Console.WriteLine("INPUT PILIHAN");
    pilihan = Console.ReadLine();

    switch (pilihan)
    {
        case "1":
            rekening.DisplayInfo();
            break;
        case "2":
            Console.WriteLine("Maukkan Jumlah Uang: Rp ");
            jumlah = int.Parse(Console.ReadLine());
            rekening.SetorUang(jumlah);
            break;
        case "3":
            Console.WriteLine("Maukkan Jumlah Uang: Rp ");
            jumlah = int.Parse(Console.ReadLine());
            rekening.TarikUang(jumlah);
            break;
        case "4":
            Console.WriteLine("Terimaksih Sudah Menggunakan Layanan Kami!");
            ulang = false;
            break;
    }
}



class Rekening
{
    private string _noRekening;

    private int _saldo;

    public string NoRekening
    {
        set
        {
            _noRekening = value;
        }
    }

    public int saldo
    {
        get { return _saldo; }
        set
        {
            if (value < 0) Console.WriteLine("Saldo Tidak Boleh Negatif!");
            else _saldo = value;
        }
    }

    public string noRekening
    {
        get { return _noRekening; }
    }

    public Rekening(string noRekening)
    {
        _noRekening = noRekening;
        _saldo = 100000;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Menampilkan Info...");
        Console.WriteLine($"No. Rekening: {noRekening}");
        Console.WriteLine($"Saldo saat ini: {saldo}");
    }

    public void SetorUang(int Jumlah)
    {
        if (Jumlah < 0)
        {
            Console.WriteLine("Jumlah uang tidak boleh negatif");
        }
        else
        {
            saldo = Jumlah;
            Console.WriteLine("Berhasil setor uang!");
            Console.WriteLine($"Saldo saat ini: {saldo}");
        }
    }

    public void TarikUang(int Jumlah)
    {
        if (Jumlah > saldo)
        {
            Console.WriteLine("Saldo kamu tidak mencukupi");
        }
        else
        {
            saldo = Jumlah;
            Console.WriteLine("Berhasil tarik uang");
            Console.WriteLine($"Saldo saaat ini {saldo}");
        }
    }

}