# 4-Ma'ruza: Operatorlar

**Fan:** Dasturlash 1 (DAS1110)

**O'quv yili:** 2025/2026

**O'qituvchi:** Toshpolatov Muxiddin, PhD, dotsent

**Muassasa:** O'zbekiston Milliy universiteti Jizzax filiali, Amaliy matematika fakulteti

## Darsning maqsadi va rejasi

Ushbu ma'ruza yakunida talabalar C# tilidagi shart va takrorlash operatorlari bilan ishlashni o'zlashtiradilar:

* Oddiy va qo'shma (blok) operator orasidagi farqni tushuntirish;
* `if`, `if-else`, `else if` va `switch-case` operatorlaridan foydalanib dasturga qaror qabul qilish mantiqini kiritish;
* `for`, `while` va `do-while` sikllarini to'g'ri yozish va ularni vaziyatga qarab tanlash;
* `break` va `continue` kalit so'zlari yordamida sikl bajarilishini boshqarish;
* Cheksiz sikl (*infinite loop*) va sintaktik xatolardan saqlanish.

### Reja:

1. **I-Bo'lim:** Oddiy/qo'shma operator va shart operatorlari (`if`, `if-else`, `switch-case`)
2. **II-Bo'lim:** Takrorlash operatori — `for` sikli
3. **III-Bo'lim:** Takrorlash operatorlari — `while`, `do-while` hamda `break`/`continue`

---

## I-Bo'lim: Oddiy/qo'shma operator va shart operatorlari

### 1. Oddiy va qo'shma operator (Statement)

**Operator (statement)** — dasturda bajariladigan bitta to'liq buyruq bo'lib, odatda nuqta-vergul (`;`) bilan tugaydi.

* **Oddiy operator** — yagona bitta buyruq:
  ```csharp
  Console.WriteLine("Salom");
  ```
* **Qo'shma operator (blok)** — figurali qavslar `{ }` ichiga olingan bir nechta operatorlar to'plami. Kompilyator uni yagona butunlik sifatida qabul qiladi. Shart va sikl operatorlari ko'pincha o'zidan keyin qo'shma operatorni bajaradi.

### 2. `if` operatori

`if` operatori biror mantiqiy shart rost (`true`) bo'lgandagina ma'lum kod blokini bajarish imkonini beradi.

```csharp
int yosh = 20;

if (yosh >= 18)
{
    Console.WriteLine("Siz kattasiz.");
}
// Natija: Siz kattasiz.
```

> **Maslahat:** Agar blok ichida faqat bitta operator bo'lsa, `{ }` qavslarini yozmaslikka ruxsat etiladi, lekin kodni o'qish oson va xatosiz bo'lishi uchun figurali qavslarni har doim yozish tavsiya etiladi.

### 3. `if-else` va `else if` zanjiri

`if-else` shart `true` bo'lganda bir blokni, `false` bo'lganda esa boshqa blokni bajaradi. Bir nechta shartni ketma-ket tekshirish uchun `else if` zanjiridan foydalaniladi. Zanjirda sharti mos kelgan **faqat bitta** blok bajariladi, qolganlari tekshirilmaydi.

```csharp
int ball = 75;

if (ball >= 90)
{
    Console.WriteLine("A'lo");
}
else if (ball >= 70)
{
    Console.WriteLine("Yaxshi");
}
else
{
    Console.WriteLine("Qoniqarli");
}
// Natija: Yaxshi
```

### 4. Tanlash operatori: `switch-case`

`switch-case` bitta o'zgaruvchining ko'p xil aniq qiymatlarini ketma-ket `if-else if` yozishdan ko'ra ixchamroq tekshirish usulidir.

* Har bir `case` blokidan so'ng `break;` yozish **shart**, aks holda dastur keyingi `case` blokiga o'tib ketadi (*fall-through* xatosi).
* `default` — hech bir `case` mos kelmaganda bajariladigan blok (`else` vazifasini o'taydi).

```csharp
int kun = 3;

switch (kun)
{
    case 1:
        Console.WriteLine("Dushanba");
        break;
    case 2:
        Console.WriteLine("Seshanba");
        break;
    case 3:
        Console.WriteLine("Chorshanba");
        break;
    default:
        Console.WriteLine("Noma'lum kun");
        break;
}
// Natija: Chorshanba
```

---

## II-Bo'lim: Takrorlash operatori — `for`

### 1. Sikl (Loop) nima uchun kerak?

**Sikl** — ma'lum bir shart bajarilgunga qadar bir yoki bir nechta operatorlarni qayta-qayta bajarish imkonini beruvchi konstruksiya. C# tilida uchta asosiy sikl mavjud: `for`, `while` va `do-while`.

### 2. `for` operatori sintaksisi va ishlash tartibi

`for` sikli takrorlanishlar soni **oldindan aniq ma'lum** bo'lgan holatlar uchun eng qulay tanlovdir.

**Sintaksisi:**
```csharp
for (boshlangich; shart; qadam)
{
    // takrorlanadigan kod
}
```

1. **Boshlang'ich:** sikl hisoblagich o'zgaruvchisi bir marta e'lon qilinadi (`int i = 1`).
2. **Shart:** har bir aylanishdan *oldin* tekshiriladi; `true` bo'lsa sikl tanasi bajariladi, `false` bo'lsa sikl tugaydi.
3. **Qadam:** har bir aylanish *tugagandan* so'ng bajariladi (`i++`, `i--` yoki `i += 2`).

#### Misollar:

**1 dan 5 gacha sonlarni chiqarish:**
```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
// Natija: 1, 2, 3, 4, 5 (har biri yangi qatorda)
```

**1 dan 10 gacha sonlar yig'indisini topish:**
```csharp
int yigindi = 0;

for (int i = 1; i <= 10; i++)
{
    yigindi += i; // akkumulyator o'zgaruvchiga joriy i qo'shiladi
}

Console.WriteLine(yigindi); // Natija: 55
```

---

## III-Bo'lim: Takrorlash operatorlari — `while` va `do-while`

### 1. `while` operatori

`while` sikli takrorlanish soni oldindan noma'lum bo'lib, jarayon biror mantiqiy shartga bog'liq bo'lganda qo'llaniladi. Shart har bir aylanishdan **oldin** tekshiriladi; agar boshidanoq `false` bo'lsa, sikl bir marta ham ishlamaydi.

```csharp
int i = 1;

while (i <= 5)
{
    Console.WriteLine(i);
    i++; // bu qator bo'lmasa, cheksiz sikl yuzaga keladi!
}
```

### 2. `do-while` operatori

`do-while` siklida shart har bir aylanish **tugagandan so'ng** tekshiriladi. Shu sababli, shart boshidanoq `false` bo'lsa ham, sikl tanasi **kamida bir marta** bajariladi. Operator oxirida nuqta-vergul (`;`) qo'yilishi shart.

```csharp
int son = 10;

do
{
    Console.WriteLine("Bajarildi!");
} while (son < 5);
// Natija: Bajarildi! (shart false bo'lishiga qaramay bir marta ishladi)
```

### 3. Sikllarni taqqoslash

| Sikl turi | Qachon tanlanadi? | Kamida 1 marta ishlaydimi? |
| :--- | :--- | :--- |
| **`for`** | Takrorlanishlar soni oldindan aniq ma'lum bo'lsa | Yo'q (shart `false` bo'lsa ishlamaydi) |
| **`while`** | Takrorlanish soni noma'lum, shartga bog'liq bo'lsa | Yo'q (shart `false` bo'lsa ishlamaydi) |
| **`do-while`** | Kod kamida bir marta bajarilishi shart bo'lsa | **Ha**, har doim kamida bir marta |

### 4. `break` va `continue` kalit so'zlari

* **`break;`** — siklni darhol to'xtatadi va undan chiqib ketadi.
* **`continue;`** — joriy aylanishning qolgan qismini tashlab o'tib, siklning keyingi aylanishiga o'tadi.

---

## Diqqat: Cheksiz sikl va ko'p uchraydigan xatolar

1. **Cheksiz sikl (*infinite loop*):** agar sikl sharti hech qachon `false` bo'lmasa (masalan, `while` ichida `i++` yozish unutilsa), dastur to'xtamay aylanib qotib qoladi. Visual Studio konsolida uni to'xtatish uchun `Ctrl + C` bosing.
2. **`if` shartidan keyin `;` qo'yish:** `if (yosh >= 18); { ... }` — nuqta-vergul shartni blokdan ajratib qo'yadi va blok har doim bajariladi.
3. **`do-while` oxirida `;` ni unutish:** `while (shart);` oxiridagi nuqta-vergul majburiy, aks holda kompilyatsiya xatosi beradi.
4. **`switch` ichida `break;` ni unutish:** *fall-through* xatosiga sabab bo'ladi.
5. **Shart ichida `==` o'rniga `=` yozish:** tenglikni tekshirish o'rniga qiymat berib yuboradi.

---

## O'z-o'zini tekshirish savollari (Viktorina)

1. **Oddiy va qo'shma operator orasidagi farq nima?**
   * *Javob:* Bitta buyruq — oddiy operator; `{ }` figurali qavslar ichiga olingan bir nechta buyruqlar to'plami — qo'shma operator (blok).
2. **`switch` ichida har bir `case` dan keyin `break;` yozishning sababi nima?**
   * *Javob:* Aks holda dastur keyingi `case` blokiga ham o'tib ketadi (*fall-through*).
3. **`for (int i = 1; i <= 5; i++)` siklida `i` qanday qiymatlarni oladi?**
   * *Javob:* `1, 2, 3, 4, 5` (`i = 6` bo'lganda shart `false` bo'lib sikl to'xtaydi).
4. **`while` va `do-while` orasidagi asosiy farq nima?**
   * *Javob:* `while` shartni aylanishdan oldin tekshiradi, `do-while` esa avval kodni bajarib, keyin shartni tekshiradi (kamida bir marta ishlaydi).

---

## Amaliy mustaqil topshiriq

1. `for` sikli va `%` (qoldiq) amalidan foydalanib, $1$ dan $20$ gacha bo'lgan barcha **juft sonlarni** ekranga chiqaring.
2. `while` sikli yordamida $100$ dan $1$ gacha **kamayib boruvchi** sonlarni ekranga chiqaring.
3. `do-while` sikli yordamida foydalanuvchidan `"Chiqish uchun 0 kiriting:"` deb so'raydigan va $0$ kiritilmaguncha davom etadigan dastur yozing.
4. *(Qo'shimcha)* `if-else if-else` zanjiri yordamida $100$ ballik tizimda kiritilgan balga mos ravishda $5$ baholik tizim bahosini (`2`, `3`, `4` yoki `5`) aniqlovchi dastur tuzing.

---

## Foydali adabiyotlar va manbalar

* Adambayev U.E. va b. *"Algoritmik tillar va dasturlash. C# tilida dasturlash asoslari"* (2023)
* Mo'minov B.B. *"Dasturlash 1"* (2021)
* Albahari B. *"C# 7.0. Справочник"* (2018)
* [metanit.com/sharp/tutorial](https://metanit.com/sharp/tutorial/) — Operatorlar va sikllar bo'limi
* [learn.microsoft.com/dotnet/csharp/language-reference/statements](https://learn.microsoft.com/dotnet/csharp/language-reference/statements/) — Rasmiy C# operatorlar qo'llanmasi
* [dastur.uz](https://www.dastur.uz/) — O'zbek tilida dasturlash resurslari