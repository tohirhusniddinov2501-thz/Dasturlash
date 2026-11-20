# 6-Ma'ruza: Belgi, Satrlar va Metodlar

**Fan:** Dasturlash 1 (DAS1110)

**O'quv yili:** 2025/2026

**O'qituvchi:** Toshpolatov Muxiddin, PhD, dotsent

**Muassasa:** O'zbekiston Milliy universiteti Jizzax filiali, Amaliy matematika fakulteti

## Darsning maqsadi va rejasi

Ushbu ma'ruza yakunida talabalar belgilar va satrlar bilan ishlash hamda dastur kodini metodlarga ajratishni o'zlashtiradilar:

* `char` turi ustidagi tayyor funksiyalardan (`IsDigit`, `IsLetter`, `ToUpper`, `ToLower` va h.k.) foydalanish;

* Satrlar (`string`) ustida asosiy amallarni (`Length`, `Substring`, `IndexOf`, `Contains`, `Replace`, `Split`, `Trim`, `ToUpper`/`ToLower`) bajarish;

* Sonlar va satrlarni formatlab chiqarish (`string interpolation`, `ToString("N2")`, `DateTime.Now.ToString(...)`, `StringBuilder`);

* Parametrli va qiymat qaytaruvchi metodlar yozish;

* `params`, metodlarni qayta yuklash (*overloading*), rekursiya hamda `ref` va `out` kalit so'zlaridan foydalanish.

### Reja:

1. **I-Bo'lim:** Belgi (`char`) turi va funksiyalari

2. **II-Bo'lim:** Belgilar massivi va satrlar ustida amallar

3. **III-Bo'lim:** Satrlarni formatlash va `StringBuilder`

4. **IV-Bo'lim:** Metodlar bilan ishlash — e'lon qilish, parametrlar va qiymat qaytarish

5. **V-Bo'lim:** Metodlarning qo'shimcha imkoniyatlari (`params`, qayta yuklash, rekursiya)

6. **VI-Bo'lim:** Qiymat/havola turlari, `ref` va `out` kalit so'zlari

## I-Bo'lim: Belgi (`char`) turi va funksiyalari

`char` — bitta belgini saqlovchi tur bo'lib, C# tilida u ustida tekshirish va o'zgartirish bajaruvchi qulay funksiyalar mavjud:

* `char.IsDigit(belgi)` — belgi raqam (`0–9`) bo'lsa `true` qaytaradi;

* `char.IsLetter(belgi)` — belgi harf bo'lsa `true` qaytaradi;

* `char.IsUpper(belgi)` / `char.IsLower(belgi)` — belgi katta yoki kichik harf ekanini tekshiradi;

* `char.ToUpper(belgi)` / `char.ToLower(belgi)` — belgini katta yoki kichik harfga o'giradi.

```csharp
char belgi = 'a';

Console.WriteLine(char.IsLetter(belgi));  // True
Console.WriteLine(char.IsDigit(belgi));   // False
Console.WriteLine(char.ToUpper(belgi));   // A
```

## II-Bo'lim: Belgilar massivi va satrlar ustida amallar

### 1. Satr (`string`) va belgilar massivi (`char[]`)

Satr (`string`) — belgilar ketma-ketligidir. Satrning alohida belgisiga indeks orqali murojaat qilish (`satr[0]`) va uni belgilar massiviga aylantirish (`char[] belgilar = satr.ToCharArray();`) mumkin.

> **Muhim:** C# tilida `string` **o'zgarmas (*immutable*)** turdir. Mavjud satrning biror belgisini to'g'ridan-to'g'ri o'zgartirib bo'lmaydi (masalan, `satr[0] = 'X';` kompilyatsiya xatosi beradi) — satrni faqat yangi satr yaratish orqali o'zgartirish mumkin.

### 2. Satrlar ustida eng ko'p ishlatiladigan amallar

| Metod / Xossa | Vazifasi | Misol | Natija |
| :--- | :--- | :--- | :--- |
| `Length` | Satr uzunligini (belgilar sonini) qaytaradi | `"Salom".Length` | `5` |
| `Substring(i, n)` | `i` indeksdan boshlab `n` ta belgini ajratib oladi | `"Salom".Substring(0, 2)` | `"Sa"` |
| `IndexOf(s)` | `s` qism-satr qaysi indeksda boshlanishini topadi | `"Salom".IndexOf("lo")` | `2` |
| `Contains(s)` | Satr ichida `s` bor-yo'qligini tekshiradi | `"Salom".Contains("al")` | `true` |
| `Replace(a, b)` | `a` qism-satrni `b` ga almashtiradi | `"Salom".Replace("a", "o")` | `"Solom"` |
| `Split(belgi)` | Satrni ko'rsatilgan belgi bo'yicha qismlarga ajratadi | `"a,b,c".Split(',')` | `["a", "b", "c"]` |
| `Trim()` | Satr boshi va oxiridagi bo'sh joylarni olib tashlaydi | `"  Salom  ".Trim()` | `"Salom"` |
| `ToUpper()` / `ToLower()` | Satrni katta yoki kichik harflarga o'giradi | `"Salom".ToUpper()` | `"SALOM"` |

```csharp
string ism = "  Aziza Karimova  ";
string toza = ism.Trim();

Console.WriteLine(toza.Length);          // 14
Console.WriteLine(toza.ToUpper());         // AZIZA KARIMOVA

string[] qismlar = toza.Split(' ');
Console.WriteLine(qismlar[0]);           // Aziza
```

## III-Bo'lim: Satrlarni formatlash va `StringBuilder`

### 1. String interpolation va format spetsifikatorlari

* **String interpolation (`$"...{ }"`):** o'zgaruvchilarni to'g'ridan-to'g'ri matn ichiga joylashtirish usuli: `$"Ism: {ism}, Yosh: {yosh}"`.

* **Sonni formatlash (`ToString("N2")`):** `"N2"` spetsifikatori sonni minglik ajratgich va $2$ xonali kasr qism bilan chiqaradi (`1234.567` $\rightarrow$ `"1,234.57"`). Boshqa spetsifikatorlar: `N` — son, `C` — valyuta, `P` — foiz, `D` — butun son uzunligi.

* **Sana formatlash:** `DateTime.Now.ToString("dd.MM.yyyy")` — joriy sanani `kun.oy.yil` formatida qaytaradi.

```csharp
double narx = 1234.567;
Console.WriteLine(narx.ToString("N2")); // 1,234.57

string ism = "Aziza";
int yosh = 20;
Console.WriteLine($"Ism: {ism}, Yosh: {yosh}"); // Ism: Aziza, Yosh: 20
```

### 2. O'zgaruvchan satrlar: `StringBuilder`

`string` o'zgarmas bo'lgani uchun siklda ko'p marta satr qo'shib borish (`+=`) har safar yangi satr yaratib, xotirani samarasiz ishlatadi. Ko'p marta satrni o'zgartirish yoki qo'shish zarur bo'lganda **`StringBuilder`** klassi ishlatiladi:

```csharp
using System.Text;

StringBuilder sb = new StringBuilder();
sb.Append("Salom, ");
sb.Append("Dunyo!");
string natija = sb.ToString();
Console.WriteLine(natija); // Salom, Dunyo!
```

## IV-Bo'lim: Metodlar bilan ishlash

### 1. Metod nima va nega kerak?

**Metod** — muayyan vazifani bajaruvchi, nom berilgan kod bloki. Metodlar kodni takrorlamaslik (**DRY — *Don't Repeat Yourself***), dasturni tuzilgan va tushunarli qilish hamda xatolarni oson topishga yordam beradi.

### 2. Metod e'lon qilish va chaqirish

**Sintaksisi:**

```csharp
modifikator qaytariladigan_tur MetodNomi(parametrlar)
{
    // bajariladigan kod
}
```

* `static` — hozircha `Main()` kabi metodlarni sinf obyektisiz chaqirish uchun ishlatiladi.

* `void` — metod hech qanday qiymat **qaytarmasligini** bildiradi.

```csharp
static void Salomla()
{
    Console.WriteLine("Salom!");
}

// Chaqirish:
Salomla();
Salomla();
```

### 3. Parametrlar, argumentlar va qiymat qaytarish (`return`)

* Metod e'lonidagi o'zgaruvchilar **parametrlar**, chaqirish paytida uzatiladigan qiymatlar esa **argumentlar** deyiladi.

* Agar metod natija qaytarsa, `void` o'rniga qaytariladigan tur (`int`, `string`, `bool` va h.k.) yoziladi va `return` kalit so'zi orqali qiymat qaytariladi (`return` metodni shu nuqtada yakunlaydi).

```csharp
static int Yigindi(int a, int b)
{
    return a + b;
}

int natija = Yigindi(5, 7);
Console.WriteLine(natija); // 12
```

#### Kelishuv bo'yicha parametrlar (*Default parameters*)

Parametrga standart qiymat berish mumkin (`static void Salomla(string ism = "Mehmon")`). Argument berilmasa standart qiymat ishlatiladi. Bunday parametrlar parametrlar ro'yxatining **oxirida** joylashishi shart.

## V-Bo'lim: Metodlarning qo'shimcha imkoniyatlari

### 1. Massiv parametrlar va `params` kalit so'zi

Massivlar havola (*reference*) turi bo'lgani uchun metod ichida massiv elementiga kiritilgan o'zgarish tashqariga ham ta'sir qiladi. Agar metodga nechta argument uzatilishi oldindan noma'lum bo'lsa, **`params`** kalit so'zi ishlatiladi (`params` parametrlar ro'yxatining oxirida va faqat bitta bo'lishi mumkin):

```csharp
static int Yigindi(params int[] sonlar)
{
    int jami = 0;
    foreach (int s in sonlar)
    {
        jami += s;
    }
    return jami;
}

Console.WriteLine(Yigindi(1, 2));       // 3
Console.WriteLine(Yigindi(1, 2, 3, 4)); // 10
```

### 2. Metodlarni qayta yuklash (*Overloading*)

**Qayta yuklash** — bir xil nomga ega, lekin parametrlarining **soni** yoki **turi** farq qiluvchi bir nechta metod yaratish imkoniyatidir (masalan, `int Yigindi(int a, int b)` va `double Yigindi(double a, double b)`). C# uzatilgan argumentlarga qarab mos metodni avtomatik tanlaydi.

### 3. Rekursiv metodlar

**Rekursiya** — metodning o'zini-o'zi chaqirishidir. Har bir rekursiv metodda:

1. **Baza holati** (to'xtash sharti) bo'lishi **shart** — aks holda cheksiz chaqiruv yuz berib, `StackOverflowException` xatosi chiqadi;

2. **Rekursiv chaqiruv** (masalani kichikroq holatga keltirib o'zini chaqirish) bo'ladi.

```csharp
static int Faktorial(int n)
{
    if (n <= 1) // baza holati
    {
        return 1;
    }
    return n * Faktorial(n - 1); // rekursiv chaqiruv
}

Console.WriteLine(Faktorial(5)); // 120
```

## VI-Bo'lim: Qiymat/havola turlari, `ref` va `out`

* **Qiymat turlari** (`int`, `bool`, `double` va h.k.) odatda metodga qiymat **nusxasi** sifatida uzatiladi — metod ichidagi o'zgarish tashqi o'zgaruvchiga ta'sir qilmaydi.

* **Havola turlari** (massivlar, klasslar) metodga xotiradagi **havola (manzil)** orqali uzatiladi.

### `ref` kalit so'zi

`ref` qiymat turini ham metodga **havola** orqali uzatishga imkon beradi. Uzatilayotgan o'zgaruvchi chaqirishdan **oldin** qiymatga ega bo'lishi shart, va `ref` kalit so'zi ham metod e'lonida, ham chaqirishda yoziladi:

```csharp
static void Ikkilantir(ref int son)
{
    son = son * 2;
}

int x = 5;
Ikkilantir(ref x);
Console.WriteLine(x); // 10
```

### `out` kalit so'zi

`out` ham havola orqali uzatadi, lekin o'zgaruvchi metodga kirishda **oldindan** qiymatga ega bo'lishi shart emas; biroq metod **ichida** unga albatta qiymat berilishi shart. Ko'pincha metoddan bir nechta natija qaytarishda qo'llaniladi:

```csharp
static void KvadratVaKub(int son, out int kvadrat, out int kub)
{
    kvadrat = son * son;
    kub = son * son * son;
}

KvadratVaKub(3, out int kv, out int kb);
Console.WriteLine($"Kvadrat: {kv}, Kub: {kb}"); // Kvadrat: 9, Kub: 27
```

## Yangi boshlovchilar ko'p qiladigan xatolar

1. **`string` belgisini to'g'ridan-to'g'ri o'zgartirish:** `satr[0] = 'X';` — *xato*, chunki `string` o'zgarmas (*immutable*).

2. **Metodni chaqirishda `()` qavsni unutish:** parametrsiz metod chaqirilganda ham `()` majburiy.

3. **`void` metoddan qiymat qaytarishga urinish:** `void` metod `return qiymat;` qaytara olmaydi.

4. **Rekursiyada baza holatini yozmaslik:** `StackOverflowException` ga olib keladi.

5. **`ref` yoki `out` ni chaqirishda yozmaslik:** ham e'londa, ham chaqirishda ko'rsatilishi shart.

## O'z-o'zini tekshirish savollari (Viktorina)

1. **`char.IsDigit('5')` qanday natija qaytaradi?**

   * *Javob:* `true`, chunki `'5'` raqam belgisidir.

2. **`string` turining o'zgarmasligi (*immutability*) nimani anglatadi?**

   * *Javob:* Mavjud satrning ayrim belgisini joyida o'zgartirib bo'lmaydi, faqat yangi satr hosil qilinadi.

3. **`narx.ToString("N2")` nima qiladi?**

   * *Javob:* Sonni minglik ajratgich va $2$ ta kasr xona bilan formatlaydi.

4. **`void` va qiymat qaytaruvchi tur (`int`, `string`) orasidagi farq nima?**

   * *Javob:* `void` qiymat qaytarmaydi, `int`/`string` esa `return` orqali shu turdagi qiymat qaytarishi shart.

5. **Rekursiv metodda baza holati nima uchun kerak?**

   * *Javob:* Rekursiyani to'xtatish uchun — aks holda cheksiz chaqiruv va `StackOverflowException` yuzaga keladi.

6. **`ref` va `out` orasidagi asosiy farq nima?**

   * *Javob:* `ref` o'zgaruvchisi chaqirishdan oldin qiymatga ega bo'lishi shart; `out` o'zgaruvchisi esa oldindan qiymatsiz bo'lishi mumkin, lekin metod ichida albatta qiymat olishi shart.

## Amaliy mustaqil topshiriq

1. Kiritilgan satrda nechta unli harf borligini hisoblovchi dastur yozing (`char.IsLetter` va harflarni solishtirishdan foydalaning).

2. Ikkita butun sonni qabul qilib, ularning kattasini qaytaruvchi `static int Katta(int a, int b)` metodini yozing.

3. `params` kalit so'zi yordamida ixtiyoriy sondagi sonlarning o'rtacha qiymatini hisoblovchi metod tuzing.

4. *(Qo'shimcha)* Fibonachchi sonini ($0, 1, 1, 2, 3, 5, 8, \dots$) rekursiya yordamida hisoblovchi metod yozing.

## Foydali adabiyotlar va manbalar

* Adambayev U.E. va b. *"Algoritmik tillar va dasturlash. C# tilida dasturlash asoslari"* (2023)

* Mo'minov B.B. *"Dasturlash 1"* (2021)

* Albahari B. *"C# 7.0. Справочник"* (2018)

* [metanit.com/sharp/tutorial](https://metanit.com/sharp/tutorial/) — Satrlar va Metodlar bo'limlari

* [learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/methods](https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/methods/) — Rasmiy C# metodlar qo'llanmasi

* [dastur.uz](https://www.dastur.uz/) — O'zbek tilida dasturlash resurslari