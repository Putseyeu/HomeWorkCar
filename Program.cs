using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> carBrands = new Dictionary<string, string>();
            carBrands.Add("Zarooq Motors", "Zarooq Motors — это автопроизводитель из ОАЭ, специализирующийся на высокопроизводительных автомобилях. Штаб-квартира располагается в Дубае.");
            carBrands.Add("Zastava", "Zastava special cars (Застава специјални аутомобили) — сербская марка автомобилей, созданная в 1953 году как «Црвена застава»");
            carBrands.Add("ZAZ", "ЗАЗ или Запорожский автомобилестроительный завод — главное автомобильное предприятие Украины. Базируется на юго-востоке страны.");
            carBrands.Add("Zenos", "Компания была основана в 2012 году в Норфолке. Основатели, Ансар Али и Марк Эдвардс, раньше вместе трудились в Lotus, а затем и в Caterham.");
            carBrands.Add("Zenvo", "Zenvo Automotive — датский производитель суперкаров, первый на территории страны.");
            carBrands.Add("Zhongtong Bus", "Zhongtong Bus — китайский автопроизводитель, специализирующийся на автобусах.");
            carBrands.Add("ZIL", "ЗИЛ —  Завод специализировался на выпуске грузовых автомобилей (от 6,95 до 14,5 тонн), автобусов и легковых автомобилей представительского класса (на заказ).");
            carBrands.Add("Zinoro", "Zinoro — это совместное предприятие BMW и китайского автопроизводителя Brilliance. Zinoro специализируется на электромобилях.");
            carBrands.Add("Zotye", "Zotye Auto  — частная китайская марка автомобилей, созданная в 2005 году. ");
            
            string userInput = "";
            Console.WriteLine("Справочник содержит информацию о марка автомобилей на букву -  Z");

            while (userInput != "3")
            {
                Console.WriteLine("Меню справочника:" +
                    "\n1 - вывести список марок.\n" +
                    "2 - информация о марке.\n" +
                    "3 - выход из справочникаю.");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowAllcarBrands(carBrands);
                        break;
                    case "2":
                        ShowCarBrand(carBrands);
                        break;                    
                }
            }           
        }

        static void ShowAllcarBrands(Dictionary<string, string> carBrands)
        {
            foreach( var item in carBrands.Keys)
            {
                Console.WriteLine(item); 
            }
        }

        static void ShowCarBrand (Dictionary<string, string> carBrands)
        {
            Console.WriteLine("Введите марко автомобиля.");
            string userInput = Console.ReadLine();
            if (carBrands.ContainsKey(userInput))
            {
                Console.WriteLine(carBrands[userInput]);
            }
            else
            {
                Console.WriteLine($"Маки автомобиля {userInput} нету в списке.");
            }
        }
    }
}
