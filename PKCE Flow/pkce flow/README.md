
# OAuth 2 Nedir? 

Web, mobil veya masaüstü uygulamalarına yetkilendirme imkanı veren protokoldür. 
Bu protokol kullanılarak kullanıcının hesabının belli bir kısmına veya tamamına erişim izni alırsınız ve bunu kendi uygulamanızdaki kullanabilirsiniz. 

# OAuth 2'deki Roller
 <h3>1- Resource Owner</h3>
  
 --İçerik sahibi olan uygulamadır. 
  
 <h3>2- Client Application</h3>
--Resource owner'ın içeriğine erişme isteği gönderen ve erişen uygulamadır.
<h3>3- Authorization Server</h3>
--Client application denilen uygulamaya yetki veren sunuculardır.
<h3>4- Resource Server</h3>
--İçerik sahibinin içerikleri tuttuğu sunucudur. <br><br>

# Çalışma Sırası 

1- Uygulama kullanıcıdan yetki ister. <br>
2- Eğer kullanıcı isteği onaylarsa yetki verilir. <br>
3- Uygulama sunucuya bilgileri gönderir ve sunucudan acces token ister. <br>
4- Eğer bilgiler doğruysa ve yetki izni geçerliyse sunucu uygulamaya bir acces token sağlar.<br>
5- Uygulama bu access token ile erişmek istediği içeriğe istek gönderir.<br>
6- Eğer token geçerli ise, içerik uygulamaya gönderilir. <br>

![Screenshot_1](https://github.com/denizbineklioglu/TurkcellGY/assets/76698070/52106cf7-e40c-4f26-9daa-72bf4388811f)

# PKCE (Proof Key for Code Exchange) Nedir?


Yetkilendirme sunucusu ile istekte bulunan uygulama arasında gizli bir kod sunar. Ek olarak istekte bulunan uygulama, Code Verifier(kod doğrulama) ve Code Challenge (kod sorgulama) adında iki değer oluşturur ve yetkilendirme kodu almak için bunu HTTPS üzerinden gönderir. 

Bu sayede bir saldırgan ola ki bu yetkilendirme koduna ulaşırsa, Code Verifier(kod doğrulayıcı) olmadan token'ı değiştiremez.
Bu yöntem, tarayıcılarda saklanan kullanıcı bilgilerini daha güvene almak için oluşturulmuştur. 

# Nasıl Çalışır ?

1- Kullanıcı Oturum açar. <br>
2- AuthO otomatik olarak rastgele bir code_verifier ve code_challenge oluşturur.<br>
3- AuthO, kullanıcıyı yetkilendirme sunucusuna oluşturduğu bu iki değer ile yönlendirir.<br>
4- Kullanıcı oturum açma seçeneklerinden birini kullanarak kimlik doğrulaması yapar. AuthO'un bu kullanıcıya hangi izinleri verdiğinin listesini görüntüleyebileceği bir sayfa görür. <br>
5- AuthO, code_challenge'ı depolar ve kullanıcıyı yetkilendirme koduyla uygulamaya geri yönlendirir.<br> 
6- En başta oluşturulan code_verifier' yetkilendirme sunucusuna gönderir. <br>
7- Yetkilendirme sunucusu oluşturulan değerleri doğrular. <br>

![Screenshot_2](https://github.com/denizbineklioglu/TurkcellGY/assets/76698070/63b2da8b-96b5-41ba-9867-24b39e23eb79)
