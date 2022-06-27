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


![giris](https://user-images.githubusercontent.com/102472911/175900531-9ec318d0-5387-4c0b-a22e-02c0c5d32c9a.png)



Anasayfa  giriş  ekranı

Anasayfa kısmında Kitap ekleme-çıkarma, öğrenci ekleme-çıkarma,  istatistikler, kitap listesi, üye listesi, teslim alma bölümleri bulunmaktadır. Ekranlarda kullanıcı pratikliği açısından isime göre, öğrenci numarasına göre, kategoriye göre..vb arama butonları bulunacaktır.


![anasayfa](https://user-images.githubusercontent.com/102472911/175900621-9b5c4b9c-5586-4bf0-bf6e-cebf963f023b.png)



Öğrenci Ekle Ekranı

Öğrenci ad, soyad, numara, bölüm adı, telefon numarası, mail adresi kısımları doğru bir şekilde doldurulduğu taktirde öğrenci başarıyla eklendi yazısı ekrana gelecektir.
Aynı öğrenci bir kez eklenecek, iki kez eklenmeye çalışıldığı fark edildiği taktirde aynı öğrencinin sisteme zaten kayıtlı olduğu hakkında bir uyarı verilecektir.


![ogrekle](https://user-images.githubusercontent.com/102472911/175900699-a1f7d5dd-2ca1-40a8-9054-4f0896871434.png)



Üye Listesi

Eklenen öğrencilerin liste şeklinde bulunduğu kısımdır. Güncelle ve sil butonları da bu kısımdadır.
Öğrencilerin ad, soyad, okul no, eposta gibi alanları kolaylıkla güncellenebilir ve yine kolaylıkla öğrenci silinebilir.
Bu kısımda da kullanıcıya öğrenci ismine, kullanıcı adına, telefon numarasına göre arama gibi bir imkan sağlanacaktır.


![ogrlist](https://user-images.githubusercontent.com/102472911/175900760-60f2eccc-1173-41a1-a125-e6cb52629b6c.png)




Kitap Ekleme Ekranı 

Kitap bilgilerinin eksiksiz bir şekilde doldurulması durumunda kitap başarıyla eklendi yazısı ekrana gelecektir.
Aynı kitap bilgileri eklenmesi durumunda bu kitabın zaten sistemde kayıtlı olduğuna dair bir uyarı mesajı ekranda belirecektir.



![kitapekle](https://user-images.githubusercontent.com/102472911/175900855-51c4b4c4-612a-4a26-b0d8-693d7f6ce750.png)



Kitap Listesi 

Eklenen kitapların liste şeklinde bulunduğu kısımdır. Güncelle ve sil butonları bu kısımdadır.
Kitapların mevcut stok durumuna göre güncellemesi bu kısımdan yapılabilecek.
Kitaplar bu kısımda görüntülenecek ve kitap adı, yazar adı, tür ve yayınevi gibi kategoriler için ayrı arama kutucukları bulunacaktır.



![kitaplist](https://user-images.githubusercontent.com/102472911/175901116-0513f586-3e88-4dce-a5f3-cbb7ce6c037e.png)





Teslim alma ve ödünç verme



Gerekli bilgiler dolduruldukan sonra öğrenci kitabı teslim alabilir ve aynı şekilde teslim edebilir.
Teslim alınan kitaplar görüntülenebilir ve hangi kitabın hangi öğrencide olduğu bilgisi kolayca anlaşılabilir.
Kitap teslim tarihleri yaklaşmış ve dolmuş kişileri yine buradan ayırt edebileceğiz.


![oduncver](https://user-images.githubusercontent.com/102472911/175901269-ca8728de-e737-4ab0-93d0-88aa02897819.png)



Ödünç Listesi

Ödünç verilmiş kitapların bilgilerine ve ödünç verilen kişilerin bilgilerine ulaşabildiğimiz sayfadır.


![odunclist](https://user-images.githubusercontent.com/102472911/175901956-ce4dd021-9bdd-4c73-8762-d29cec2c6fe2.png)




İstatistikler 


En çok kitap okuyan,
En çok okunan kitap,
Sistemde en fazla sayıda bulunan kitap,
En az kitap okuyan,
Hiç kitap okumayan,
gibi bilgilere istatistikler kısmından ulaşabileceğiz.


![istatistik](https://user-images.githubusercontent.com/102472911/175901207-c6b0079e-2774-419d-9652-dcd52f27d15f.png)


Öğrenci İşleri


![ogris](https://user-images.githubusercontent.com/102472911/175902311-3c3e3364-46ad-4dac-a415-7a5433524a12.png)



