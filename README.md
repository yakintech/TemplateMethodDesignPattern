# TemplateMethodDesignPattern
Template Method Design Pattern belirli iş akışlarının içerisinde benzer algoritmalar kullanıldığı zaman kullanılabilir. 
Örneğin:
Excel ve XML rapor çıkaracak iki adet methodumuz var. Bunlar kendi şablonlarını ekrana yazdıracak. Fakat bu işlemden önce raporun db den
alınması, işlenmesi gibi bir çok süreç mevcut. Bu süreçleri tek bir abstract içerisinde tanımlayıp alt class lara uyguluyoruz.
