using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    class Phone
    {
        const int InventionYear = 1897;
        public readonly int productionYear;

        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }

        private string ModelName { get; set; }
        public string Color { get; set; }
        public Phone()
        {

        }

        public Phone(string model)
        {
            ModelName = model;
        }

        public virtual void Call()
        {
            Console.WriteLine($"Call from {ModelName}");
        }
    }
    class MobilePhone : Phone
    {
        public bool HasSensor { get; set; }
        public MobilePhone(string model) : base(model)
        {

        }
        public override void Call()
        {
            Console.WriteLine("It is mobilePhone");
        }
    }
    class CablePhone : Phone
    {
        public bool HasButton { get; set; }
        public bool ShowNumber { get; set; }
        public int CableLength { get; set; }

        public CablePhone(string model) : base(model)
        {

        }
    }
    class RadioPhone : Phone
    {
        public int Frecuency { get; set; }
        public RadioPhone(string model) : base(model)
        {

        }
    }
    class ToyPhone : Phone
    {
        public byte BatteryLevel { get; set; }
        public ToyPhone(string model) : base(model)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            //MobilePhone phone1 = new MobilePhone("Samsung");

            Phone phone1 = new MobilePhone("Nokia");
            Phone phone2 = new CablePhone("Panasonic");
            phone1.Call();            
            phone2.Call();
            RadioPhone phone3 = new RadioPhone("Racia1990");
            phone3.Call();
            ToyPhone phone4 = new ToyPhone("BarbbyPhone");
            phone4.Call();

            //phone1.modelName = "Samsung";
        }
    }
}
