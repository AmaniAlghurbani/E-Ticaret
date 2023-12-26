using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.AMANİ.SİTESİ.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){ Name = "Elmas", Description = "Elmas ürünleri"},
                new Category(){ Name = "Altın", Description = "Altın ürünleri"},
                new Category(){ Name = "Gümüş", Description = "Gümüş ürünleri"},
                new Category(){ Name = "Değerli taş", Description = "Değerli taş ürünleri"},
                new Category(){ Name = "Çocuk takı", Description = "Çocuk takı ürünleri"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){ Name = "Elmas",Description = "Sentetik elmas taş büyük suni elmas şeffaf cam yapay kristal takı kağıt ağırlığı ürün dekorasyon.", Price =49279, Stock =5 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "1elmas.jpg"},
                new Product(){ Name = "Yüzük",Description = "Altıntaç 0,54 Karat Elmas Yüzük 10426-PYZ0187, Sipariş aşamasında yüzük ölçünüzü lütfen tablodan seçiniz, Yüzük ölçünüzü bilmiyorsanız aşağıdaki tablodan bakarak belirleyebilirsiniz.", Price =30700, Stock =500 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "2elmas.jpg"},
                new Product(){ Name = "Kolye",Description = "Altıntaç 0,42 Karat Elmas Kolye 10893-PKL0005, Ürün Kodu 10893-PKL0005.", Price =16000 , Stock =5 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "3elmas.jpg"},
                new Product(){ Name = "Kolye",Description = " Altıntaç 0,42 Karat Elmas Kolye 10893-PKL0005, Ürün Kodu 10893-PKL0005", Price =15500 , Stock =32, IsApproved =true , CategoryId = 1,IsHome = true,Image = "4elmas.jpg"},
                new Product(){ Name = "Karat Pırlanta Baget Yüzük",Description = "Göz alıcı tasarımı ile dikkat çeken pırlanta baget yüzük modeli Altınbaş’ın en beğenilen pırlanta baget yüzük modelleri arasında yer alıyor. Sıra dışı görünümleri ile görenleri büyüleyebilmeyi başaran baget yüzükler, farklılığı seven ve dış görünümüne özen gösteren kadınların ilk tercihlerinden oluyor.", Price =9990, Stock =14, IsApproved =true , CategoryId = 1,Image = "5elmas.jpg"},
                new Product(){ Name = "Pırlantalı Kuşin Mavi Topaz Yüzük", Description=" Pırlantalı Kuşin Blue Topaz Yüzük modeli en uygun fiyat ile Lovapirlanta.com'da! Online sipariş verin, hemen gelsin",Price =11000 , Stock =500 , IsApproved =true , CategoryId = 1,Image = "6elmas.jpg"},
                new Product(){ Name = "Sarı Taş TAş Kadınlar için yüksek karbon elmas",Description = " Fiyatlar, incelemeler, özellikler, fotoğraflar, videolar, AliExpress düşük bir fiyata yüksek kaliteli KQDANCE gerçek 925 ayar gümüş büyük yastık kesim sarı taş taş kadınlar için yüksek karbon ..", Price =15600 , Stock =21999 , IsApproved =true , CategoryId = 1,Image = "7elmas.jpg"},
                
                
                
                new Product(){ Name = "22 Ayar kolye Ucu Altın",Description = "Ürün Adı: 22 Ayar Füzyon Kolye Ucu Altın Madalyon, Altın Ayarı: 22 AYAR, Ürün Ağırlığı: 6,05 Gram, Madalyon Çapı : 3 Cm., Madalyon .", Price =19400 , Stock =2, IsApproved =true , CategoryId =2,IsHome = true,Image = "1altın.jpg"},
                new Product(){ Name = "Pırantılı  Çift Sarı Altın",Description = "0.40 karat tamtur pırlantalı altın çift alyans. Roberto Bene pırlanta. İstanbul Kapalıçarşı mağazamızda tüm alyans modellerini görebilir, ...", Price =14500 , Stock =5, IsApproved =true , CategoryId = 2,IsHome = true,Image = "2altın.jpg"},
                new Product(){ Name = "Pırantılı  Çift Sarı Altın",Description = "ALY00832-0001-0002 gerçek kalite ve doğru fiyatlarla Aris Pırlanta’da! Hediye Paketi, Sigortalı ve ücretsiz kargo.", Price =15200 , Stock =8 , IsApproved =true , CategoryId = 2,Image = "3altın.jpg"},
                new Product(){ Name = "Pırantılı  Çift Sarı Altın",Description = "ALY00832-0001-0002 gerçek kalite ve doğru fiyatlarla Aris Pırlanta’da! Hediye Paketi, Sigortalı ve ücretsiz kargo.", Price =14200 , Stock =500 , IsApproved =true , CategoryId = 2,Image = "4altın.jpg"},
                new Product(){ Name = "Kelebek Altın Kolye",Description = "Ayar:14, Model:Günlük, Gram: 3,70, Ebat: 50 cm, Kadınlar İçin Zarif Altın Kolye, Bu bileklik 14 ayar altından yapılmıştır., Günlük kullanımı ve...", Price =9500 , Stock =1200 , IsApproved =true , CategoryId = 2,IsHome = true,Image = "5altın.jpg"},
                new Product(){ Name = "K14 Ayar Altın Bilezik",Description = " En uygun Fiyat Garantisiyle, Peşin fiyatına taksitle, Stoktan aynı gün kargoyla güvenli alışverişin adresi Bilezikci.com .", Price =16400 , Stock =0 , IsApproved =true  , CategoryId = 2,IsHome = true,Image = "6altın.jpg"},
                new Product(){ Name = "Kelebek Altın Kolye 14 Ayar",Description = "En uygun Fiyat Garantisiyle, Peşin fiyatına taksitle, Stoktan aynı gün kargoyla güvenli alışverişin adresi Bilezikci.com.", Price =10500 , Stock =600 , IsApproved =true , CategoryId = 2,Image = "7altın.jpg"},
                new Product(){ Name = "Kelebek Altın Kolye 14K Gold",Description = "14 Ayar (585) GRAM : 1,70 gramÇAP : 1,0 cmZincir uzunluğu 42 cm, ( standart ) Sarı altından üretilmiştir, isteğe göre beyaz ...", Price =17200 , Stock =500 , IsApproved =true , CategoryId = 2,Image = "8altın.jpg"},

               
                
                new Product(){ Name = "Gümüş Bayan Set",Description = " Gümüş ve zirkon taşının ışıltısı dünyanıza renk katacak ve yaşam enerjinizi artıracak. Zirkonun göz alıcı parıltısı dört sıra taş ile doğanın ...", Price =2320 , Stock =2 , IsApproved =true , CategoryId =3,IsHome = true,Image = "1gümüş.jpg"},
                new Product(){ Name = "Parlak Gümüş Yüzüğü",Description = "Söz Yüzüğü gümüş alyans çiftimiz, sözlenecek, söz töreni yapacak veya kendi aralarında söz verecek olan müşterilerimizin yoğunlukla tercih ettiği . .", Price =3400 , Stock =0 , IsApproved =true , CategoryId =3,IsHome = true,Image = "2gümüş.jpg"},
                new Product(){ Name = "Nişan Gümüş Yüzük",Description = "ürününü Aliexpress'den karşılığında satın alın. Daha fazla , ve ürün bulun. ✓Dünya Çapında Ücretsiz Gönderimin Keyfini Çıkarın! ✓Sınırlı Süreli İndirim ✓Kolay İade .", Price =4900 , Stock =0 , IsApproved =true  , CategoryId =3,IsHome = true,Image = "3gümüş.jpg"},
                new Product(){ Name = "Pırlanta Montür Asansörlü Gümüş Bileklik",Description = "Pırlanta Montür Asansörlü Gümüş Bileklik Hızlı ve ücretsiz kargo .", Price =2400 , Stock =0 , IsApproved =true  , CategoryId =3,IsHome = true,Image = "4gümüş.jpg"},
                new Product(){ Name = "İşlemli Gümüş Kolye",Description = "Ürünümüz 925 ayar gümüşten üretilmiştir. Gümüş yüzeyi oksit rodyumu ile kaplanarak gümüşe otantik bir görünümü kazandırılmıştır. Turkuaz taşlı .", Price =6500 , Stock =0 , IsApproved =false , CategoryId =3,IsHome = true,Image = "5gümüş.jpg"},
                new Product(){ Name = "Tektaşlı Gümüş Kolye",Description = "Tektaş Damla Figürlü Swarovski Kadın Gümüş Kolye VSW-9017 en uygun fiyata .", Price =4900 , Stock =0 , IsApproved =true  , CategoryId =3,IsHome = true,Image = "6gümüş.jpg"},


                new Product(){ Name = "Akik (doğal taş)  Yüzük", Description ="Kadınlar için doğal ametist yüzük kadın el yapımı yüzük takı hediye, taş rengi mor ",Price =620 , Stock =99 , IsApproved =true , CategoryId = 4,Image = "1.jpg"},
                new Product(){ Name = "Akik (doğal taş)  Yüzük",Description = " Tüm ürünlerimiz gerçek doğal taş olduğu için renk, şekil ve desenleri, ufak farklılıklar gösterebilir, Parmak ölçüsüne göre her parmağa ayarlanabilir.", Price =499 , Stock =1200 , IsApproved =true , CategoryId = 4,IsHome = true,Image = "2.jpg"},
                new Product(){ Name = "Doğal Taş bilezik",Description = " Bileklik Taşlarından Orijinal Çakra Doğal Taş Bileklik.", Price =600 , Stock =0 , IsApproved =true  , CategoryId =4,IsHome = true,Image = "3.jpg"},
                new Product(){ Name = "Doğal taş  Yüzük",Description = "Yakut Kristali, 0.20 ct G Colour Pırlanta Süslemeli,  2.25 gr 14 Ayar Altın Tasarımlı Yüzük Modelimiz..", Price =370 , Stock =600 , IsApproved =true , CategoryId = 4,Image = "4.jpg"},
                new Product(){ Name = "Doğal taş bilezik",Description = "Doğal mor topaz bilezik doğal taş bilezik 925 gümüş bilezik moda şube su damlası kadın kız hediye takı.", Price =520, Stock =50 , IsApproved =true , CategoryId = 4,Image = "5.jpg"},

            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}