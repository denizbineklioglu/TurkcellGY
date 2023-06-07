
# OAuth 2 Nedir? 

Web, mobil veya masaüstü uygulamalarına yetkilendirme imkanı veren protokoldür. 
Bu protokol kullanılarak kullanıcının hesabının belli bir kısmına veya tamamına erişim izni alırsınız ve bunu kendi uygulamanızdaki kullanabilirsiniz. 


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

1- Kullanıcı Oturum açar. 
2- OAuth otomatik olarak rastgele bir code_verifier ve code_challenge oluşturur.
3- OAuth, kullanıcıyı yetkilendirme sunucusuna oluşturduğu bu iki değer ile yönlendirir.
4- Kullanıcı oturum açma seçeneklerinden birini kullanarak kimlik doğrulaması yapar. OAuth'un bu kullanıcıya hangi izinleri verdiğinin listesini görüntüleyebileceği bir sayfa görür. 
5- OAuth, code_challenge'ı depolar ve kullanıcıyı yetkilendirme koduyla uygulamaya geri yönlendirir. 
6- En başta oluşturulan code_verifier' yetkilendirme sunucusuna gönderir.
7- Yetkilendirme sunucusu oluşturulan değerleri doğrular. 

![Screenshot_2](https://github.com/denizbineklioglu/TurkcellGY/assets/76698070/63b2da8b-96b5-41ba-9867-24b39e23eb79)
