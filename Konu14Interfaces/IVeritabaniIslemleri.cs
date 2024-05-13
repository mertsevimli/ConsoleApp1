namespace Konu14Interfaces;

interface IVeritabaniIslemleri
    {

        // bu interface bir sınıfta kalıtım alınırsa aşağıdaki tüm methodlar kullanmak zorundadır.
        // interface lerde methodlar sadece aşağıdaki gibi tanımlanır! Methodun yapacağı iş burada değil kullanılacağı  classta yapılır!
        void Add(); // kayıt ekleme metot imzası
        void Update();// güncelleme
        void Delete();// Sil
        void GetAll(); // Listele
    }

