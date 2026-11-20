# 5-Ma'ruza: Massivlar

**Fan:** Dasturlash 1 (DAS1110)  
**O'quv yili:** 2025/2026  
**O'qituvchi:** Toshpolatov Muxiddin, PhD, dotsent  
**Muassasa:** O'zbekiston Milliy universiteti Jizzax filiali, Amaliy matematika fakulteti  

---

## Darsning maqsadi va rejasi

Ushbu ma'ruza yakunida talabalar C# tilida massivlar bilan ishlashning asosiy tamoyillarini o'zlashtiradilar:
* Massiv nima ekanini va uni nima uchun ishlatish kerakligini tushuntirish;
* Bir o'lchamli massivni e'lon qilish va uning elementlariga indeks orqali murojaat qilish;
* Ko'p o'lchamli (ikki o'lchamli) massivlar bilan ishlash;
* `foreach` operatoridan foydalanib massiv elementlarini ketma-ket aylanib chiqish;
* `Random` klassi yordamida massivni tasodifiy sonlar bilan to'ldirish.

### Reja:
1. **I-Bo'lim:** Massiv tushunchasi va bir o'lchamli massivlar
2. **II-Bo'lim:** Ko'p o'lchamli massivlar va `foreach` operatori
3. **III-Bo'lim:** Massivni to'ldirish usullari (`Random` klassi)

---

## I-Bo'lim: Massiv tushunchasi va bir o'lchamli massivlar

### 1. Massiv (Array) nima uchun kerak?

Tasavvur qiling, dasturda 30 nafar talabaning bahosini saqlash va qayta ishlash kerak. Buning uchun 30 ta alohida o'zgaruvchi (`ball1`, `ball2`, ..., `ball30`) yaratish noqulay va samarasizdir.

**Massiv (array)** — **bir xil turdagi** bir nechta qiymatni **bitta nom** ostida, kompyuter xotirasida **ketma-ket** saqlovchi ma'lumotlar tuzilmasidir.

* Har bir element massiv ichida o'zining **indeksi** (tartib raqami) orqali aniqlanadi.
* C# tilida massiv indekslari **har doim $0$ dan boshlanadi**. $N$ ta elementdan iborat massivning oxirgi indeksi $N - 1$ ga teng bo'ladi.

### 2. Bir o'lchamli massivni e'lon qilish

**Sintaksisi:**
```csharp
tur[] nom = new tur[olcham];
```

* Masalan, `int[] ballar = new int[5];` — $5$ ta butun son (`int`) saqlay oladigan massiv yaratadi.
* Massiv yaratilgan zahoti uning barcha elementlari o'z turining **standart (default)** qiymati bilan to'ldiriladi: `int` uchun `0`, `bool` uchun `false`, `string` uchun `null`.
* Massiv o'lchami yaratilgandan so'ng **o'zgartirilmaydi** (doimiy bo'ladi). Agar kattaroq joy kerak bo'lsa, yangi massiv yaratish lozim.

### 3. Elementlarga murojaat qilish va `.Length` xususiyati

Elementga murojaat `massivNomi[indeks]` ko'rinishida amalga oshiriladi. Massivning umumiy elementlar sonini aniqlash uchun `.Length` xususiyatidan foydalaniladi.

```csharp
int[] ballar = new int[5];

ballar[0] = 85; // Birinchi elementga qiymat berish
ballar[1] = 92; // Ikkinchi elementga qiymat berish

Console.WriteLine(ballar[0]);       // Natija: 85
Console.WriteLine(ballar.Length);   // Natija: 5 (massiv uzunligi)
```

> **Diqqat:** Mavjud bo'lmagan indeksga murojaat qilish (masalan, $5$ elementli massivda `ballar[5]`) dastur bajarilishida **`IndexOutOfRangeException`** xatosini keltirib chiqaradi.

#### Qatorlab e'lon qilish va `for` sikli bilan aylanish

Massivni yaratish paytida uning boshlang'ich qiymatlarini figurali qavslar `{ }` ichida darhol berish ham mumkin:

```csharp
int[] ballar = new int[] { 85, 92, 78 };

for (int i = 0; i < ballar.Length; i++)
{
    Console.WriteLine(ballar[i]);
}
// Natija: 85, 92, 78 (har biri yangi qatorda)
```

---

## II-Bo'lim: Ko'p o'lchamli massivlar va `foreach`

### 1. Ko'p o'lchamli (ikki o'lchamli) massivlar

Bir o'lchamli massiv bitta qator (ro'yxat) ko'rinishidagi ma'lumotlarni saqlasa, **ikki o'lchamli massiv** ma'lumotlarni **jadval (qator va ustunlar)** ko'rinishida saqlash uchun ishlatiladi (masalan, sinf jurnali: qator — talaba, ustun — fan bahosi).

* **E'lon qilish:** `int[,] jadval = new int[3, 4];` ($3$ qator va $4$ ustundan iborat jadval).
* **Murojaat qilish:** `jadval[qator, ustun]` (indekslar bu yerda ham $0$ dan boshlanadi).

```csharp
int[,] jadval = new int[2, 3];

jadval[0, 0] = 85; // 1-qator, 1-ustun
jadval[1, 2] = 90; // 2-qator, 3-ustun

Console.WriteLine(jadval[0, 0]); // Natija: 85
Console.WriteLine(jadval[1, 2]); // Natija: 90
```

### 2. `foreach` operatori

`foreach` operatori massiv yoki boshqa to'plam elementlarini **indekslarsiz**, boshidan oxirigacha ketma-ket aylanib chiqish imkonini beradi.

**Sintaksisi:**
```csharp
foreach (tur element in massivNomi)
{
    // element bilan ishlash
}
```

```csharp
int[] ballar = new int[] { 85, 92, 78 };

foreach (int ball in ballar)
{
    Console.WriteLine(ball);
}
// Natija: 85, 92, 78
```

> **Muhim:** `foreach` sikli massiv elementlarini faqat **o'qish** uchun mo'ljallangan. Sikl ichida `ball = 100;` deb yozish orqali massivning asl elementlarini o'zgartirib bo'lmaydi — elementlarni o'zgartirish uchun `for` sikli va indeks kerak bo'ladi.

---

## III-Bo'lim: Massivni to'ldirish usullari

Massiv elementlariga qiymat kiritishning 4 ta asosiy usuli mavjud:
1. **Qo'lda alohida qiymat berish:** `ballar[0] = 85;` — elementlar soni kam bo'lganda qulay.
2. **Qatorlab e'lon qilish:** `int[] ballar = { 85, 92, 78 };` — qiymatlar oldindan ma'lum bo'lganda.
3. **Sikl va foydalanuvchi kiritishi orqali:** `for` sikli ichida `Console.ReadLine()` yordamida qiymatlarni navbat bilan o'qish.
4. **Tasodifiy sonlar bilan avtomatik to'ldirish:** `Random` klassi yordamida.

### `Random` klassi yordamida massivni to'ldirish

C# tilining `System` nomlar fazosidagi `Random` klassi tasodifiy sonlar yaratish uchun xizmat qiladi:
* Avval `Random` klassidan bitta obyekt yaratiladi: `Random rnd = new Random();`
* `rnd.Next(min, max)` metodi `min` (**kiritilgan**) dan `max` (**kiritilmagan**) gacha bo'lgan oraliqda tasodifiy butun son qaytaradi.

```csharp
int[] sonlar = new int[5];
Random rnd = new Random();

for (int i = 0; i < sonlar.Length; i++)
{
    // 1 dan 100 gacha (101 kirmaydi) tasodifiy son berish
    sonlar[i] = rnd.Next(1, 101);
}

foreach (int son in sonlar)
{
    Console.WriteLine(son);
}
```

---

## Yangi boshlovchilar ko'p qiladigan xatolar

1. **Massiv indeksini $1$ dan boshlanadi deb o'ylash:** C# da indekslar har doim $0$ dan boshlanadi.
2. **Massiv chegarasidan tashqariga chiqish:** $5$ elementli massivda oxirgi indeks `4` ga teng; `ballar[5]` ga murojaat `IndexOutOfRangeException` xatosini beradi.
3. **Massiv o'lchamini keyin o'zgartirishga urinish:** yaratilgan massiv o'lchami o'zgarmasdir.
4. **`foreach` ichida massiv elementini o'zgartirishga urinish:** element qiymatini yangilash uchun `for` va indeksdan foydalanish shart.
5. **`new Random()` obyektini sikl ichida qayta-qayta yaratish:** bu bir xil sonlar ketma-ketligi chiqishiga olib kelishi mumkin; `Random` sikldan tashqarida faqat **bir marta** yaratilishi kerak.

---

## O'z-o'zini tekshirish savollari (Viktorina)

1. **C# da massiv indekslari nechadan boshlanadi?**  
   *Javob:* **$0$ dan** boshlanadi ($N$ elementli massivning oxirgi indeksi $N - 1$).
2. **`foreach` operatori haqida qaysi fikr to'g'ri?**  
   *Javob:* Massiv elementlarini indekssiz, ketma-ket o'qish uchun qulay, lekin sikl o'zgaruvchisiga yangi qiymat berish orqali massiv elementlarini o'zgartirib bo'lmaydi.
3. **`rnd.Next(1, 101)` metodi qaysi oraliqdagi sonlarni qaytaradi?**  
   *Javob:* **$1$ dan $100$ gacha** (`min` kiradi, `max` kirmaydi).

---

## Amaliy mustaqil topshiriq

1. $10$ ta `int` elementdan iborat massivni qatorlab e'lon qiling va `foreach` sikli yordamida uning barcha elementlarini ekranga chiqaring.
2. Yuqoridagi massiv elementlarining **umumiy yig'indisini** `for` sikli va `.Length` xususiyati yordamida hisoblang.
3. `Random` klassidan foydalanib, $5$ ta elementli massivni $1$ dan $6$ gacha (zar/kubik o'yini kabi) tasodifiy sonlar bilan to'ldiring va konsolga chiqaring.
4. *(Qo'shimcha)* $3 \times 3$ o'lchamli ikki o'lchamli massiv yarating va uni ikkita **ichma-ich `for` sikli** yordamida to'ldirib, jadval ko'rinishida ekranga chiqaring.

---

## Foydali adabiyotlar va manbalar

* Adambayev U.E. va b. *"Algoritmik tillar va dasturlash. C# tilida dasturlash asoslari"* (2023)
* Mo'minov B.B. *"Dasturlash 1"* (2021)
* Albahari B. *"C# 7.0. Справочник"* (2018)
* [metanit.com/sharp/tutorial](https://metanit.com/sharp/tutorial/) — Massivlar bo'limi
* [learn.microsoft.com/dotnet/csharp/programming-guide/arrays](https://learn.microsoft.com/dotnet/csharp/programming-guide/arrays/) — Rasmiy C# massivlar qo'llanmasi
* [dastur.uz](https://www.dastur.uz/) — O'zbek tilida dasturlash resurslari