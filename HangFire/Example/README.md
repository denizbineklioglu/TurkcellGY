
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

Nuget Package Manager'dan 
<h5>1- Hangfire</h5>  
<h5>2- Hangfire.SqlServer</h5> 
<h5>3- Microsoft.Data.SqlClient</h5>
paketlerini indiriyoruz. <br><br>

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


# Hangfire ile bir iş oluşturma

Bunun için öncelikle job tipini belirlemeliyiz ve bunu Program.cs dosyamızda belirtebiliriz. 

![Screenshot_5](https://github.com/denizbineklioglu/TurkcellGY/assets/76698070/52dab388-0aa5-41eb-b69b-038c7b743ba9)

En son parametrede gözüken sayılar ise bu job'ın ne sıklıkla tekrarlayacağını belirleyen 'cron expression generator' dan üretildi. 

Link --> https://crontab.cronhub.io
Bu site sayesinde Hangfire'a belirleceğiniz sürenin kod karşılığını alabilirsiniz. 

![Screenshot_6](https://github.com/denizbineklioglu/TurkcellGY/assets/76698070/b564bb05-6200-4211-8b61-87a077506fca)

Buna göre bizim işlemimiz her gün akşam 17:30'da çalışacak.

# Oluşturduğumuz işi Dashboard'da görüntüleme

![Screenshot_7](https://github.com/denizbineklioglu/TurkcellGY/assets/76698070/ccc8d791-c794-4ae6-a811-5c7d9c55fab5)

![Screenshot_8](https://github.com/denizbineklioglu/TurkcellGY/assets/76698070/6d874006-0ba7-4bcc-bb8f-abe33ec15649)


