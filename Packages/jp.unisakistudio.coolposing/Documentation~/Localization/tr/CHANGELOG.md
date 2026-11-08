# Değişiklik geçmişi

## [1.2.0] - Yayınlanmadı

### Eklenenler

- Inspector, düzenleme işlemleri, kurulum iletişimleri, standart poz adları ve oluşturulan VRChat menüleri 30 dilde görüntülenebilir.
- Inspector ve oyun menüsünün dil seçimi birleştirildi. Başlangıçta bilgisayarın dili kullanılır ve son seçim aynı işletim sistemi kullanıcısının diğer projelerinde de uygulanır.
- README, değişiklik geçmişi ve çevrimdışı kılavuz seçilen dilde açılabilir.
- 128 standart pozun görüntüleme adları ve özellik açıklamaları mevcut terimlere göre hazırlandı.

### Uyumluluk

- Avatarın mevcut ayarları, özel adlar, varlık başvuruları, parametre kimlikleri ve lisans saklama yöntemi korunur.

## [1.1.0] - 2026-11-07

- 50 hazır pozun 43’ünde uzuvlar IK ile vücut yapısına otomatik uydurulur. Kalan 7 poz önceki poz başına düzeltmeleri kullanır.
- Fotoğraf modunda avatarın konumu ve yönü ayarlanabilir. Konum/yön eşitlemesi ve fotoğraf sırasında kendi başınızın görünmesi seçilebilir.
- Zemin yüksekliği tüm vücudu en fazla 3m yukarı veya aşağı taşır; ayak yüksekliğinden ayrı amaçla kullanılabilir.
- Nefes hareketi, varsayılan bekleme sallanmasını kapatma ve baş yönünden kaynaklanan poz bozulmasını azaltma eklendi.
- Kullanılan özellikler ve parametre maliyeti Inspector’da görülebilir. Poz arama, toplu ekleme, sıralama ve Scene’de hafif önizleme eklendi.
- Masaüstünde ayakta, çömelme ve oturma geçişleri hızlandırıldı.
- Ayar değişikliği sonrası ön oluşturma uyarıları, Inspector kaydırma yükü ve oluşturulan verilerin temizliğindeki uzun durmalar iyileştirildi.
- Unisaki Posing System 3.1.0 desteği eklendi.
- Hazır pozlar için dönüş hareketleri eklenmemiştir.

## [1.1.0-beta.2] - Açık beta (2026-11-05)

- 50 hazır pozun 43’üne otomatik uzuv düzeltmesi (IK) ayarlandı. Kalan 7 poz önceki poz başına düzeltmeleri kullanır.
- Ortak paket 3.1.0-beta.2 desteklendi. Bu sürümün hazır pozları dönüş hareketi içermez.

## [1.1.0-beta.1] - Açık beta (2026-11-04)

- Unisaki Posing System 3.1.0-beta.1 desteği eklendi.
- Masaüstünün normal poz geçişleri tek değerlendirme yöntemine geçirildi. Normal derlemede ve ön oluşturmada etkindir; VR ve özel koşullar önceki yolu korur.
- alpha.3 ve önceki ön oluşturmalar güncelleme gerektiren olarak tanınır.
- Fotoğraf sırasında zemin yüksekliği değişince bakış noktası korunur; fotoğraf bitince son zemin yüksekliğine dönülür.
- Otomatik içe aktarma, içe aktarılan hareket düzeltmesi ve oluşturulan Controller yönetiminde alpha.3’e kadarki iyileştirmeler eklendi.

## [1.1.0-alpha.1] - Yayın öncesi

### Eklenenler

- Dönüş ve poz başına ilgili animasyon ayarları eklendi.
- Nefes, dönüş, zemin yüksekliği, fotoğraf modu, mesafe, yön ve fotoğraftan çıkış için özel menü simgeleri eklendi.
- Öne taşıma ve dönüşü ayarlayan fotoğraf modu eklendi.
- Fotoğraf modu eşitlemesi eklendi: yalnızca yerel 0 bit, eşitlemede 16 bit.
- Fotoğraf modunda kendi avatarınızın başını gizlememe eklendi.
- Baş dâhil tüm vücudu yükselten Zemin yüksekliği eklendi.
- Nefes hareketi, güç ayarları ve oyun içi anahtar eklendi.
- VRChat’in varsayılan sallanmasını kapatma eklendi.
- Baş yönü farkından kaynaklanan poz bozulmasını azaltma eklendi.
- Dizin ters bükülmesini önleme ve en küçük açı eklendi.
- Özellik başına açma/kapatma ve ExpressionParameters göstergesi eklendi.
- Scene’de hafif önizleme, poz arama, toplu ekleme ve hedef sıra seçimi eklendi.
- Inspector içinde değişiklik geçmişi eklendi.

### Değişenler

- Inspector, Özellikler, Pozlar ve Avatar Kurulumu adlı 3 sekmeye ayrıldı.
- Nefes ayrıntıları, kendi hareketlerinizi içe aktarma ve ön ayarların yerleri düzenlendi.
- Ayak yüksekliği için oluşturulan animasyonların tekrarı azaltıldı.
- Poz görüntüsü yenilemeye onay eklendi; uyarı ayarları Ayarları kontrol et’te toplandı.
- 8bit için yeni ekleme menüsü kaldırılıp normal Prefab’ın özellik seçimine geçildi. Mevcut başvurular korunur.
- Unisaki Posing System 3.1.0-alpha.1 desteklendi. VRChat Avatars SDK minimum sürümü 3.10.4 oldu.

### Düzeltilenler

- Poz adı girişinin başka poza kayması ve sıralamada ayrıntıların kapanması düzeltildi.
- Önizleme çakışması, yerleştirme konumunun sapması ve bazı avatar hataları düzeltildi.
- Ayar değişikliği sonrası uyarı/ön oluşturma durumunun güncellenmesi ve bazı derleme hataları düzeltildi.

## [1.0.0] - 2026-09-06

- Resmî yayın
- Avatar ön ayarları eklendi (トネール, 狛乃, 士堂, 真央)

## [1.0.0-alpha.1] - 2026-09-06

- Yayın
