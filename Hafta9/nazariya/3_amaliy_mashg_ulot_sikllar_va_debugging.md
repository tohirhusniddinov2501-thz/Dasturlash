# 3-Amaliy mashg'ulot: Sikllar va Debugging

**Fan:** Dasturlash 1 (`DAS1110`)

**O'quv yili:** 2025/2026

**O'qituvchi:** Toshpolatov Muxiddin, PhD, dotsent

**Muassasa:** O'zbekiston Milliy universiteti Jizzax filiali, Amaliy matematika fakulteti

## Mashg'ulot maqsadi va rejasi

Ushbu amaliy mashg'ulot davomida talabalar takrorlanuvchi jarayonlarni (`while`, `for`, ichma-ich `for`) dasturlash hamda **Visual Studio Debugger** vositalari yordamida koddagi mantiqiy xatolarni aniqlab tuzatishni o'zlashtiradilar:

* `while` sikli va `Random` klassi yordamida interaktiv o'yin mantiqini qurish;

* Bir o'lchamli va ikki o'lchamli (*nested*) `for` sikllari bilan jadval va naqshlar yaratish;

* Visual Studio muhitida *breakpoint* qo'yish, qadamma-qadam bajarish (`F10`, `F11`) va o'zgaruvchilar qiymatini kuzatish (`Locals`, `Watch`).

### Reja:

1. **1-mashq:** *"Son taxmin qilish o'yini"* (`while` sikli, birga bajariladi)

2. **2-mashq:** *"Ko'paytirish jadvali"* (ichma-ich `for`, mustaqil bajariladi)

3. **III-bo'lim:** Visual Studio Debugger bilan tanishuv

4. **3-mashq:** Debugging — cheksiz siklga tushgan dasturni tuzatish

5. Amaliyotda ko'p uchraydigan xatolar va uyga vazifa

## 1. Amaliy mashqlar

### 1-mashq: *"Son taxmin qilish o'yini"* (Birga)

**Vazifa:** Dastur $1$ dan $100$ gacha tasodifiy son o'ylaydi. Foydalanuvchi son kiritadi, dastur esa *"Kichikroq o'ylang!"* yoki *"Kattaroq o'ylang!"* deb yo'naltiradi va to'g'ri topilganda urinishlar sonini chiqaradi.

**Qo'llaniladigan vositalar:** `Random`, `while`, `if-else`, `int.TryParse`.

```csharp
using System;

namespace Amaliy3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int yashirinSon = rnd.Next(1, 101);
            int urinishlar = 0;
            int taxmin = 0;

            Console.WriteLine("1 dan 100 gacha son o'yladim. Topishga harakat qiling!");

            while (taxmin != yashirinSon)
            {
                Console.Write("Taxminingiz: ");
                if (!int.TryParse(Console.ReadLine(), out taxmin))
                {
                    Console.WriteLine("Iltimos, butun son kiriting!");
                    continue;
                }

                urinishlar++;

                if (taxmin > yashirinSon)
                {
                    Console.WriteLine("Kichikroq o'ylang!");
                }
                else if (taxmin < yashirinSon)
                {
                    Console.WriteLine("Kattaroq o'ylang!");
                }
            }

            Console.WriteLine($"TABRIKLAYMIZ! {urinishlar} ta urinishda topdingiz!");
        }
    }
}
```

**Kutilgan natija (Console chiqishi):**

```text
Taxminingiz: 50
Kichikroq o'ylang!
Taxminingiz: 25
Kattaroq o'ylang!
Taxminingiz: 42
TABRIKLAYMIZ! 3 ta urinishda topdingiz!
```

### 2-mashq: *"Ko'paytirish jadvali"* generatori (Mustaqil)

**Vazifa:** Foydalanuvchidan son so'rab, uning $1$ dan $10$ gacha ko'paytirish jadvalini chiqaring.  
**Qo'shimcha:** Ichma-ich (*nested*) `for` sikllari yordamida $1$ dan $10$ gacha barcha sonlarning to'liq $10 \times 10$ ko'paytirish jadvalini chiqaring.

```csharp
using System;

namespace Amaliy3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qaysi sonning ko'paytirish jadvali kerak? ");
            int son = int.Parse(Console.ReadLine());

            Console.WriteLine($"=== {son} uchun ko'paytirish jadvali ===");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{son} x {i} = {son * i}");
            }

            Console.WriteLine();
            Console.WriteLine("=== 1 dan 10 gacha to'liq ko'paytirish jadvali ===");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i}x{j}={i * j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
```

## 2. Visual Studio Debugger bilan tanishuv

**Debugging** — dasturdagi xatolarni (*bug*larni) aniqlash va tuzatish jarayoni.

| Tugma / Oyna | Vazifasi |
| :--- | :--- |
| **Breakpoint (`F9`)** | Kod qatoriga qo'yiladigan to'xtash nuqtasi (qizil nuqta) — dastur shu qatorga yetganda avtomatik to'xtaydi |
| **`F5` (Start Debugging)** | Dasturni *debug* rejimida ishga tushirish yoki keyingi *breakpoint*gacha davom ettirish |
| **`F10` (Step Over)** | Joriy qatorni bajarib, keyingi qatorga o'tish (metod ichiga kirmasdan) |
| **`F11` (Step Into)** | Agar joriy qatorda metod chaqirilsa, o'sha metod ichiga kirib qadamma-qadam kuzatish |
| **`Locals` / `Watch`** | O'zgaruvchilarning har bir qadamdagi joriy qiymatini kuzatish oynalari |
| **`Shift + F5`** | *Debug* jarayonini majburiy to'xtatish |

### 3-mashq: Debugging — buzilgan dasturni tuzatish

**Vazifa:** Cheksiz siklga tushib qoladigan kodga *breakpoint* qo'ying, `F10` bilan qadamma-qadam yurib sikl sharti nega `false` bo'lmayotganini aniqlang va bitta qator qo'shib dasturni tuzating.

```csharp
using System;

namespace Amaliy3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Buzilgan holatda i++ unutilgani sababli i doim 1 bo'lib qoladi
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine($"Joriy qiymat: {i}");
                i++; // Tuzatish: hisoblagichni har qadamda 1 ga oshirish
            }
        }
    }
}
```

## Diqqat: Amaliyotda ko'p uchraydigan xatolar

1. **`while` siklida hisoblagichni oshirishni unutish:** `i++` yozilmasa, shart doim `true` bo'lib, dastur cheksiz siklga tushadi.
2. **`Random` obyektini sikl ichida yaratish:** `new Random()` sikl tashqarisida bir marta yaratilishi kerak, aks holda bir xil sonlar takrorlanadi.
3. **Ichma-ich `for` sikllarida bir xil o'zgaruvchi ishlatish:** Tashqi sikl uchun `i`, ichki sikl uchun esa alohida `j` o'zgaruvchisidan foydalaning.

## Uyga vazifa (`topshiriqlar/topshiriq-03.cs`)

1. **Cheklangan urinishli o'yin:** *"Son taxmin qilish o'yini"*da urinishlar sonini $7$ ta bilan cheklang — topilmasa `"Ishdan chiqdingiz!"` xabari bilan dastur tugasin.
2. **$3$ ga bo'linadigan sonlar:** `for` sikli yordamida $1$ dan $50$ gacha bo'lgan $3$ ga bo'linadigan barcha sonlarni ekranga chiqaring.
3. *(Qo'shimcha)* **Yulduzcha piramida:** `for` sikli va `new string('*', i)` yordamida $4$ qatorli yulduzchalar piramidasini chiqaring.

```csharp
using System;

namespace Topshiriq3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-topshiriq: Son taxmin qilish o'yini (maksimum 7 urinish)
            Console.WriteLine("=== 1. SON TAXMIN QILISH O'YINI (MAX 7 URINISH) ===");
            Random rnd = new Random();
            int yashirinSon = rnd.Next(1, 101);
            int urinishlar = 0;
            int maxUrinish = 7;
            bool topildi = false;

            while (urinishlar < maxUrinish)
            {
                Console.Write($"Urinish {urinishlar + 1}/{maxUrinish} - Taxminingiz: ");
                if (!int.TryParse(Console.ReadLine(), out int taxmin))
                {
                    Console.WriteLine("Iltimos, butun son kiriting!");
                    continue;
                }

                urinishlar++;

                if (taxmin == yashirinSon)
                {
                    Console.WriteLine($"TABRIKLAYMIZ! {urinishlar} ta urinishda topdingiz!");
                    topildi = true;
                    break;
                }
                else if (taxmin > yashirinSon)
                {
                    Console.WriteLine("Kichikroq o'ylang!");
                }
                else
                {
                    Console.WriteLine("Kattaroq o'ylang!");
                }
            }

            if (!topildi)
            {
                Console.WriteLine($"Ishdan chiqdingiz! Yashirin son {yashirinSon} edi.");
            }

            // 2-topshiriq: 1 dan 50 gacha 3 ga bo'linadigan sonlar
            Console.WriteLine();
            Console.WriteLine("=== 2. 1 DAN 50 GACHA 3 GA BO'LINADIGAN SONLAR ===");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();

            // 3-topshiriq (Qo'shimcha): Yulduzcha piramida
            Console.WriteLine();
            Console.WriteLine("=== 3. YULDUZCHA PIRAMIDA ===");
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
    }
}
```

## Xulosa

* `while` sikli bilan *"shart bajarilguncha takrorlash"* algoritmi amalda qo'llanildi.
* Ichma-ich (`nested`) `for` sikllari yordamida $10 \times 10$ ko'paytirish jadvali va yulduzcha piramida shakllari yaratildi.
* Visual Studio *debugger* (`F9`, `F5`, `F10`, `Locals`/`Watch`) orqali koddagi xatolarni topish ko'nikmasi shakllantirildi.
* **Keyingi amaliy mashg'ulot:** Bir o'lchamli massivlar — qidirish, saralash va statistik hisoblash.