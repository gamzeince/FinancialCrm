# FinancialCrm 💼

Bu proje, bir finans yönetimi uygulamasıdır. Gider takibi, banka işlemleri, fatura yönetimi ve kullanıcı girişi gibi temel finansal işlemlerini arayüzle sunar. Proje C# Windows Forms, Entity Framework ve MSSQL kullanılarak geliştirilmiştir.

📌 Proje Özellikleri

✅ Login Sistemi

Kullanıcı girişi Entity Framework ile veritabanına bağlı şekilde yapılır.
Hatalı girişlerde kullanıcıyı uyarır.
Doğru girişte Dashboard ekranına yönlendirir.

✅ Kategori Yönetimi (FrmCategories)

Yeni gider kategorileri eklenebilir, mevcutlar güncellenip silinebilir.
Tüm kategoriler kullanıcı dostu bir DataGridView ile listelenir.

✅ Fatura Yönetimi (FrmBilling)

Fatura başlığı, tutarı ve dönemi girilerek ekleme, güncelleme, silme yapılabilir.
İşlemler sonrasında tüm faturalar tablo halinde görüntülenir.

✅ Banka İşlemleri (FrmBankTransactions)

Seçilen bankaya ait işlemler listelenir, tarih filtresiyle dinamik sorgulama yapılır.
Son 5 işlem, son 30 gün veya bu ayki işlemler DataGridView'de gösterilir.

✅ Banka Durumu (FrmBanks)

Ziraat, Vakıf ve İş Bankası bakiyeleri ayrı ayrı gösterilir.
En son yapılan 5 işlem label'lar ile görsel olarak ekrana yazdırılır.

✅ Dashboard Sayfası (FrmDashboard)

Banka bakiyesi, son işlem tutarı ve tüm bankaların bakiyeleri grafiksel olarak gösterilir.
Faturalara ait dinamik grafik ve dönüşümlü etiketlerle güncel borçlar görsel olarak sunulur.

✅ Gider Yönetimi (FrmExpenses)

Tüm giderleri kategori bazlı gruplandırarak DataGridView ve grafikle görsel sunum sağlar.
Seçilen aya göre aylık gider dağılımı listelenip, kullanıcıya uyarı ile rehberlik edilir.


🧠 Kullanılan Teknolojiler

C# – Windows Forms

MSSQL – Entity Framework (Code First)

DataGridView, ChartControl

Git & GitHub üzerinden versiyon kontrolü

📸 Ekran Görüntüleri

<img width="511" height="645" alt="login" src="https://github.com/user-attachments/assets/8051960d-01bb-4465-bd4a-97c7da967264" />
<img width="1177" height="566" alt="dashboard" src="https://github.com/user-attachments/assets/5b4d1608-9782-4030-8c53-db6629cf32eb" />
<img width="1059" height="538" alt="Giderler" src="https://github.com/user-attachments/assets/298711c9-6333-4ff7-8351-34d664cd0933" />
<img width="1057" height="544" alt="banks" src="https://github.com/user-attachments/assets/d157bdae-1ded-4d8a-991b-f3c31dafbbfd" />







