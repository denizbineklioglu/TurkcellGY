
# HANGFIRE NEDİR? 

Yazılımımızdaki arka plan işlerini yürütmemize ve yönetmemize olanak sağlayan açık kaynak kodlu bir kütüphanedir. 
İşlemleri saklabilmek için SQL Server, Redis gibi veritabanlarını ve IoC Container ve Unit Test desteği bulunmaktadır.

Hangfire'ın kurulumu ve konfigürasyanu oldukça basittir. Arka plan için belirlenen işlemlerin durumlarını görmemizi ve yönetmemizi sağlayan
bir Dashboard'ı bulunur. 
<br>

# Hangfire'ın Yararları 

Kullanımı kolay ve çabucak sistemimize entegre edip .NET tarafında çalıştırabiliriz.
Sade bir dashboard'ı bulunduğundan yönetilebilirliği ve görülebilirliği artar.
Oluşturulan arka plan işleri veritabanında tutulduğundan dolayı güvenlidir. 

# Hangfire Job Türleri
<h3>FireAndForget --> Bir kere ve hemen çalışan job tipidir. Örnek uyglama olarak, bir bilgilendirme maili gönderileceği zaman kullanılabilir. </h3>
<h3>Delayed -->  Oluşturulduktan ayarlanan bir zaman sonra çalışan ve sadece 1 kere çalışan job tipidir.  .Örnek uygulama olarak, bir kullanıcı ilk kez kayıt olduğunda belirlenen zamanda onay maili gönderilmesi işlemi.</h3>
<h3>Recurring -->  Tekrarlanan işlerdir. Belirli gün saat hafta gibi sürelerle tekrarlanır. Örnek uygulama olarak, veritabanı backup alma işlemi. </h3>
<h3>Continuations -->  Birbirleriyle ilişkili işlerin olduğu zaman çalışan job tipidir. </h3>

# Hangfire Kurulumu 

Nuget Package Manager'dan Hangfire'ı indiriyoruz.

Hangfire'ın kendi tablolarını oluşturabilmesi için bizim bir veritabanı oluşturmamız gerekiyor. Bunu appsettings.json dosyasında ConnectionString'e yazıyoruz.
Ardından Program.cs dosyasına gelip , build'den önce

```
  builder.Services.AddHangfire(x=>{
    x.UseSqlServerStorage(builder.Configuration.GetValue<string>("ConnectionString"));
  });
  builder.Services.AddHangfireServer();
  
```
yazıyoruz. Sonrasında ise

```
app.UseHangfireDashboard();
```
Middleware'ini ekliyoruz. Bu sayede dashboardda arka plan işlemlerini görüntüleyebileceğiz.

![Screenshot_4](https://github.com/denizbineklioglu/TurkcellGY/assets/76698070/05818d18-a432-42ba-add1-ef39f39c5d72)

<h3> Hangfire'ın otomatik oluşturduğu tablolar </h3>









