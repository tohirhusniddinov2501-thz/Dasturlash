# 4-Amaliy mashg'ulot: Bir o'lchamli massivlar

**Fan:** Dasturlash 1 (`DAS1110`)  
**O'quv yili:** 2025/2026  
**O'qituvchi:** Toshpolatov Muxiddin, PhD, dotsent  
**Muassasa:** O'zbekiston Milliy universiteti Jizzax filiali, Amaliy matematika fakulteti

## Mashg'ulot maqsadi va rejasi

Ushbu amaliy mashg'ulot davomida talabalar bir o'lchamli massivlar bilan ishlash, statistik qiymatlarni hisoblash, qidirish, elementni almashtirish va saralash algoritmlarini o'zlashtiradilar:

* Massivni e'lon qilish va `for` sikli yordamida foydalanuvchi kiritgan qiymatlar bilan to'ldirish;
* `foreach` sikli orqali yig'indi, minimum, maksimum va o'rtacha qiymatni hisoblash;
* Massiv ichidan element qidirish, indeksini aniqlash va qiymatni almashtirish;
* `Array.Sort()` va `Array.Reverse()` metodlari yordamida massivni tartiblash.

### Reja:
1. **1-mashq:** *"Sinf jurnali"* — kiritish, yig'indi, min/max/o'rtacha (birga)
2. **2-mashq:** Massivda qidirish va almashtirish (mustaqil)
3. **3-mashq (qo'shimcha):** Massivni saralash va teskari aylantirish
4. Amaliyotda ko'p uchraydigan xatolar va uyga vazifa

---

## 1. Amaliy mashqlar (`amaliy-mashgulotlar/`)

### 1-mashq: *"Sinf jurnali"* (`sinf-jurnali.cs`)

**Vazifa:** Talabalar sonini so'rab, har bir talabaning ballini massivga kiriting, so'ng yig'indi, minimum, maksimum va o'rtachani hisoblang.

**Kutilgan natija (Console chiqishi):**
```text
Nechta talaba bor? 4
1-talaba balli: 85
2-talaba balli: 92
3-talaba balli: 78
4-talaba balli: 95

Yig'indi:  350
Minimum:   78
Maksimum:  95
O'rtacha:  87.5
```

### 2-mashq: Qidirish va almashtirish (`qidirish-va-almashtirish.cs`)

**Vazifa:**
1. Foydalanuvchidan ball so'rang va massivda o'sha ball bor-yo'qligini hamda qaysi indeksda ekanini toping.
2. Eng past ballni toping va uni `0` ga almashtiring.

### 3-mashq (Qo'shimcha): Saralash va teskari aylantirish (`saralash-massiv.cs`)

**Vazifa:** `Array.Sort()` va `Array.Reverse()` metodlarini birga qo'llab, *"Sinf jurnali"* massivini kamayuvchi tartibda (eng yuqori balldan boshlab) chiqaring.

---

## 2. Diqqat: Amaliyotda ko'p uchraydigan xatolar

1. **Massiv indeksidan tashqariga chiqish:** $N$ elementli massivda oxirgi element indeksi $N - 1$ ga teng (`ballar[N]` murojaati `IndexOutOfRangeException` xatosini beradi).
2. **O'rtachani hisoblashda butun bo'lish:** `yigindi / soni` ifodasida ikkala operand `int` bo'lsa, kasr qism tashlab yuboriladi — `(double)yigindi / soni` ko'rinishida yozish kerak.
3. **`Array.Sort()` natijasini o'zgaruvchiga olishga urinish:** `Array.Sort(massiv)` hech narsa qaytarmaydi (`void`), balki mavjud massivning o'zini joyida o'zgartiradi.
4. **Qidirishda bayroq o'zgaruvchini unutish:** Element topilmaganini aniq bilish uchun `bool topildi = false;` o'zgaruvchisidan foydalaning.

---

## 3. Uyga vazifa (`topshiriqlar/topshiriq-04.cs`)

1. **"Harorat jurnali":** $7$ kunlik haroratni massivga kiriting, eng issiq va eng sovuq kunni toping.
2. **Juft sonlar:** Massivdagi barcha juft sonlarni alohida chiqaruvchi dastur yozing.
3. *(Qo'shimcha)* **O'rtachadan past ballar:** *"Sinf jurnali"*ga o'rtachadan pastroq ball olgan talabalar sonini hisoblovchi kod qo'shing.

---

## Xulosa

* Massivni sikl yordamida to'ldirish va statistik ko'rsatkichlarni hisoblash mustahkamlandi.
* Massivda chiziqli qidirish hamda qiymatni almashtirish bajarildi.
* `Array.Sort()` va `Array.Reverse()` yordamida massivni saralash o'rganildi.
* **Keyingi amaliy mashg'ulot:** Ikki o'lchamli va pog'onali (*jagged*) massivlar.