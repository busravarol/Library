# Library

 Nesne Yönelimli Programlama 2 dersi için oluşturulmuş bir kütüphane otomasyon projesidir.
 
 
 Bu proje aşağıdaki sorunları çözmek amacıyla geliştirilmiştir. 
 
1-	Kitapların ödünç alınıp verilmesi konusunda yaşanan zorluklar
2-	Kitapların giriş-çıkış kaydının alınamamasından dolayı takip edilemeyen kitaplar
3-	Yasaklanan yayınevlerini ayırt etme konusunda yaşanan zorluklar
4-	Kitapların mevcut olmasına rağmen sistemde görünmemesi 
5-	Bir öğrenci birden fazla kitap aldığında kullanıcının her kitapta tüm bilgileri tekrar girmek zorunda kalıyor olması.


Otomasyonumuzda;
•	Kitap isimlerine göre arama
•	Yazar isimlerine göre arama
•	İçeriğe göre arama
•	Yeni kitap kaydı
•	Kitapların özetine erişim
•	Çevirmenlere erişim
•	Kayıt silme/ekleme
 bulunacaktır.
 
 
 
 Bu proje;
 
•	Öğrenci ekle-sil işlemlerini yapar.
•	Kitap ekle-sil işlemlerini yapar.
•	Teslim alma işlemlerini yönetir.
•	Üye Listesi’ne erişim sağlar.
•	Kitap Listesi’ne erişim sağlar. 
•	ISBN numarasına göre kitap bulabilir.



 
 Görseller üzerinden örnekler ektedir.
 
 UML DİAGRAMI

![image](https://user-images.githubusercontent.com/102472911/171635573-f560d4cf-4754-4c67-b5cc-eeb70df47012.png)

USE CASE DİAGRAMI


![usecase](https://user-images.githubusercontent.com/102472911/171636918-e35d44e6-ac1d-4248-b133-2569e7645a32.jpeg)



Kullanıcı adı ve şifre girişi yapılarak uygulamaya girilir. Eğer giriş yapacak kişi sisteme kayıtlı değilse kayıt ol butonuna tıklayıp gerekli alanlar doldurulunca kayıt işlemi tamamlanacak ve sisteme giriş yapılacaktır.


![giriş](https://user-images.githubusercontent.com/102472911/171624655-04091910-3ec3-4b50-bdab-78c7addd7973.png)


Anasayfa  giriş  ekranı

Anasayfa kısmında Kitap ekleme-çıkarma, öğrenci ekleme-çıkarma,  istatistikler, kitap listesi, üye listesi, teslim alma bölümleri bulunmaktadır. Ekranlarda kullanıcı pratikliği açısından isime göre, öğrenci numarasına göre, kategoriye göre..vb arama butonları bulunacaktır.


![anasayfa](https://user-images.githubusercontent.com/102472911/171624973-0e4e4a4d-fae8-48f4-80e2-6ce207c912d4.png)


Öğrenci Ekle Ekranı

Öğrenci ad, soyad, numara, bölüm adı, telefon numarası, mail adresi kısımları doğru bir şekilde doldurulduğu taktirde öğrenci başarıyla eklendi yazısı ekrana gelecektir.
Aynı öğrenci bir kez eklenecek, iki kez eklenmeye çalışıldığı fark edildiği taktirde aynı öğrencinin sisteme zaten kayıtlı olduğu hakkında bir uyarı verilecektir.


![öğrenci ekle](https://user-images.githubusercontent.com/102472911/171625137-cabc67be-b844-4559-82ff-8465b8a70291.png)


Üye Listesi

Eklenen öğrencilerin liste şeklinde bulunduğu kısımdır. Güncelle ve sil butonları da bu kısımdadır.
Öğrencilerin ad, soyad, okul no, eposta gibi alanları kolaylıkla güncellenebilir ve yine kolaylıkla öğrenci silinebilir.
Bu kısımda da kullanıcıya öğrenci ismine, kullanıcı adına, telefon numarasına göre arama gibi bir imkan sağlanacaktır.


![üye listesi](https://user-images.githubusercontent.com/102472911/171625283-5c356b40-154f-4bf2-b819-ca8c705f7b6c.png)



Kitap Ekleme Ekranı 

Kitap bilgilerinin eksiksiz bir şekilde doldurulması durumunda kitap başarıyla eklendi yazısı ekrana gelecektir.
Aynı kitap bilgileri eklenmesi durumunda bu kitabın zaten sistemde kayıtlı olduğuna dair bir uyarı mesajı ekranda belirecektir.



![kitap ekle](https://user-images.githubusercontent.com/102472911/171625590-62b0db02-32a5-47c2-a612-ebffe628e526.png)


Kitap Listesi 

Eklenen kitapların liste şeklinde bulunduğu kısımdır. Güncelle ve sil butonları bu kısımdadır.
Kitapların mevcut stok durumuna göre güncellemesi bu kısımdan yapılabilecek.
Kitaplar bu kısımda görüntülenecek ve kitap adı, yazar adı, tür ve yayınevi gibi kategoriler için ayrı arama kutucukları bulunacaktır.


![kitap listesi](https://user-images.githubusercontent.com/102472911/171625768-eef68eda-aa59-4a6c-b75a-11fbcde00182.png)



İstatistikler 


En çok kitap okuyan,
En çok okunan kitap,
Sistemde en fazla sayıda bulunan kitap,
En az kitap okuyan,
Hiç kitap okumayan,
gibi bilgilere istatistikler kısmından ulaşabileceğiz.



![istatistik](https://user-images.githubusercontent.com/102472911/171625833-ff8ced3a-9fdd-4fb0-8190-e8f940287ae1.png)



Teslim alma ve ödünç verme


Gerekli bilgiler dolduruldukan sonra öğrenci kitabı teslim alabilir ve aynı şekilde teslim edebilir.
Teslim alınan kitaplar görüntülenebilir ve hangi kitabın hangi öğrencide olduğu bilgisi kolayca anlaşılabilir.
Kitap teslim tarihleri yaklaşmış ve dolmuş kişileri yine buradan ayırt edebileceğiz.


![ödünç](https://user-images.githubusercontent.com/102472911/171625970-281ae9f5-16f4-4286-bae1-5aa169bcb3d5.png)








