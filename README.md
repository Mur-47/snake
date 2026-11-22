# Yılan Oyunu

C# ve Windows Forms ile hazırlanmış masaüstü yılan oyunu.

**Durum: eğitim/portföy kaynak kodu.** Bu belge, depodaki mevcut dosyalara göre hazırlanmıştır. Üretime hazır ürün veya doğrulanmış kurulum paketi olarak sunulmaz.

## Gereksinimler

- Windows ve Visual Studio içinde **.NET masaüstü geliştirme** iş yükü.
- Projenin mevcut hedefi `net6.0-windows`. Bu hedefi derleyebilen .NET SDK ve çalıştırmak için uyumlu Windows Desktop Runtime gerekir.

## Kurulum

1. Depoyu klonlayın:

   ```powershell
   git clone https://github.com/Mur-47/snake.git
   cd snake
   ```

2. Visual Studio ile [`231116008 Murat Aktaş yılan oyunu.sln`](Murat%20Akta%C5%9F%20y%C4%B1lan%20oyunu/231116008%20Murat%20Akta%C5%9F%20y%C4%B1lan%20oyunu.sln) çözümünü açın.
3. Varsa **Restore NuGet Packages** adımını çalıştırın; eksik proje referanslarını kontrol edin.

Bağımlılıklar hazır olduğunda Visual Studio'da derleyip çalıştırın. Oyun içindeki başlatma öğesini kullanın; yön tuşları **W / A / S / D**. Bu proje veritabanı kullanmaz.

## Dosyaları nasıl okumalı?

- [`231116008 Murat Aktaş yılan oyunu.sln`](Murat%20Akta%C5%9F%20y%C4%B1lan%20oyunu/231116008%20Murat%20Akta%C5%9F%20y%C4%B1lan%20oyunu.sln): Visual Studio çözümü; projeyi açma noktası.
- [`231116008 Murat Aktaş yılan oyunu.csproj`](Murat%20Akta%C5%9F%20y%C4%B1lan%20oyunu/231116008%20Murat%20Akta%C5%9F%20y%C4%B1lan%20oyunu/231116008%20Murat%20Akta%C5%9F%20y%C4%B1lan%20oyunu.csproj): hedef framework, dosyalar ve bağımlılık referansları.
- [`Kaynak klasörü`](Murat%20Akta%C5%9F%20y%C4%B1lan%20oyunu/231116008%20Murat%20Akta%C5%9F%20y%C4%B1lan%20oyunu): `Program.cs` başlangıç noktası, form `.cs` dosyaları ekran davranışları.
- `.Designer.cs` ve `.resx`: form tasarımı ve kaynaklar; önbellek değildir, korunur.
- `bin`, `obj`, `.vs`: yeniden üretilen derleme/IDE dosyaları; kaynak kod yerine kullanılmaz ve Git'e eklenmez.

## Doğrulama ve sınırlar

- Bu düzenlemede proje yapısı, hedef framework, bağımlılık referansları ve Git dosya listesi kontrol edildi.
- Uygulama başlatılmadı; derleme, ekran akışları ve veritabanı işlemleri test edilmedi.
- Depoda bu çalışma sırasında çalıştırılmış bir otomatik test sonucu yoktur.
- Katkıda bulunurken kurulumun tamamını temiz bir kopyada, yalnız sentetik verilerle doğrulayın; çalıştırdığınız komutları ve sonuçları PR'a yazın.

## Katkı ve kullanım

Küçük değişiklikler için ayrı dal ve pull request kullanın. Parola, bağlantı sırrı, gerçek veri, yedek veya lisanslı bileşen yüklemeyin. Üçüncü taraf bileşenlerin lisansları ayrıca geçerlidir; bu düzenleme projeye yeni bir kullanım lisansı vermez.

## Geliştirici

**Murat AKTAŞ** · [GitHub](https://github.com/Mur-47)
