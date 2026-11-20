# 1-DARS. KIRISH: DASTURLASH TILLARI, .NET PLATFORMASI VA C# DA BIRINCHI DASTUR

## 1. Dasturlash haqida umumiy tushuncha

Dasturlash — kompyuterga muayyan vazifalarni bajarish uchun buyruqlar va ko‘rsatmalar berish jarayonidir. Dasturchi maxsus dasturlash tillari yordamida kompyuter bajarishi kerak bo‘lgan amallar ketma-ketligini yozadi.

**Dasturlash tili** — kompyuter dasturlarini yaratish uchun mo‘ljallangan, o‘z sintaksisi va qoidalariga ega bo‘lgan sun’iy til.

Dasturlash tillari yordamida:
- Kompyuter dasturlari yaratiladi.
- Veb-sayt va veb-ilovalar ishlab chiqiladi.
- Mobil ilovalar yaratiladi.
- Ma’lumotlar qayta ishlanadi.
- Turli jarayonlar avtomatlashtiriladi.

### Dasturlash tillarining turlari

Dasturlash tillarini umumiy holda quyidagi guruhlarga ajratish mumkin:

1. **Quyi darajali tillar** — kompyuter apparatiga yaqin bo‘lgan tillar. Masalan, Assembly.
2. **Yuqori darajali tillar** — inson tushunishi va yozishi uchun qulayroq bo‘lgan tillar. Masalan, C#, Python, Java va C++.

## 2. .NET platformasi

.NET — Microsoft tomonidan ishlab chiqilgan, dasturlar yaratish va ishga tushirish uchun mo‘ljallangan dasturiy platforma.

.NET yordamida Windows, Linux va macOS kabi operatsion tizimlar uchun dasturlar yaratish mumkin.

### .NET platformasining asosiy imkoniyatlari

- Turli turdagi dasturlar yaratish.
- Bir nechta operatsion tizimlarda ishlash.
- Dastur kodini bajarish va boshqarish.
- Tayyor kutubxonalardan foydalanish.
- Dasturlarni ishlab chiqish va sinovdan o‘tkazish.

### .NET rivojlanish tarixi

- **2002-yil — .NET Framework:** dastlab asosan Windows uchun ishlab chiqilgan.
- **2016-yil — .NET Core:** ochiq kodli va ko‘p platformali texnologiya sifatida rivojlandi.
- **2020-yil — .NET 5:** .NET platformasining yagona yo‘nalishga birlashishi boshlandi.
- **2023–2025-yillar — .NET 8 va .NET 9:** platformaning yangi imkoniyatlari va unumdorligi rivojlantirildi.

### CLR nima?

CLR (Common Language Runtime) — .NET dasturlarini bajarish muhitidir.

CLR quyidagi vazifalarni bajaradi:
- Dastur kodini ishga tushirish.
- Xotirani boshqarish.
- Xatolarni qayta ishlash.
- Dastur bajarilishini nazorat qilish.

### BCL nima?

BCL (Base Class Library) — .NET tarkibidagi asosiy sinflar va kutubxonalar to‘plami.

U yordamida fayllar bilan ishlash, matnlarni qayta ishlash, ma’lumotlar bilan ishlash va boshqa ko‘plab vazifalarni bajarish mumkin.

### JIT nima?

JIT (Just-In-Time) — dastur ishlayotgan vaqtda IL kodini protsessor tushunadigan mashina kodiga o‘giruvchi mexanizm.

.NET dasturi odatda avval oraliq til — IL (Intermediate Language) ko‘rinishiga kompilyatsiya qilinadi. Keyinchalik JIT kerakli kod qismlarini mashina kodiga aylantiradi.

## 3. Visual Studio dasturlash muhiti

Visual Studio — Microsoft tomonidan ishlab chiqilgan integratsiyalashgan dasturlash muhiti (IDE).

IDE (Integrated Development Environment) — dastur kodini yozish, tekshirish, xatolarni aniqlash va ishga tushirish uchun zarur vositalarni birlashtirgan dasturiy muhit.

### Visual Studio tarkibidagi asosiy vositalar

- **Code Editor** — dastur kodini yozish va tahrirlash oynasi.
- **Compiler** — kodni kompilyatsiya qilish vositasi.
- **Debugger** — dasturdagi xatolarni aniqlash va tuzatish vositasi.
- **Solution Explorer** — loyiha fayllari va tuzilmasini boshqarish oynasi.
- **Output** — dastur bajarilishi va kompilyatsiya natijalarini ko‘rsatish oynasi.

Visual Studio Community versiyasi talabalar va shaxsiy foydalanish uchun bepul taqdim etiladi.

Visual Studio Code esa yengil kod muharriri bo‘lib, Visual Studio'dan farq qiladi.

## 4. Konsol rejimida ishlash

Konsol dasturi — foydalanuvchi bilan matn orqali muloqot qiladigan dastur.

Konsol rejimida ma’lumotlarni ekranga chiqarish va foydalanuvchidan ma’lumot qabul qilish mumkin.

C# tilida buning uchun `Console` sinfidan foydalaniladi.

### Ma’lumot chiqarish

`Console.WriteLine()` — ma’lumotni ekranga chiqaradi va keyingi qatorga o‘tadi.

```csharp
Console.WriteLine("Salom, Dunyo!");
```

`Console.Write()` — ma’lumotni ekranga chiqaradi, lekin keyingi qatorga o‘tmaydi.

```csharp
Console.Write("Salom ");
Console.Write("Dunyo!");
```

Natija:

```text
Salom Dunyo!
```

### Ma’lumot kiritish

`Console.ReadLine()` — foydalanuvchidan matn ko‘rinishida ma’lumot qabul qiladi.

```csharp
Console.Write("Ismingizni kiriting: ");
string ism = Console.ReadLine();

Console.WriteLine("Salom, " + ism);
```

Bu dastur foydalanuvchining ismini qabul qiladi va salomlashadi.

## 5. C# dasturlash tilida birinchi dastur

C# — Microsoft tomonidan ishlab chiqilgan zamonaviy, obyektga yo‘naltirilgan va yuqori darajali dasturlash tili.

C# yordamida konsol dasturlari, veb-ilovalar, Windows dasturlari, mobil ilovalar va boshqa dasturiy mahsulotlar yaratish mumkin.

### Birinchi dastur: Salom, Dunyo!

```csharp
using System;

namespace BirinchiDastur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salom, Dunyo!");
        }
    }
}
```

**Dastur qismlarining vazifasi:**

- `using System;` — System nomlar fazosidan foydalanish imkonini beradi.
- `namespace BirinchiDastur` — dastur elementlarini nomlar fazosiga birlashtiradi.
- `class Program` — Program nomli sinfni e’lon qiladi.
- `static void Main(string[] args)` — dastur bajarilishi boshlanadigan asosiy metod.
- `Console.WriteLine()` — matnni konsol oynasiga chiqaradi.

Eslatma: yangi C# loyihalarida `Program.cs` faylida soddalashtirilgan yozuv usuli ham ishlatilishi mumkin. Bunda `Main()` metodini alohida yozish talab qilinmaydi.

## 6. C# dasturlash tilining asosiy yozish qoidalari

C# tilida kod yozishda quyidagi qoidalarga amal qilish kerak:

1. Har bir buyruq odatda nuqta-vergul (`;`) bilan tugaydi.
2. Figurali qavslar `{ }` kod bloklarini belgilaydi.
3. C# katta va kichik harflarni farqlaydi. Masalan, `Console` va `console` bir xil emas.
4. Kodga izoh yozish uchun maxsus belgilar ishlatiladi.
5. Kodni to‘g‘ri joylashtirish va tartibli yozish uning o‘qilishini osonlashtiradi.

### Izohlar (Comments)

Bir qatorli izoh:

```csharp
// Bu bir qatorli izoh
```

Ko‘p qatorli izoh:

```csharp
/*
Bu ko‘p qatorli
izoh hisoblanadi.
*/
```

Izohlar dastur bajarilishiga ta’sir qilmaydi. Ular kodni tushuntirish uchun ishlatiladi.

## 7. Xulosa

Ushbu darsda dasturlash va dasturlash tillari haqida boshlang‘ich tushunchalar o‘rganildi. .NET platformasining vazifalari, CLR, BCL va JIT mexanizmlari bilan tanishildi.

Shuningdek, Visual Studio dasturlash muhiti, IDE tushunchasi, konsol rejimida ma’lumot kiritish va chiqarish usullari ko‘rib chiqildi.

C# dasturlash tilida birinchi dastur yaratish, uning asosiy tuzilishi va kod yozish qoidalari o‘rganildi.

**Asosiy eslab qolish kerak bo‘lgan buyruqlar:**

| Buyruq | Vazifasi |
|---|---|
| `Console.WriteLine()` | Ma’lumotni chiqarish va yangi qatorga o‘tish |
| `Console.Write()` | Ma’lumotni chiqarish |
| `Console.ReadLine()` | Foydalanuvchidan matn qabul qilish |
| `using System;` | System nomlar fazosidan foydalanish |
| `Main()` | Dastur bajarilishi boshlanadigan asosiy metod |

---
**Fan:** Dasturlash 1  
**Mavzu:** Kirish. Dasturlash tillari. .NET platformasi. Visual Studio muhiti. C# da birinchi dastur.
