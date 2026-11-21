# 1-Amaliy mashg'ulot: Birinchi C# loyihasi

**Fan:** Dasturlash 1 (`DAS1110`)  
**O'quv yili:** 2025/2026  
**O'qituvchi:** Toshpolatov Muxiddin, PhD, dotsent  
**Muassasa:** O'zbekiston Milliy universiteti Jizzax filiali, Amaliy matematika fakulteti

---

## Umumiy ma'lumot va papka tuzilmasi

Ushbu hujjatda **1-amaliy mashg'ulot** davomida bajariladigan amaliy mashqlar hamda uyga vazifa topshiriqlarining tavsifi va tayyor C# kodlari jamlangan:

* **`amaliy-mashgulotlar/raqamli-id-karta.cs`** — 1-mashq (*"Raqamli ID karta"* generatori)
* **`amaliy-mashgulotlar/kinoteatr-chiptasi.cs`** — 2-mashq (*"Kinoteatr chiptasi"* generatori)
* **`amaliy-mashgulotlar/shaxsiy-profil.cs`** — 3-mashq (*"O'zing haqingda profil"*)
* **`topshiriqlar/topshiriq-01.cs`** — Uyga vazifa (kengaytirilgan ID karta va *"Uy hayvoni profili"*)

---

## I-QISM: Amaliy mashg'ulot mashqlari (`amaliy-mashgulotlar/`)

### 1-mashq: *"Raqamli ID karta"* generatori

**Vazifa:** Foydalanuvchidan ism, guruh va yoshini so'rab, konsolga chiroyli formatlangan shaxsiy ID karta chiqarish.

```csharp
using System;

namespace Amaliy1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ismingizni kiriting: ");
            string ism = Console.ReadLine();

            Console.Write("Guruhingizni kiriting: ");
            string guruh = Console.ReadLine();

            Console.Write("Yoshingizni kiriting: ");
            string yosh = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("RAQAMLI ID KARTA");
            Console.WriteLine("=================");
            Console.WriteLine($"Ism:    {ism}");
            Console.WriteLine($"Guruh:  {guruh}");
            Console.WriteLine($"Yosh:   {yosh}");
            Console.WriteLine("=================");
        }
    }
}
```

### 2-mashq: *"Kinoteatr chiptasi"* generatori (Mustaqil)

**Vazifa:** Foydalanuvchidan kino nomi, tomoshabin yoshi va o'rindiq raqamini so'rab, *"chipta"* ko'rinishida konsolga chiqarish.

```csharp
using System;

namespace Amaliy1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kino nomini kiriting: ");
            string kinoNomi = Console.ReadLine();

            Console.Write("Tomoshabin yoshini kiriting: ");
            string yosh = Console.ReadLine();

            Console.Write("O'rindiq raqamini kiriting: ");
            string orindiqRaqami = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("KINOTEATR CHIPTASI");
            Console.WriteLine("==================");
            Console.WriteLine($"Kino:    {kinoNomi}");
            Console.WriteLine($"Yosh:    {yosh}");
            Console.WriteLine($"O'rindiq:{orindiqRaqami}");
            Console.WriteLine("==================");
        }
    }
}
```

### 3-mashq: *"O'zing haqingda profil"* (Qo'shimcha ijodiy mashq)

**Vazifa:** Kamida $5$ ta turli ma'lumot turidan (`string`, `int`, `double`, `bool`, `char`) foydalangan holda shaxsiy profil kartasini yaratish.

```csharp
using System;

namespace Amaliy1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ismingizni kiriting: ");
            string ism = Console.ReadLine();

            Console.Write("Sevimli faningizni kiriting: ");
            string sevimliFan = Console.ReadLine();

            Console.Write("Yoshingizni kiriting: ");
            int yosh = int.Parse(Console.ReadLine());

            Console.Write("Bo'yingizni kiriting (metrda, masalan 1.75): ");
            double boy = double.Parse(Console.ReadLine());

            Console.Write("Sport bilan shug'ullanasizmi? (true/false): ");
            bool sport = bool.Parse(Console.ReadLine());

            Console.Write("Ismingizning bosh harfini kiriting: ");
            char boshHarf = char.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("SHAXSIY PROFIL KARTASI");
            Console.WriteLine("======================");
            Console.WriteLine($"Bosh harf:   {boshHarf}");
            Console.WriteLine($"Ism:         {ism}");
            Console.WriteLine($"Yosh:        {yosh}");
            Console.WriteLine($"Bo'y:        {boy} m");
            Console.WriteLine($"Sevimli fan: {sevimliFan}");
            Console.WriteLine($"Sport:       {sport}");
            Console.WriteLine("======================");
        }
    }
}
```

---

## II-QISM: Uyga vazifa (`topshiriqlar/topshiriq-01.cs`)

**Topshiriq sharti:**
1. 1-mashqdagi *"Raqamli ID karta"* dasturiga yana $2$ ta maydon qo'shing (masalan: *sevimli rang*, *telefon raqami*).
2. *"Uy hayvoni profili"* nomli dastur yozing: uy hayvoni mavjudligi (`bool`), nomi (`string`), turi (`string`) va yoshini (`int`) so'rab, konsolga chiroyli chiqaring.

```csharp
using System;

namespace Topshiriq1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-qism: Kengaytirilgan Raqamli ID karta
            Console.Write("Ismingizni kiriting: ");
            string ism = Console.ReadLine();

            Console.Write("Guruhingizni kiriting: ");
            string guruh = Console.ReadLine();

            Console.Write("Yoshingizni kiriting: ");
            string yosh = Console.ReadLine();

            Console.Write("Sevimli rangingizni kiriting: ");
            string sevimliRang = Console.ReadLine();

            Console.Write("Telefon raqamingizni kiriting: ");
            string telefon = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("KENGAYTIRILGAN ID KARTA");
            Console.WriteLine("=======================");
            Console.WriteLine($"Ism:           {ism}");
            Console.WriteLine($"Guruh:         {guruh}");
            Console.WriteLine($"Yosh:          {yosh}");
            Console.WriteLine($"Sevimli rang:  {sevimliRang}");
            Console.WriteLine($"Telefon:       {telefon}");
            Console.WriteLine("=======================");

            // 2-qism: Uy hayvoni profili
            Console.WriteLine();
            Console.Write("Uy hayvoningiz bormi? (true/false): ");
            bool uyHayvoniBormi = bool.Parse(Console.ReadLine());

            Console.Write("Hayvon nomini kiriting: ");
            string hayvonNomi = Console.ReadLine();

            Console.Write("Hayvon turini kiriting (masalan: mushuk, it): ");
            string hayvonTuri = Console.ReadLine();

            Console.Write("Hayvon yoshini kiriting: ");
            int hayvonYoshi = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("UY HAYVONI PROFILI");
            Console.WriteLine("===================");
            Console.WriteLine($"Uy hayvoni bormi: {uyHayvoniBormi}");
            Console.WriteLine($"Nomi:             {hayvonNomi}");
            Console.WriteLine($"Turi:             {hayvonTuri}");
            Console.WriteLine($"Yoshi:            {hayvonYoshi}");
            Console.WriteLine("===================");
        }
    }
}
```