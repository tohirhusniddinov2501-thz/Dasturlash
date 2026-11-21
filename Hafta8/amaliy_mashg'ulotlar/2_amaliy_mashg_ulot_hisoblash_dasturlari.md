# 2-Amaliy mashg'ulot: Hisoblash dasturlari

**Fan:** Dasturlash 1 (`DAS1110`)

**O'quv yili:** 2025/2026

**O'qituvchi:** Toshpolatov Muxiddin, PhD, dotsent

**Muassasa:** O'zbekiston Milliy universiteti Jizzax filiali, Amaliy matematika fakulteti

## Mashg'ulot maqsadi va rejasi

Ushbu amaliy mashg'ulot davomida talabalar foydalanuvchi kiritgan satrlarni son turlariga xavfsiz o'girish, `Math` sinfining tayyor matematik funksiyalaridan foydalanish hamda `if-else` va `switch` operatorlari yordamida qaror qabul qiluvchi dasturlar tuzishni mustahkamlaydilar:

* `Parse`, `Convert` va xavfsiz `TryParse` usullarini to'g'ri tanlash va qo'llash;

* `Math` sinfining asosiy funksiyalari (`Round`, `Pow`, `Sqrt`, `Max`, `Min`, `Abs`) bilan ishlash;

* Tarmoqlanuvchi algoritmlarni (`if-else if-else` va `switch-case`) amaliy masalalarda qo'llash.

### Reja:

1. Tezkor eslatma: satrni songa aylantirish va `Math` sinfi

2. **1-mashq:** *"Restoran hisob-kitobi"* (birga bajariladi)

3. **2-mashq:** *"Yosh toifasi aniqlovchi"* (mustaqil bajariladi)

4. **3-mashq (qo'shimcha):** *"BMI kalkulyatori"* (sintez mashqi)

5. Amaliyotda ko'p uchraydigan xatolar va uyga vazifa

## 1. Tezkor eslatma: kerak bo'ladigan bilimlar

### Satrni songa aylantirish usullari

`Console.ReadLine()` har doim `string` qaytaradi. Uni hisoblashlarda ishlatish uchun son turiga o'girish zarur:

| Usul | Qachon ishlatiladi | Misol | 
| :--- | :--- | :--- | 
| `int.Parse(satr)` | Satr aniq to'g'ri butun son ekaniga ishonchingiz komil bo'lsa | `int yosh = int.Parse("20");` | 
| `Convert.ToInt32(satr)` | `Parse` ga o'xshaydi, `null` qiymatlarni ham xavfsiz (`0` sifatida) qayta ishlaydi | `int son = Convert.ToInt32("5");` | 
| `int.TryParse(satr, out son)` | Foydalanuvchi noto'g'ri matn kiritishi mumkin bo'lsa (**eng xavfsiz usul**) | `if (int.TryParse(s, out son)) { ... }` | 
| `double.Parse(satr)` | Haqiqiy (kasr) son kerak bo'lganda | `double narx = double.Parse("15.5");` | 

### `Math` sinfi — tayyor matematik funksiyalar

* `Math.Round(son, n)` — sonni $n$ xonali kasrgacha yaxlitlaydi;

* `Math.Pow(asos, daraja)` — asosni darajaga oshiradi (masalan, $\text{Math.Pow}(2, 3) = 2^3 = 8$);

* `Math.Sqrt(son)` — kvadrat ildiz ($\sqrt{x}$) hisoblaydi;

* `Math.Max(a, b)` / `Math.Min(a, b)` — ikkita sondan katta yoki kichigini qaytaradi;

* `Math.Abs(son)` — sonning modulini ($|x|$) qaytaradi.

## 2. Amaliy mashqlar

### 1-mashq: *"Restoran hisob-kitobi"* (Birga)

**Vazifa:** Taom miqdori va narxini so'rab, $10\%$ xizmat haqi bilan umumiy to'lov summasini hisoblang.

**Qo'llaniladigan vositalar:** `int.Parse`, `double.Parse`, arifmetik amallar, `Math.Round`, *string interpolation*.

```csharp
using System;

namespace Amaliy2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nechta taom: ");
            int miqdor = int.Parse(Console.ReadLine());

            Console.Write("Taom narxini kiriting: ");
            double narx = double.Parse(Console.ReadLine());

            double taomlarNarxi = Math.Round(narx * miqdor, 2);
            double xizmatHaqi = Math.Round(taomlarNarxi * 0.10, 2);
            double jamiTolov = Math.Round(taomlarNarxi + xizmatHaqi, 2);

            Console.WriteLine();
            Console.WriteLine($"Taomlar narxi:     {taomlarNarxi} so'm");
            Console.WriteLine($"Xizmat haqi (10%): {xizmatHaqi} so'm");
            Console.WriteLine($"JAMI TO'LOV:       {jamiTolov} so'm");
        }
    }
}
```

**Kutilgan natija (Console chiqishi):**

```text
Nechta taom: 3
Taom narxini kiriting: 25000

Taomlar narxi:     75000 so'm
Xizmat haqi (10%): 7500 so'm
JAMI TO'LOV:       82500 so'm
```

### 2-mashq: *"Yosh toifasi aniqlovchi"* (Mustaqil)

**Vazifa:** Foydalanuvchi yoshini so'rab, `if-else if-else` yordamida toifani aniqlang:
* $0\text{–}12$: `"Bola"`
* $13\text{–}17$: `"O'smir"`
* $18\text{–}59$: `"Kattalar"`
* $60+$: `"Keksa"`

**Maslahat:** `int.TryParse()` dan foydalaning — agar foydalanuvchi son o'rniga harf kiritsa, dastur xatolik bilan to'xtab qolmasdan `"Noto'g'ri son kiritildi!"` xabarini chiqarishi kerak.

```csharp
using System;

namespace Amaliy2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yoshingizni kiriting: ");
            string kiritma = Console.ReadLine();

            if (!int.TryParse(kiritma, out int yosh) || yosh < 0)
            {
                Console.WriteLine("Noto'g'ri son kiritildi!");
                return;
            }

            if (yosh <= 12)
            {
                Console.WriteLine("Toifa: Bola");
            }
            else if (yosh <= 17)
            {
                Console.WriteLine("Toifa: O'smir");
            }
            else if (yosh <= 59)
            {
                Console.WriteLine("Toifa: Kattalar");
            }
            else
            {
                Console.WriteLine("Toifa: Keksa");
            }
        }
    }
}
```

### 3-mashq (Qo'shimcha): *"BMI kalkulyatori"* — sintez mashqi

**Vazifa:** Bo'y (metrda) va vaznni ($\text{kg}$) so'rab, tana vazni indeksini $\text{BMI} = \frac{\text{vazn}}{\text{bo'y}^2}$ formulasi bilan hisoblang. Natijani `Math.Round` bilan $1$ xonali kasrgacha yaxlitlang va toifani aniqlang:
* $< 18.5$: `"Kam vazn"`
* $18.5\text{–}24.9$: `"Normal"`
* $25+$: `"Ortiqcha vazn"`

```csharp
using System;

namespace Amaliy2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bo'yingizni kiriting (metrda, masalan 1.75): ");
            if (!double.TryParse(Console.ReadLine(), out double boy) || boy <= 0)
            {
                Console.WriteLine("Noto'g'ri bo'y kiritildi!");
                return;
            }

            Console.Write("Vazningizni kiriting (kg): ");
            if (!double.TryParse(Console.ReadLine(), out double vazn) || vazn <= 0)
            {
                Console.WriteLine("Noto'g'ri vazn kiritildi!");
                return;
            }

            double bmi = Math.Round(vazn / Math.Pow(boy, 2), 1);
            Console.WriteLine($"Sizning BMI ko'rsatkichingiz: {bmi}");

            if (bmi < 18.5)
            {
                Console.WriteLine("Toifa: Kam vazn");
            }
            else if (bmi <= 24.9)
            {
                Console.WriteLine("Toifa: Normal");
            }
            else
            {
                Console.WriteLine("Toifa: Ortiqcha vazn");
            }
        }
    }
}
```

## Diqqat: Amaliyotda ko'p uchraydigan xatolar

1. **Noto'g'ri satrni `Parse` qilish:** `int.Parse("abc")` dasturni `FormatException` xatosi bilan to'xtatib qo'yadi; foydalanuvchi kiritmasi uchun `TryParse` xavfsizroq.

2. **Butun sonlar (`int`) bo'linishi:** `5 / 2` natijasi `2` chiqadi; kasr qism saqlanishi uchun kamida bitta operand `double` bo'lishi kerak (`5.0 / 2`).

3. **`if` sharti oxiriga `;` qo'yish:** `if (shart); { ... }` — nuqta-vergul shartni blokdan ajratib qo'yadi.

4. **`using System;` yo'qligi:** `Math` sinfidan foydalanish uchun fayl boshida `using System;` bo'lishi shart.

## Uyga vazifa (`topshiriqlar/topshiriq-02.cs`)

1. **Oddiy kalkulyator (`switch`):** Ikki son va amal belgisini (`+`, `-`, `*`, `/`) so'rab, natijani hisoblovchi dastur yozing (nolga bo'lish holatini tekshiring).

2. **Baho aniqlovchi:** $100$ ballik tizimda kiritilgan balni $5$ baholik tizimga (`2`, `3`, `4`, `5`) o'giruvchi dastur tuzing.

3. *(Qo'shimcha)* **Chegirmali restoran hisob-kitobi:** 1-mashqdagi dasturga chegirma kodi kiritish imkoniyatini qo'shing — agar kod `"STUDENT10"` bo'lsa, umumiy taomlar narxidan $10\%$ chegirma hisoblansin.

```csharp
using System;

namespace Topshiriq2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-topshiriq: Oddiy kalkulyator (switch)
            Console.WriteLine("=== 1. ODDIY KALKULYATOR ===");
            Console.Write("1-sonni kiriting: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Amalni kiriting (+, -, *, /): ");
            string amal = Console.ReadLine();

            Console.Write("2-sonni kiriting: ");
            double b = double.Parse(Console.ReadLine());

            switch (amal)
            {
                case "+":
                    Console.WriteLine($"Natija: {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"Natija: {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"Natija: {a * b}");
                    break;
                case "/":
                    if (b != 0)
                        Console.WriteLine($"Natija: {a / b}");
                    else
                        Console.WriteLine("Xato: Nolga bo'lish mumkin emas!");
                    break;
                default:
                    Console.WriteLine("Noto'g'ri amal kiritildi!");
                    break;
            }

            // 2-topshiriq: Baho aniqlovchi (100 ballik -> 5 baholik)
            Console.WriteLine();
            Console.WriteLine("=== 2. BAHO ANIQLOVCHI ===");
            Console.Write("Ballni kiriting (0-100): ");
            if (int.TryParse(Console.ReadLine(), out int ball) && ball >= 0 && ball <= 100)
            {
                int baho;
                if (ball >= 86) baho = 5;
                else if (ball >= 71) baho = 4;
                else if (ball >= 56) baho = 3;
                else baho = 2;

                Console.WriteLine($"Sizning bahoingiz: {baho}");
            }
            else
            {
                Console.WriteLine("Noto'g'ri ball kiritildi!");
            }

            // 3-topshiriq (Qo'shimcha): Chegirma kodli restoran hisob-kitobi
            Console.WriteLine();
            Console.WriteLine("=== 3. RESTORAN HISOB-KITOBI (CHEGIRMA BILAN) ===");
            Console.Write("Nechta taom: ");
            int miqdor = int.Parse(Console.ReadLine());

            Console.Write("Taom narxini kiriting: ");
            double narx = double.Parse(Console.ReadLine());

            Console.Write("Chegirma kodini kiriting (bo'lmasa Enter): ");
            string kod = Console.ReadLine();

            double taomlarNarxi = narx * miqdor;
            double chegirma = (kod == "STUDENT10") ? taomlarNarxi * 0.10 : 0;
            double chegirmadanKeyin = taomlarNarxi - chegirma;
            double xizmatHaqi = chegirmadanKeyin * 0.10;
            double jami = Math.Round(chegirmadanKeyin + xizmatHaqi, 2);

            Console.WriteLine($"Taomlar narxi:     {taomlarNarxi} so'm");
            Console.WriteLine($"Chegirma (10%):    -{chegirma} so'm");
            Console.WriteLine($"Xizmat haqi (10%): {xizmatHaqi} so'm");
            Console.WriteLine($"JAMI TO'LOV:       {jami} so'm");
        }
    }
}
```

## Xulosa

* Satrlarni sonlarga `Parse`, `Convert` va xavfsiz `TryParse` yordamida o'girish amalda qo'llanildi.
* `Math` sinfining `Round` va `Pow` funksiyalari bilan hisoblash dasturlari tuzildi.
* `if-else if-else` va `switch` operatorlari orqali dasturga tarmoqlanuvchi mantiq kiritildi.
* **Keyingi amaliy mashg'ulot:** Sikllar (`for`, `while`, `do-while`) va Visual Studio *debugger* bilan tanishuv.