using System;

class Message{
    /* Full Property
    * Encapsultaionda birden fazla kapsülleme imkanımız vardır. Peki aralarında nasıl farklar vardır anlatayım.
    * Bunlardan ilki aslında bizim set içinde verimizi manipule etmemize yardım eder.
    * Veya veriyi get etmeden once bizim erismemizi saglayip onceden bir get ustunde oynanamamizi saglar.
    * Bu yontem biraz uzun olabilir fakat ise yaradigi durumlar vardir.
    */
    private string _userMessage;

    public String UserMessage {
        get { return _userMessage; }

        set {
            if(string.IsNullOrWhiteSpace(value)){
                throw new Exception("hatali");
            }
            _userMessage = value;
        }
    }
    /* Auto-Implemented Property
    * Bu yontemde direkt aslinda verimizi get ve set etmenin kolay yoludur diyebilirim.
    * Charp arkada bize bunu saglar biz direkt get ve set yazariz.
    */
    public string UserMessage { get; set; }

    /* Read-Only Property)
    * Bu yontem modern csharp icin en uygun yontemlerdendir.
    * Biz constructor icerisine giden verimizi hem capsulleriz hemde iceri set edilen veriyi setter.
    * ile otomatik olarak kontrol ederiz.
    * Charp arkada bize bunu saglar biz direkt get yazariz.
    */
    public string UserMessage { get; }

    public Message(string message){
        if(string.IsNullOrWhiteSpace(message)){
            throw new Exception("hatali")
        }
        UserMessage = message;
    }

    /*
    * 4. Değişmezlik (Immutability) için modern yoldur.
    * Özellik değeri, sadece constructor içinde veya nesne başlatma anında atanabilir.
    * Nesne yaratıldıktan sonra, değeri asla değiştirilemez.
    * Burda bir konu fark edilmiş olabilir init de constructor içinden tanımlanan değer de değiştirelemez.
    * peki bizim farkımız ne? fark tam olarak Program clasında bahsedeceğim.
    * init ile aslında contructordan sonra obje acarak deger atayabiliriz.
    * init sadece constr dan sonra deger atamasini saglar.
    */
    public string MesajInitOnly { get; init; }

    /*
    * 5. Veri taşıma amaçlı sınıflar için en uygun, modern ve kısa yoldur.
    * Tanımlanan tüm parametreler (Text), arka planda otomatik olarak
    * 'public string Text { get; init; }' şeklinde değişmez özelliklere dönüşür.
    * Kapsülleme ve değişmezlik (immutability) sağlar.
    */
}
public record MessageRecord(string Text, int Id);  
class Program{
    static void Main(){
        Message userInput = new Message();
        userInput.UserMessage = "Bana bir kalem önerir misin";

        /*
        * Ucuncu yontemde kullanirken biz constructor icine vermemiz gerekir setter degerini
        */
        Message userInput = new Message("Bana bir kalem önerir misin");

        Console.WriteLine(userInput.UserMessage);

        /*
        * burda da init degerine nasil atama yapaacgimizi gosteriyorum.
        * constructor objemize yine ayni sekilde () acarak atama yapabiliriz.
        */
        Message initMessage = new Message { 
            MesajInitOnly =  "Bu, nesne başlatılırken set edildi (init)." 
        };




    }
}