using TpModul8;
CovidConfig covid = new CovidConfig();
CovidConfig covidConfig = covid.readJson();

Console.WriteLine("(Config Awal)");
Console.WriteLine("Satuan Suhu     : " + covidConfig.satuan_suhu);
Console.WriteLine("Batas Hari Demam: " + covidConfig.batas_hari_demam);
Console.WriteLine("Pesan Ditolak   : " + covidConfig.pesan_ditolak);
Console.WriteLine("Pesan Diterima  : " + covidConfig.pesan_diterima);

covidConfig.ubahSatuan(covidConfig);

Console.WriteLine("(Config Setelah Ubah Satuan)");
Console.WriteLine("Satuan Suhu     : " + covidConfig.satuan_suhu);
Console.WriteLine("Batas Hari Demam: " + covidConfig.batas_hari_demam);
Console.WriteLine("Pesan Ditolak   : " + covidConfig.pesan_ditolak);
Console.WriteLine("Pesan Diterima  : " + covidConfig.pesan_diterima);

Console.WriteLine("Berapa suhu badan anda saat ini ? Dalam nilai " + covidConfig.satuan_suhu);
double suhu = double.Parse(Console.ReadLine());
bool cekSuhu, cekLama;
if (covidConfig.satuan_suhu == "Celcius")
{
    cekSuhu = suhu > 36.5 && suhu < 37.5;
}
else if (covidConfig.satuan_suhu == "Fahrenheit")
{
    cekSuhu = suhu > 97.7 && suhu < 99.5;
}
else
{
    cekSuhu = false;
}
Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala deman? ");
int lama = int.Parse(Console.ReadLine());
if (lama < covidConfig.batas_hari_demam)
{
    cekLama = true;
}
else
{
    cekLama = false;
}
Console.WriteLine(cekLama + " " + cekSuhu);
if (cekSuhu == true && cekLama == true)
{
    Console.WriteLine("Output : " + covidConfig.pesan_diterima);
}
else
{
    Console.WriteLine("Output : " + covidConfig.pesan_ditolak);
}
