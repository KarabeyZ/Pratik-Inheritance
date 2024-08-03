using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikInheritance
{
    //base sınıf oluşturdum ve bu sınıftan miras alan 2 farklı türetilmiş sınıf oluşturdum
    public class BaseKisi
    {
        //propertyler tanımlandı
        public string _firstName { get; set; }
        public string _lastName { get; set; }

        //constructor tanımladım
        public BaseKisi(string firstName, string lastName)
        {
            //propertye değer atadım
            _firstName = firstName;
            _lastName = lastName;
        }
        //burada virtual kullanmamın sebebi aşağıda override yaparak istediğim gibi değiştirebilmem içeriği
        public virtual void displayInfo()
        {
            Console.WriteLine(_firstName + " " + _lastName);
        }
    }
    //student class'ı basekisi den kalıtım yoluyla özellikleri alıyor 
    public class Student : BaseKisi
    {
        public int _studentNumber { get; set; }

        //base ile basekisi 'nin constructorunu çağırıyorum burada
        public Student(string _firstName, string _lastName, int studentNumber) : base(_firstName, _lastName)
        {
            _studentNumber = studentNumber;
        }
        public override void displayInfo()
        {
            Console.WriteLine("Öğrenci isim: " + _firstName + ",Öğrenci Soyisim: " + _lastName + ",Öğrenci Numara: " + _studentNumber);
        }
    }
    public class Teacher : BaseKisi
    {
        public decimal _payCheck { get; set; }
        public Teacher(string _firstName, string _lastName, decimal payCheck) : base(_firstName, _lastName)
        {
            _payCheck = payCheck;
        }
        public override void displayInfo()
        {
            Console.WriteLine("Öğretmen İsim: " + _firstName + ",Öğretmen Soyisim: " + _lastName + ",Maaaş Bilgisi: " + _payCheck);
        }
    }
}
