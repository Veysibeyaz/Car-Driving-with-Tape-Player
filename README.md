# Car Driving with Tape Player

## Oynanış

Oyuncuyu ilk olarak müzik seçim sahnesi karşılamaktadır. Oyuncunun seçebileceği 4 farklı müzik opsiyonu vardır:
> - Music 1 - Monster(Rihanna ft. Eminem)
> - Music 2 - It's My Life(Bon Jovi)
> - Music 3 - Kuzu Kuzu(Tarkan)
> - Music 4 - Unutamadım(Müslüm Gürses)

Oyuncuyu seçtiği müziğe göre farklı renk arabalar ve yol sahnesi beklemektedir. Oyuncu oyuna başladığı andan itibaren müzik çalmaya başlar. Sağ altta geçmiş skoru ve güncel skoru alt alta yazmaktadır. (Skor = Sahnede geçirdiği vakit)

Esc tuşuna bastığında oyuncuyu mola menüsü paneli beklemektedir. İsterse oyuna devam edebilir, isterse ana menüye geçerek sahneler arası geçiş yapabilir. (Yeni sahneye geçtiğinde oyunun tekrar başlaması için Esc tuşuna tekrar basılması gerekmektedir.)

*İyi eğlenceler dileriz.* 

## Tuşlar

>- Oyunda sağ sol kontrolünü A VE D tuşları sağlamaktadır.
>- W tuşu arabaya hız sağlar.
>- S tuşu fren yapar.
>- Esc mola menüsü ve yeni oyun kontrolüne erişebilmektedir.

## Oyun Görselleri

### Ana Menu
![This is an image](https://i.ibb.co/RQ7L70y/Ekran-G-r-nt-s-68.png)

### Oyun İçi Menü
![This is an image](https://i.ibb.co/BVF5Z8F/Ekran-G-r-nt-s-69.png)

### Oyun Sahnesi
![This is an image](https://i.ibb.co/sq1s2rv/Ekran-G-r-nt-s-67.png)



## Benim Geliştirdiğim Kısımlar ve Kodladığım Scriptler

- Mola Menüsü(Oyun içi menü)
- Animasyon
- Kayıt alma

- Üzerinde çalışılan arayüz kazanımları ;
    * Canvas 
    * Button 
    * Panel

### oyunicimenu.cs

Esc tuşuna basıldığında oyun içi menü paneline geçişi sağlar.


## Ekip Arkadaşlarımın Geliştirdiği Kısımlar ve Kodladığı Scriptler (Betül Yalçın)
- Oyun mekaniği
- Oyun içi müzik
- Sahne geçişi
- Kayıt alma

### UiSystem.cs

Oyuncunun oynadığı son oyunun skor kaydı ve güncel oyunun skorunu tutan değişkenlere sahiptir.

### Car.cs

Arabanın hareketini, hızını ve oyun sahnesindeki limitlerini belirler.

### Menu.cs

Sahneler arası geçişi sağlar.

### Road.cs

Oyunda yol görselinin devamlılığını mümkün kılar.

- Üzerinde çalışılan arayüz kazanımları ;
    * Canvas 
    * Button 
    * Audio Source

## Oyun Linki
[Link](https://simmer.io/@betulyalcin/car-driving-with-tape-player)
