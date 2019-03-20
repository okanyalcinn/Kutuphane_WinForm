# Kütüphane Kitap Takibi  :books:

**C#** programlama dilini kullanarak hazırladığım **WinForm** uygulaması hakkında bilgi vermek istiyorum.

Kütüphaneye ait kitapların emanet verilmesi geri alınması vb. işlemlerin yapılabildiği **WinForm** uygulaması. 
Veri tabanında silinen kayıtların **trigger** yardımı ile silinenler tablosunda kayıt tutarak veri kaybını önlemek amaçlanmıştır.

**Uygulama içeriğinde;**
- Üye kaydı  ekleme (silme/ güncelleme) 
- Kitap ekleme (silme/ güncelleme) 
- Yazar kaydı ekleme (silme/ güncelleme) 
- Kategori ekleme (silme) 
- Yayın evi ekleme (silme)
- Kütüphane kaydı ekleme (silme/ güncelleme) 
- Emanet kitap takibi (Emanet ver/ geri al)
işlemleri yer almakta.

## SQL içeriği :twisted_rightwards_arrows:
Toplamda 14 tablo arasında ilişkilendirilme yapılarak kontrol sağlandı. **Normalizasyon** kurallarına uyarak tablo düzeni oluşturdum.

**Stored Procedure** 

Kayıt ekleme, silme, güncelleme ve arama gibi işlemler için 21 adet stored procedure kullanıldı. 

**Trigger**

SQL veri tabanından silinen verilerin kaybını önlemek için 4 adet trigger kullanıldı.

**View**

Data Grid View içeriğine SQL de bulunan tablo içeriğini aktarmak için 7 adet view kullanıldı.

## C# içeriği :white_check_mark:
17 adet method ile kod tekrarının önüne geçildi. Bunların 3 tanesini aşırı yüklemeli olarak tasarladım.

Formlar arası geçiş ile kullanıcı dostu bir uygulama tasarladım. İncelemenizi öneririm. Zaman ayırdığınız için teşekkürler :slightly_smiling_face:

---

>Not: Dosya içeriğinde **kutuphane.bak** (sql server 2014 sürümü ile uyumlu) veya **kutuphane.sql** scripti ile veri tabanını kurabilirsiniz.
