# 5-Amaliy mashg'ulot: 2D va pog'onali massivlar

**Fan:** Dasturlash 1 (`DAS1110`)  
**O'quv yili:** 2025/2026  
**O'qituvchi:** Toshpolatov Muxiddin, PhD, dotsent  
**Muassasa:** O'zbekiston Milliy universiteti Jizzax filiali, Amaliy matematika fakulteti

## Mashg'ulot maqsadi va rejasi

Ushbu amaliy mashg'ulot davomida talabalar ikki o'lchamli (`2D`) massivlar va pog'onali (*jagged*) massivlar bilan ishlashni, qator/ustun hamda diagonal bo'yicha hisob-kitoblar bajarishni o'rganadilar:

* Ikki o'lchamli massiv (`int[,]`) yaratish va ichma-ich `for` sikllari yordamida ishlash;
* Kvadrat matritsaning bosh diagonal elementlari (`massiv[i, i]`) yig'indisini topish;
* Har bir qatori har xil uzunlikka ega bo'lgan pog'onali (*jagged*) massiv (`string[][]`) bilan ishlash;
* `GetLength(0)` va `GetLength(1)` xususiyatlarini to'g'ri qo'llash.

### Reja:
1. **1-mashq:** *"Sinf jadvali"* baholar matritsasi (birga)
2. **2-mashq:** Diagonal elementlar yig'indisi (mustaqil)
3. **3-mashq (qo'shimcha):** *"Haftalik vazifalar"* — pog'onali (*jagged*) massiv
4. Amaliyotda ko'p uchraydigan xatolar va uyga vazifa

---

## 1. Amaliy mashqlar (`amaliy-mashgulotlar/`)

### 1-mashq: *"Sinf jadvali"* baholar matritsasi (`sinf-jadvali-2d.cs`)

**Vazifa:** $3$ ta talaba va $4$ ta fan uchun baholar matritsasini (`int[,]`) yarating hamda tashqi va ichki `for` sikllari yordamida har bir talabaning fanlar bo'yicha o'rtacha bahosini hisoblang.

* Birinchi indeks (`i`) — **qator** (talaba), ikkinchi indeks (`j`) — **ustun** (fan).
* Masalan, `baholar[0, 2]` — $1$-talabaning $3$-fandan olgan bahosi ($5$).

### 2-mashq: Diagonal elementlar yig'indisi (`diagonal-yigindi.cs`)

**Vazifa:** $4 \times 4$ kvadrat massiv yarating va uning bosh diagonal (chap yuqoridan o'ng pastga) elementlari yig'indisini hisoblang.

* Bosh diagonal elementlarida ikkala indeks ham bir xil bo'ladi: `matritsa[i, i]`.

### 3-mashq (Qo'shimcha): *"Haftalik vazifalar"* — pog'onali massiv (`haftalik-vazifalar.cs`)

**Vazifa:** Har bir kunda vazifalar soni har xil bo'lishi mumkinligi sababli pog'onali massiv (`string[][]`) yarating va har bir kundagi vazifalar sonini chiqaring.

* Sintaksis namunasi: `string[][] vazifalar = new string[2][];` va har bir qatorni alohida `vazifalar[0] = new string[] { ... };` ko'rinishida to'ldirish.

---

## 2. Diqqat: Amaliyotda ko'p uchraydigan xatolar

1. **2D va pog'onali massiv sintaksisini aralashtirish:** `2D` massivda vergulli indeks (`massiv[i, j]`), pog'onali massivda esa alohida kvadrat qavslar (`massiv[i][j]`) ishlatiladi.
2. **Ichki massivlarni e'lon qilishni unutish:** Pog'onali massivda `vazifalar[i]` ga yangi massiv tayinlanmasa, `NullReferenceException` yuz beradi.
3. **Diagonal uchun noto'g'ri indeks tanlash:** Bosh diagonal uchun har doim `[i, i]` indeksidan foydalaning.
4. **`GetLength(0)` va `GetLength(1)` ni adashtirish:** `GetLength(0)` qatorlar sonini, `GetLength(1)` esa ustunlar sonini qaytaradi.

---

## 3. Uyga vazifa (`topshiriqlar/topshiriq-05.cs`)

1. **Fanlar bo'yicha o'rtacha baho:** *"Sinf jadvali"* matritsasiga har bir fanning sinf bo'yicha o'rtacha bahosini (ustun bo'yicha) hisoblaydigan qism qo'shing.
2. **3x3 matritsa elementlari yig'indisi:** $3 \times 3$ o'lchamli massiv yarating va uning barcha elementlari yig'indisini hisoblang.
3. *(Qo'shimcha)* **Eng ko'p vazifali kun:** *"Haftalik vazifalar"* pog'onali massiviga barcha $7$ kun uchun vazifalarni kiriting va eng ko'p vazifa rejalashtirilgan kunni aniqlang.

---

## Xulosa

* Ikki o'lchamli massiv (`int[,]`) orqali jadval ko'rinishidagi ma'lumotlar bilan ishlash o'rganildi.
* Kvadrat matritsaning bosh diagonali elementlari `matritsa[i, i]` yordamida hisoblandi.
* Har xil uzunlikdagi qatorlarni saqlash uchun pog'onali (*jagged*) massivlar qo'llandi.
* **Keyingi amaliy mashg'ulot:** Satrlar (`StringBuilder`) va parametrli metodlar (`ref`, `out`, `params`).