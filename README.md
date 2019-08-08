# family_physician_automation

Aile Hekimi Bilgi Sistemi Otomasyonu
Öncelikle otomasyonu yazmadan önce otomasyonun en püf noktalarını ve bir otomasyonda en önemli olarak nelerin bulunması gerektiğini ayıkladım ve her zaman bu püf noktalara dikkat ederek otomasyonu hazırlamaya çalıştım.
AHBS sistemlerinde her bölge aile hekimliklerindeki doktorlar ortak seçim olarak kendilerine piyasadan yani özel sektörden bir AHBS sistemi seçer ve Lisansını satın alırlar. 
İlk aşamada piyasada güncel olarak kullanılan AHBS sistemlerinin işleyişlerini inceledim ve sistemlerdeki farklılıkları artı ve eksi yönlerini düşündüm daha sonra ise çevremdeki AHBS polikliniklere giderek doktorların AHBS sistemlerine olan yorumlarını dinledim ve neler olsa işleriniz daha fazla kolaylaşır olaraktan soru sordum. Ve aldığım cevaplara göre benim yapacağım sisteme doktorların isteklerini katmaya çalıştım.  
Tanıtım;
Giriş Panelleri / Ön Paneller
    • Hasta Giriş Paneli

AHBS sistemimde hasta giriş paneli bir stand üzerine ekran ve bir alt kısmında özleştirilmiş numerik klavye ile giriş yapılabilir veya dokunmatik panel kullanarak sanal bir numerik klavye oluşturularak giriş işlemi yapılabilir bu tamamen AHBS polikliniklerin tercihlerine kalmış bir kullanım türü olacaktır. Panel gayet sade tutmak istedm sadelik dışına çıkıp animasyon amaçlı alt kayan yazı ekledim alt kayan yazı içeriği : "Kaydınızı yaptıktan sonra sıranızı bekleme salonunda bekleyiniz. " kuralını eklemiş oldum.


    • Kapı Üstü Sıra Paneli

Kapı Üstü Sıra Panelinde öncelikle amacım olan hastaların sırası ve Ad Soyad bilgilerini gösterdim. Panelin sağ tarafında 2010/73 sayılı genelgeye göre olan öncelikli hasta sıra listesini verdim. Alt tarafta ise alt kayan yazı ile paneli animasyonlaştırdım alt yazı içeriği : "LÜTFEN ÇAĞIRILMADAN İÇERİ GİRMEYİNİZ!"  kuralını ekledim.

    • Doktor Giriş Paneli

Doktor giriş panelinde, en önemli unsurum sadelik olmuştur. Giriş kısmında doktorlar TC Kimlik Numaraları ve e-Devlet şifreleri ile giriş yaparlar. Eğer ki şifrelerini unuttular ise sisteme kayıtlı olan telefon ve  e-posta seçenekleri gelir ve  seçtiği seçeneğe güvenlik kodu gelir ve o güvenlik koduna hemen erişemez belli başlı değişen sorular kişisel bilgi soruları gelir ve o cevaplar doğru ise o güvenlik koduna erişip şifresini değiştirmesi için güvenlik kodunu kullanır. 
En kötü ihtimalleri düşünerekten doktorların ani bir klavye bozukluklarına karşı giriş için sanal klavye seçeneği  ekledim.

    • Doktor Paneli – Hasta Kabul

Doktor Panelinde, amacımı olabildiğince etkin kullanmaya çalıştım. Amacım ise en az tık ile çok işlem yaptırabilmektir aslına bakarsak kurum ve ticari otomasyonların temel amacı bu olmalıdır ve hatta temel amaçta budur dersek pek yanlış söylemiş olmayız. 
Hasta Kabul paneli gayet açıktır. Üst Buton kısmında;
Birey Çağır butonu sırada bekleyen hastayı çağırır yani kapı üstü sıra panelinde tam ekran olarak ismini yazar ve bildirimler aktif ise isim veya zil çalarak bildirir. Doktor panelinde ise Hasta Muayene paneli açılır.

Bireyi En Sona Al butonu anlık bekleyen hastalarda seçilen hastayı sıranın en sonuna alır. 

Birey Sil butonu anlık bekleyen veya tamamlanan muayene kısmında seçilen kaydı görünürlükten siler ancak veri tabanından silinmez.

Beklemeye Al butonu ile doktor artık alım yapmaz. O butonu tıklandıktan sonraki  girişler başka doktora atanır. Bu durum genellikle belirli günler öğleden sonra köy kurumlarında çalışan doktorların kullanacağı bir olaydır.

Sıradakiler Yönlendirme butonu Anlık Bekleyenler olarak sırada  bekleyen hastaları başka bir doktora rastgele olarak atar ve atadıktan sonra sırasıyla hangi hastanın hangi doktora atandığı bildirilir.

Dış Ekran Ayarları butonu Kapı Üstü Sıra Panelini kastetmektedir.

Dış Ekranı Kapat butonu Kapı Üstü Sıra Panelini kapatır.

Stil Değiştir ise tam anlamıyla doktor panelinin temasını değiştirir.
    • Doktor Paneli – Hasta Kabul -Birey Çağır-Muayene Ekranı

Muayenin yapıldığı paneldir.
 Hastanın temel bilgileri görünür, 
Hasta Şikayeti, 
Tanılar, 
Tetkikler, 
Rapor, 
Reçete, 
Muayene Not, işlemleri yer alır ve anlık kayıt olarak işler. 
Hastaya Uyarı ekleyebilir,
Tansiyon Nabız Şeker Kontrolü yapılabilir,
Hastanın çekirdek ailesine bakılabilir,
E-Reçete’yi SMS ve e-mail olarak gönderebilir.
Ve daha da işlem bu panelden yapılır.

    • Doktor Paneli – Birey İşlem

Birey İşlem panelinde o güne kadar doktorda muayene görmüş tüm hastalar yer alır. 
Ve filtreleme yaparak belirli hastaları görmesini sağlar.
Seçilen Bireye çift tıklanınca Birey bilgilerinin belirli olanları sağ tarafta bulunan Birey Bilgisi penceresine taşınır. 
Seçilen Birey’i Ekle butonu tıklandığında seçilen birey muayene sırasına eklenir.
Yeni Muayene butonu ile anlık olarak seçilen bireyin Hasta Muayene paneli açılır.
Tüm Aile butonuna tıklanınca  seçilen bireyin çekirdek ailesi gözükür. 
Excel’e Gönder butonu ile alt kısımda bulunan tüm hastalar excel’e aktarılır.
Tablo Görünümünü Kaydet butonuna tıklayınca  o an da ekranda gözüken veri tablosunu Ekran Alıntısı alır.
Yönlendirme /Aktarma ile seçilen hastayı anlık olarak seçilen doktorun muayene sırasına yönlendirir.
Geri Kalan olaylarda ise tablodaki veriler için basitçe filtreleme yapar.
    • Doktor Paneli – Poliklinik Defteri

Poliklinik Defteri panelinde o AHBS poliklinik içerisinde muayene olmuş tüm hastalar görünür. 
Birey Filtrele üstünde yer alan butonlar ile belirli bir şekilde filtreleme yapablirsiniz.
Filtreleme işleminde birkaç olayı aynı anda filtreliyebilirsiniz.
Excel’e Gönder butonu ile alt kısımda bulunan tüm veriler excel’e aynı tablo şeklinde gönderilir.
Alt Panelde ise ;
Muayene verilerinin belirli tarihler aralığında gözükmesi için filtreliyebliliriz.
Kişi Arama’da ise isime göre filtreleme yapabiliriz.
E-Reçete Ver’e tıklayınca seçilen muayenenin E-Reçete kodu yanındaki label’e gelir. 
E-Reçete’yi SMS Olarak Gönder butonu seçilen muayenenin hastasına  E-Reçeteyi kayıtlı olan telefon numarasına gönderir.
E-Reçete’yi E-Mail Olarak Gönder butonu seçilen muayene hastasına E-Reçeteyi kayıtlı olan E-Mail adresine gönderir.


    • Doktor Paneli – Randevu Defteri

Randevu Defteri panelinde MHRS portalı üzerinden oluşturulan ve doktorun oluşturduğu randevular görünür.
Gün Filtrele  Üzerinde bulunan butonlarla yeni muayene ekleyebilir ve Günleri filtreliyebiliriz.

    • Doktor Paneli – Aile İşlemleri 

Aile İşlemleri panelinde o AHBS Polikliniğinde muayene olmuş tüm hastalar ve aileleri görünür. Aile Kaydı Eklenebilir, Aile Silme işlemi ise sadece kullanıcı doktor için geçerlidir sadece kendi görünen verilerden seçilen aileyi kaldırır.  Genel  değişikliklere hiçbir şekilde kullanıcı doktor etki edemez.
Seçili Aileyi Düzenle butonu ile seçilmiş olan ailenin sadece belirli verilerini güncelliyebilir ve bu işlemde sadece kullanıcı doktorun kendi panelinde yapılan değişikliktir.
 Mahalle Olarak Filtreleme olayı  girilen mahallede ikamet eden aileleri görüntüler.
Sol alt kısımda aliler/filtrelenmiş veriler sağ alt kısımda ise seçili olan ailenin bireyleri görünür.

    • Doktor Paneli – Veri İşlemleri 

Veri İşlem panelinde 
Veri Tabanı Güncelliyebilir, 
AHBS Poliklinğe katılan Yeni Hastaları görebilir, 
Taşınmış İlişiği Kesilmiş Hastaları görebilir,
 Hasta Sorgulama işlemini  de buradan yapabilir
 Ve aynı zamanda İlaçları da buradan görebilirsiniz.


    • Doktor Paneli – İstatistik
 
İstatistik panelinde doktor hastalık istatistiklerine bakabilir,
Yaş gruplarının sağlık durumlarını inceliyebilir,
Cinsiyete göre sağlık durumu inceliyebilir,
Muayene Tarihlerine sağlık durumlarına bakabilir,
Boy / Kilo aralığı olarak sağlık durumlarına bakabilir, 
Ve bir çok filtrelemeye göre rapor çıkartabilir bunları bir Excel dökümanına dökebilir ve aynı zamanda tek tuş ile Ekran Alıntısı alarak rapor gibi durumlarda  fotoğraf olarak kullanabilir.  
    • Doktor Paneli – Program Ayarları


Program Ayarları panelinde doktor bir çok işlemi kendine göre ayarlıyabilmektedir.
Aynı zamanda bir yandan ödev dışına çıkarak online bağlantı online olarak sistemi güncelleme eklemek istiyorum.


    • Otomasyonu tasarlayken piyasadaki otomasyonlara göre farkı ne oldu?
Sistemime ilk olarak eklediğim E-Reçete için SMS ve e-mail gönderimi bir çok hasta için ve doğa için çok daha yararlı bir duruma çevirdim. 
SMS ve e-mail sistemi genişletilip Tahlil Sonuçları vs. işlemleri de hastaya SMS ve e-mail yolu ile iletilebilir.
İlk başta bahsettiğim gibi otomasyonda amacımız en az tık ile en çok işlemi yaptırabilme konusundan ilerledim.
