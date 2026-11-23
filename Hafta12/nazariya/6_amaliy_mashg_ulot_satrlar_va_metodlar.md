# 6-Amaliy mashg'ulot: Satrlar va Metodlar

**Fan:** Dasturlash 1 (`DAS1110`)  
**O'quv yili:** 2025/2026  
**O'qituvchi:** Toshpolatov Muxiddin, PhD, dotsent  
**Muassasa:** O'zbekiston Milliy universiteti Jizzax filiali, Amaliy matematika fakulteti

## Mashg'ulot maqsadi va rejasi

Ushbu yakuniy amaliy mashg'ulot davomida talabalar satr va belgi metodlari, rekursiya va iteratsiya, shuningdek `params`, `ref` va `out` kalit so'zlari bilan ishlashni mustahkamlaydilar:

* `char.IsUpper`, `char.IsLower`, `char.IsDigit` va `string.Length` yordamida satrni tahlil qilish;
* Evklid algoritmi asosida EKUB (GCD) ni rekursiv va iterativ usulda hisoblash;
* `params`, `ref` va `out` parametrli metodlarni to'g'ri e'lon qilish va chaqirish;
* Rekursiya va iteratsiya farqlarini amalda solishtirish.

### Reja:
1. **1-mashq:** *"Parol kuchini tekshiruvchi"* (`char` / `string`, birga)
2. **2-mashq:** EKUB (GCD) — rekursiv VA iterativ usulda (mustaqil)
3. **3-mashq (qo'shimcha):** *"Modular kalkulyator"* — `params` / `ref` / `out`
4. Amaliyotda ko'p uchraydigan xatolar va yakuniy uyga vazifa

---

## 1. Amaliy mashqlar (`amaliy-mashgulotlar/`)

### 1-mashq: *"Parol kuchini tekshiruvchi"* (`parol-tekshiruvchi.cs`)

**Vazifa:** Foydalanuvchi kiritgan parolni tahlil qilib, unda kamida bitta katta harf, kichik harf va raqam bor-yo'qligini aniqlang. Agar barcha shart bajarilsa va parol uzunligi $\ge 8$ bo'lsa — `"KUCHLI"`, aks holda `"ZAIF"` deb chiqaring.

### 2-mashq: EKUB (GCD) — rekursiv va iterativ (`ekub-hisoblagich.cs`)

**Vazifa:** Evklid algoritmi ($\text{EKUB}(a, b) = \text{EKUB}(b, a \bmod b)$, agar $b = 0$ bo'lsa natija $a$) asosida bitta metodni rekursiv, ikkinchisini esa iterativ (`while` sikli bilan) yozing va ikkalasining natijasi bir xil ekanini tekshiring.

### 3-mashq (Qo'shimcha): *"Modular kalkulyator"* (`modular-kalkulyator.cs`)

**Vazifa:**
1. `params int[] sonlar` yordamida ixtiyoriy sondagi sonlarning yig'indisi va o'rtachasini hisoblovchi metod yozing.
2. `static void Almashtir(ref int a, ref int b)` yordamida ikkita o'zgaruvchi qiymatini joyida almashtiring.
3. `static void MinMax(int[] massiv, out int min, out int max)` yordamida massivning eng kichik va eng katta qiymatini bir vaqtda qaytaring.

---

## 2. Diqqat: Amaliyotda ko'p uchraydigan xatolar

1. **`ref` / `out` kalit so'zini chaqirishda tushirib qoldirish:** `ref` va `out` parametrlarida kalit so'z metod e'lonida ham, uni chaqirishda ham yozilishi shart.
2. **Rekursiyada baza holatini unutish:** Masalan, EKUB da $b = 0$ sharti bo'lmasa, metod cheksiz chaqirilib `StackOverflowException` yuzaga keladi.
3. **`params` qoidalarini buzish:** `params` parametri parametrlar ro'yxatining eng oxirida turishi shart va metodda faqat bitta `params` bo'lishi mumkin.
4. **Belgi turlarini tekshirmaslik:** Satr ichidagi bo'sh joy yoki maxsus belgilar `IsUpper` / `IsLower` / `IsDigit` da `false` qaytarishini hisobga oling.

---

## 3. Yakuniy uyga vazifa (`topshiriqlar/topshiriq-06.cs`)

1. **Maxsus belgili parol tekshiruvchi:** Parol tekshiruvchiga maxsus belgi (`!@#$%`) borligini tekshirish shartini qo'shing.
2. **Faktorial (rekursiv va iterativ):** $n!$ ni ham rekursiv, ham iterativ usulda hisoblovchi metodlar yozib, natijalarini solishtiring.
3. **`params` bilan eng katta son:** Ixtiyoriy sondagi butun sonlar orasidan eng kattasini topuvchi `params int[]` metod qo'shing.
4. *(Yakuniy, ixtiyoriy)* **1-semestr portfolio konsol dasturi:** Semestr davomida o'rganilgan asosiy loyihalarni birlashtiruvchi yakuniy menyu/dastur tuzing.

---

## Xulosa

* Belgi va satrlar bilan ishlash (`char.IsUpper`, `char.IsLower`, `char.IsDigit`, `Length`) amalda qo'llanildi.
* Rekursiv va iterativ algoritmlarni yozish hamda solishtirish o'rganildi.
* `params`, `ref` va `out` parametrli metodlar orqali moslashuvchan arxitektura qurildi.
* **Semestr yakuni:** Dasturlash 1 fanining asosiy qurilish bloklari (o'zgaruvchilar, amallar, shartlar, sikllar, massivlar, satrlar va metodlar) o'zlashtirildi.