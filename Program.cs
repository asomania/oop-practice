using System;
/*
* Record Class ile aslında bir class yapısının kısa yoludur.
* Biz direkt class yapısının içinde parametreleri tanımlayarak obje olusturabiliriz.
* Record classana 
* 1. Record classlarının parametreleri otomatik olarak public ve değişmez özelliklere dönüşür.
* 2. Record classlarının parametreleri otomatik olarak kapsülleme sağlar.
* 3. Record classlarının parametreleri otomatik olarak değişmezlik sağlar.
* 4. Value Equals ile iki nesne aynı içeriğe sahipse eşittir” demek istiyoruz.
* Normal class’larda ise eşitlik referansa bakar, yani iki farklı obje her zaman farklıdır, 
* içerikleri aynı olsa bile.
*/
public record RecordClass (string message, int messageCount);
class Program{
    static void Main(){
        RecordClass msgObj = new RecordClass("bana bir kalem oner", 1);
        Console.WriteLine(msgObj.message);
    }
}