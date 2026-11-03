# Market Automation

A layered Windows Forms point-of-sale and back-office app for small markets: sales & cash register, stock, customers, suppliers and end-of-day reports.

**[English](#english) | [Türkçe](#türkçe)**

---

## English

### Features
- **Sales & cash register:** search products by code or description, cart, cash / card / cheque payments, change calculation, stock is decreased in a single transaction (sale is rejected if stock is insufficient)
- **End of day:** daily cash / card / cheque totals and revenue, stored as daily reports
- **Back office:** products, categories (with VAT rate), brands, units, suppliers, customers
- **Users & roles:** admin sees every tab; staff only sees sales, customers and daily reports
- Passwords are stored as salted PBKDF2-SHA256 hashes, all queries are parameterized

### Architecture
```
PresentationLayer  (WinForms UI)        ──► LogicLayer
LogicLayer         (validation, rules)  ──► DataAccessLayer, EntitiesLayer
DataAccessLayer    (ADO.NET, SQL)       ──► EntitiesLayer
EntitiesLayer      (plain models)
```
The UI never talks to the database directly; it only calls `LogicProcess`.

### Requirements
- Windows, .NET Framework 4.7.2
- Visual Studio 2019/2022 (or Build Tools with MSBuild)
- SQL Server – LocalDB (installed with Visual Studio), Express or full edition

### Installation
1. Clone the repo:
   ```bash
   git clone https://github.com/sezerD8/marketoto.git
   ```
2. Create the database by running `database/schema.sql` (SSMS, Visual Studio *SQL Server Object Explorer*, or):
   ```bash
   sqlcmd -S "(localdb)\MSSQLLocalDB" -i database\schema.sql
   ```
3. If you are not using LocalDB, edit the `MarketDb` connection string in `PresentationLayer/App.config`.
4. Open `MarketAutomation.sln`, set **PresentationLayer** as the startup project and run (F5).

**Default login:** `admin` / `1234` – add your own users in *Kullanıcı İşlemleri* and change it.

### Project structure
```
EntitiesLayer/      Product, Category, Brand, Unit, Supplier, Customer, User, DailyReport
DataAccessLayer/    Database (connection + query helpers), DataProcess (SQL per entity)
LogicLayer/         LogicProcess (validation + business rules), PasswordHasher
PresentationLayer/  LoginForm, MainForm, App.config
database/schema.sql tables + default admin user
```

---

## Türkçe

Küçük marketler için katmanlı mimariyle yazılmış Windows Forms satış ve yönetim uygulaması: satış & kasa, stok, müşteri, toptancı ve gün sonu raporları.

### Özellikler
- **Satış & kasa:** kod veya açıklamayla ürün arama, sepet, nakit / kart / çek ödeme, para üstü hesaplama; stok tek bir transaction ile düşülür (stok yetersizse satış reddedilir)
- **Gün sonu:** günlük nakit / kart / çek toplamları ve ciro, günlük rapor olarak kaydedilir
- **Yönetim:** ürünler, kategoriler (KDV oranıyla), markalar, birimler, toptancılar, müşteriler
- **Kullanıcılar & yetkiler:** admin tüm sekmeleri görür; personel sadece satış, müşteri ve günlük rapor sekmelerini görür
- Şifreler tuzlu PBKDF2-SHA256 hash olarak saklanır, tüm sorgular parametrelidir

### Gereksinimler
- Windows, .NET Framework 4.7.2
- Visual Studio 2019/2022 (veya MSBuild içeren Build Tools)
- SQL Server – LocalDB (Visual Studio ile gelir), Express veya tam sürüm

### Kurulum
1. Repoyu klonlayın:
   ```bash
   git clone https://github.com/sezerD8/marketoto.git
   ```
2. `database/schema.sql` dosyasını çalıştırarak veritabanını oluşturun (SSMS, Visual Studio *SQL Server Object Explorer* ya da):
   ```bash
   sqlcmd -S "(localdb)\MSSQLLocalDB" -i database\schema.sql
   ```
3. LocalDB kullanmıyorsanız `PresentationLayer/App.config` içindeki `MarketDb` bağlantı dizesini düzenleyin.
4. `MarketAutomation.sln` dosyasını açın, başlangıç projesi olarak **PresentationLayer**'ı seçin ve çalıştırın (F5).

**Varsayılan giriş:** `admin` / `1234` – *Kullanıcı İşlemleri* sekmesinden kendi kullanıcılarınızı ekleyip bu şifreyi değiştirin.
