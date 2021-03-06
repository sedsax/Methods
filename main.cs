using System;
using System.Linq ;//Sum() fonksiyonu bunu eklemeden önce hata verdi
//Engin Demiroğ Hocamın katkılarıyla düzenlediğim kodlar
class MainClass {
  public static void Main (string[] args) {
    Add();
    Add();
    Add();
    Add();
    int num1=40;
    int num2=50;
    Console.WriteLine("method öncesi num1 : " + num1);
    Console.WriteLine("method öncesi num2 : " + num2);
    Console.WriteLine("Add2 : " + Add2(2,3));
    Console.WriteLine("Add2 : " + Add2(43,17));
    var sonuc=Add2(14,9); // "int sonuc" da diyebilirdik "var" yerine
    Console.WriteLine("Add2 sonuc : " + sonuc);
    sonuc=Add3(31);
    Console.WriteLine("Add3 sonuc : " + sonuc);
    var sonuc2=Add4(ref num1,num2);
    Console.WriteLine("Add4 sonuc : " + sonuc2);
    Console.WriteLine("method sonrası num1 : " + num1);//referans tip
    Console.WriteLine("method sonrası num2 : " + num2);//değer tip
    var carpımSonucu1=Multiply(8,9);
    var carpımSonucu2=Multiply(2,3,5);
    Console.WriteLine("2 parametreli method: " + carpımSonucu1 );
    Console.WriteLine("3 parametreli method: " + carpımSonucu2 );
    Console.WriteLine("Toplam : " + Toplama(1,2,3,4,5,6,7,8,9));
    Console.WriteLine("Toplam : " + Toplama(1));
    Console.WriteLine("Toplam : " + Toplama(1,2));
    Console.WriteLine("Toplam : " + Toplama(1,2,3));
    Console.WriteLine("Toplam : " + Toplama(1,2,3,4,5,6,7));

     Console.ReadLine();
  }

  static void Add(){
    Console.WriteLine("Toplam!!!");
  }

  static int Add2(int num1, int num2){
    var result=num1+num2;
    return result;
  }

  static int Add3(int num1, int num2=25){ //default parametre
  //Bunun anlamı: eğer biz fonksiyona parametreleri atarken değer vermezsek fonksiyona atadığımız default değer geçerli kabul edilir
  //ama burada ya tüm parametreleri default yapacağız ya da sondakini
  //ilk parametreyi default yapıp sonraki parametreleri yapmazsak hata alırız
    var result=num1+num2;
    return result;
  }

  static int Add4(ref int num1, int num2){
    num1=10;
    num2=20;
    var result=num1+num2;
    return result;
  }

  static int Multiply(int sayi1, int sayi2){
    int sonuc= sayi1*sayi2;
    return sonuc;
  }
  static int Multiply(int sayi1, int sayi2, int sayi3){//Method overloading
  //yani bir fonksiyona birçok görev yüklüyoruz
  //2 değer girersek aynı isimdeki metoda 2 parametreli olanı method çalışır, 3 değer girersek bu method çalışır
    int sonuc= sayi1*sayi2*sayi3;
    return sonuc;
  }

  static int Toplama(params int[] nums){//istediğimiz kadar parametre ekleyebiliriz. 1 tane sayıyı da toplayabiliriz 100 tane sayıyı da.
      return nums.Sum();
  }



}