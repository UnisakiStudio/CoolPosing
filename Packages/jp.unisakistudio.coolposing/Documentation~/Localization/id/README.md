# Cool Posing Tool

Alat pengunci pose untuk VRChat yang memungkinkan Anda beralih ke pose keren, termasuk dengan pelacakan 3 titik dan desktop. Berisi total 50 pose: 11 berdiri, 9 setengah jongkok, 14 duduk, 9 tidur telentang, dan 7 tidur tengkurap.

README ini ditujukan untuk v1.2.0 yang sedang dikembangkan. Tanggal rilis resmi belum ditentukan. Versi terpasang dapat diperiksa di bagian atas Inspector.

- [Halaman produk BOOTH](https://yunisaki.booth.pm/items/8797334)
- [Riwayat perubahan](CHANGELOG.md)

## Bahasa tampilan dan dokumen offline

Pilih bahasa melalui “Language / 言語” di bagian atas Inspector. Satu pilihan berlaku untuk Inspector dan menu VRChat yang dibuat. Unggah ulang avatar untuk mengubah bahasa di dalam gim.

Jika belum dipilih, bahasa komputer digunakan; bahasa yang tidak didukung memakai bahasa Inggris. Windows, macOS, dan Linux didukung. Pilihan terakhir disimpan di EditorPrefs dan digunakan di proyek lain milik pengguna OS yang sama pada komputer ini. Pilihan eksplisit yang sudah tersimpan pada avatar dipertahankan. Pilihan tidak disinkronkan ke komputer lain. Cara penyimpanan lisensi tidak berubah.

README, riwayat perubahan, dan panduan dapat dipilih melalui [daftar bahasa](../index.html) yang disertakan. Tombol panduan dan riwayat perubahan di Inspector juga mengikuti bahasa pilihan. Ketentuan asli dan terjemahan referensi tetap disediakan secara terpisah.

## Fitur utama

- Penyesuaian anggota tubuh otomatis (IK): menyesuaikan posisi serta arah anggota tubuh dengan proporsi avatar pada 43 pose.

- Mode foto: memindahkan avatar hingga 3m ke depan dan menyesuaikan arahnya. Hanya pada layar sendiri menggunakan 0 bit; memperlihatkan posisi dan arah kepada orang lain menggunakan 16 bit.
- Tampilan kepala saat pemotretan: mencegah kepala avatar sendiri menghilang saat berada dekat, khusus selama Mode foto.
- Tinggi lantai: menggerakkan seluruh tubuh termasuk kepala hingga 3m ke atas dan ke bawah. Dapat digunakan terpisah dari “Tinggi kaki”, yang menggerakkan bagian kaki sambil mempertahankan posisi kepala.
- Berguling: tersedia untuk pose yang Anda beri gerakan pendukung sendiri. Pose bawaan tidak mencakup gerakan berguling.
- Napas: menambahkan animasi napas pada dada dan bagian lain. Pilih “Tidak ada, Lemah, Sedang, Kuat, Cepat, Khusus” untuk setiap kategori pose.
- Nonaktifkan goyangan diam VRChat: mengurangi goyangan diam bawaan sambil tetap menggunakan animasi napas alat pose dan gerakan khusus lain.
- Kurangi perubahan pose akibat rotasi kepala: mengurangi perubahan pose ketika kunci leher dilepas dan arah leher berbeda dari pose asli.
- Pilihan fitur: hanya menambahkan menu dalam permainan yang diperlukan dan memeriksa penggunaan ExpressionParameters di Inspector.
- Pencarian, penambahan sekaligus, dan pengurutan daftar pose: mencari lintas kategori, memuat beberapa klip, dan menentukan posisi tujuan.
- Pratinjau sederhana di Scene: periksa pose langsung melalui “Pratinjau” dalam daftar pose.

- Ikon menu fitur baru: Napas, Berguling, Tinggi lantai, Mode foto, dan lainnya memiliki gambar khusus yang sesuai dengan ikon produk yang sudah ada.

### Mengatur berguling

Buka “Rincian” pose berbaring yang diinginkan, aktifkan “Aktifkan berguling”, lalu tentukan animasi pada “Pose berguling samping”. Pengaturan MotionTime biasa tidak dapat digunakan. Aktifkan juga “Fitur > Fitur menu > Berguling” lalu unggah. Di VRChat, pilih pose yang didukung dan “Berguling”. Gunakan dengan kunci leher dilepas.

Pose bawaan versi ini tidak mencakup gerakan untuk berguling. Tentukan animasi yang sesuai dengan pose yang ingin digunakan.

## Prasetel avatar yang didukung dan penyesuaian

Mencakup prasetel yang sudah disesuaikan untuk トネール, 狛乃, 士堂, dan 真央.

- [トネール](https://booth.pm/ja/items/5236104)
- [狛乃](https://booth.pm/ja/items/5260363)
- [士堂](https://booth.pm/ja/items/8086741)
- [真央](https://booth.pm/ja/items/6846646)

Avatar lain juga dapat digunakan. Sesuaikan pose melalui “Penyesuaian Animasi” berdasarkan bentuk tubuh dan modifikasi. “Pengaturan Avatar” juga berisi “Cegah lutut menekuk terbalik” dan “Tekukan lutut minimum (derajat)” dalam rincian.

Penyesuaian anggota tubuh otomatis (IK) aktif secara bawaan. Dari 50 pose bawaan, 43 menggunakan IK dan 7 sisanya menggunakan penyesuaian per pose yang sudah ada.

## Cara pemasangan

1. Unduh file dari halaman produk di toko tempat Anda membelinya.
2. Impor “カッコいいポーズツール.unitypackage” yang disertakan ke Unity, lalu daftarkan lisensi dan sumber distribusi paket.
3. Dengan VCC atau ALCOM, tambahkan Cool Posing Tool dan Modular Avatar ke proyek Unity yang digunakan. Unisaki Posing System dan NDMF juga dipasang sebagai dependensi.
4. Klik kanan avatar tujuan di Hierarchy dan pilih “Unisaki Studio > Tambah Cool Posing”.
5. Pilih “カッコいいポーズ” (Cool Posing) yang ditambahkan di dalam avatar, lalu atur fitur dan pose yang diinginkan di Inspector.
6. Unggah avatar seperti biasa.

Persyaratan: Unity 2022.3, VRChat Avatars SDK 3.10.4 atau lebih baru, Modular Avatar seri 1.x versi 1.15.1 atau lebih baru, dan NDMF seri 1.x versi 1.14.0 atau lebih baru. Perbarui juga paket yang diperlukan melalui VCC atau ALCOM.

## Memperbarui dari versi sebelumnya

Perbarui produk ini bersama Unisaki Posing System. Pengaturan alat yang sudah ditempatkan tetap dipertahankan. Periksa fitur yang digunakan dan penggunaan ExpressionParameters di Inspector. Jika sebelumnya menggunakan prabuild, tekan “Perbarui prabuild” sebelum mengunggah ulang.

Sejak v1.1.0, penambahan baru disatukan pada Prefab biasa “カッコいいポーズ” (Cool Posing). Nonaktifkan item yang tidak diperlukan pada “Fitur” untuk konfigurasi minimum pemilihan pose saja sebesar 8 bit. Konfigurasi dengan banyak pose mungkin memerlukan bit tambahan untuk pemilihan pose.

Prefab 8bit lama tetap berada di “Editor/Legacy” untuk mempertahankan referensi avatar dan prasetel yang sudah ada. Prefab yang ada tidak perlu dihapus atau diganti. Versi 8bit tidak muncul dalam menu penambahan baru Unity.

## Lokasi pengaturan

| Tab | Kegunaan |
| --- | --- |
| Fitur | Menambah menu dalam permainan, kemudahan, pengaturan napas, gambar ikon, dan pemeriksaan penggunaan ExpressionParameters |
| Pose | Memilih pose, pengaturan rinci, pencarian, penambahan sekaligus, pengurutan, pratinjau, dan Penyesuaian Animasi |
| Pengaturan Avatar | Koreksi khusus avatar dan lutut, impor pose asli atau gerakan sendiri, dan penggantian prasetel |

Tekan “Buka pengaturan” untuk membuka pengaturan rinci di bawah item tersebut. Atur napas melalui “Fitur > Kemudahan > Animasikan napas”.

“Gunakan pose berdiri, jongkok, dan tengkurap asli” mengimpor pose yang sudah ada pada avatar secara otomatis. Untuk menggunakan gerakan sendiri, buka pengaturan terpisah “Buka pengaturan impor” dan tentukan gerakan bagi setiap jenis, seperti berdiri, jongkok (Crouching), dan tengkurap (Prone).

Prasetel berada di bagian paling bawah “Pengaturan Avatar”. “Terapkan prasetel ini” mengganti pengaturan pose saat ini, jadi simpan penyesuaian yang sudah dibuat sebelum beralih.

### Penggunaan per fitur

- Animasi napas menggunakan 0 bit. Hanya jika menggunakan “Fitur menu > Napas” untuk menghentikan dan melanjutkannya dalam permainan, sinkronisasi ON/OFF menggunakan 1 bit.
- Mode foto menggunakan 0 bit jika hanya terlihat pada layar sendiri. Memilih “Kemudahan > Sinkronkan mode foto” menggunakan 16 bit. “Tetap tampilkan kepala dalam mode foto” menggunakan 0 bit.
- “Tinggi kaki” dan “Tinggi lantai” masing-masing menggunakan 8 bit. Tinggi lantai menggerakkan seluruh tubuh ke atas atau ke bawah saat digeser dari tengah, dan berakhir saat dikembalikan mendekati 50%.
- “Berguling” sendiri menggunakan 10 bit. Fitur ini berbagi 1 bit dengan “Kurangi perubahan pose akibat rotasi kepala”, sehingga penggunaan keduanya tetap berjumlah 10 bit.
- “Cerminkan” dan “Gestur mati” masing-masing menggunakan 1 bit.

Jumlah di Inspector hanya mencakup alat pose yang dipasang pada avatar. Alat lain, seperti pakaian, tidak termasuk. Jika menggunakan beberapa alat pose, pengaturan bersama tidak dihitung dua kali.

### Pratinjau dan penyuntingan pose

Gunakan “Pratinjau” pada setiap pose dalam “Pose” untuk menampilkan pose di Scene. Untuk penyempurnaan, buka “Penyesuaian Animasi”, sesuaikan sambil memeriksa pose, lalu simpan.

Pratinjau sederhana tidak menjalankan proses build MA atau NDMF. Periksa juga pakaian dan koreksi posisi lantai yang diterapkan saat build melalui hasil build sebelum unggah.

Cari nama pose melalui tab kaca pembesar di kiri. Pilih posisi tujuan pada “Urutan” di “Rincian”, atau gunakan tombol naik/turun untuk mengurutkan ulang. Tambahkan beberapa animasi sekaligus dengan menyeret dan melepasnya ke area penambahan atau menggunakan “Muat klip yang dipilih di Project”.

“Perbarui gambar mini pose” membuat gambar setelah dialog konfirmasi. “Buat ikon pose” membantu mengenali pose dalam menu permainan, tetapi pembuatan gambar menambah waktu build. Untuk mengurangi ukuran, pilih “Kurangi ukuran ikon”. Ikon pose tidak dibuat untuk Android.

## Kontrol dasar dalam permainan

- Pilih pose dari setiap kategori melalui menu Expressions. Dalam VR, kategori berdiri, setengah jongkok, duduk, dan berbaring beralih sesuai tinggi kepala.
- Dalam pose berbaring, arah wajah menentukan telentang atau tengkurap. Jika keduanya dipilih, melompat juga dapat menggantinya; fitur ini dapat dinonaktifkan melalui “Fitur → Kemudahan → Beralih pose berbaring dengan melompat”. Tinggi peralihan kategori dapat diatur melalui nilai ambang pada menu pengaturan.
- Di desktop, ganti pose dengan tombol C dan Z. Jika tombol Z tidak mengaktifkan pose berbaring, naikkan ambang tinggi berbaring di menu pengaturan.
- Aktifkan “Gestur mati” untuk memakai bentuk tangan yang diatur pada pose, menggantikan bentuk jari dari pengontrol.
- “Tinggi kaki” menyesuaikan bagian kaki sambil mempertahankan posisi kepala. “Tinggi lantai” menggerakkan seluruh tubuh termasuk kepala ke atas dan ke bawah. Keduanya muncul dalam urutan ini di menu pengaturan.
- Jika bergerak ke depan melalui “Jarak” dalam “Mode foto”, avatar menghadap Anda. Putar dengan “Arah” dan aktifkan “Kunci kaki” saat diperlukan. “Keluar foto” mengembalikan jarak serta arah dan melepas kunci kaki.
- “Napas” tersedia jika animasi napas aktif. Kekuatan diatur di Unity, sedangkan ON/OFF dialihkan dalam permainan.

## Prabuild dan peringatan

“Perbarui prabuild” menggunakan kembali data yang dihasilkan untuk mempercepat build avatar. Tanpa prabuild pun, data yang diperlukan dibuat saat build biasa.

Setelah pengaturan berubah, “Periksa pengaturan” di bagian atas Inspector dan tanda Hierarchy memberi tahu bahwa pembaruan diperlukan. “Tampilan peringatan” berada dalam panel “Periksa pengaturan”. Menyembunyikannya tidak menyelesaikan masalah pengaturan atau memperbarui data yang dihasilkan.

## Catatan penggunaan

- Penguncian pose selama pelacakan seluruh tubuh tidak didukung.
- Penyesuaian tambahan mungkin diperlukan sesuai proporsi tubuh, pakaian, dan modifikasi avatar.
- Integrasi dengan layer Base khusus atau alat pengubah pose lain mungkin tidak bekerja sesuai harapan. Jika penguncian bermasalah, periksa juga “Pengaturan Avatar > Integrasikan kunci pelacakan dengan alat lain”.
- Perpindahan serta rotasi Mode foto dan Tinggi lantai mengoreksi pose alat maupun gerakan bawaan dan khusus ketika tidak ada pose yang dipilih. Periksa sudut pandang akhir dan perilaku setelah penggantian gerakan dalam klien VRChat.
- “Nonaktifkan goyangan diam VRChat” hanya menargetkan gerakan diam bawaan, bukan semua goyangan dari penyebab lain.

## Panduan dan dukungan

Buka panduan, dukungan, dan riwayat perubahan melalui “Bantuan / riwayat perubahan” di bagian atas Inspector. Penjelasan rinci fitur bersama juga tersedia melalui “Packages > Unisaki Posing System > README” di Project Unity.

- [Panduan resmi](https://docs.unisakistudio.jp/coolposing/manual/)
- [Hubungi kami](https://help.unisakistudio.jp/)

Saat melaporkan masalah, sertakan versi produk ini dan Unisaki Posing System, versi Unity, VRChat SDK, Modular Avatar, dan NDMF, avatar yang digunakan, langkah untuk mengulangi masalah, serta rincian kesalahan Console.

## Ketentuan penggunaan

Produk ini menyertakan ketentuan penggunaan VN3 “ゆにさきスタジオ販売・配布データ利用規約（日本語版）Ver1.0.0.pdf”, yang berlaku bersama untuk data yang dijual dan didistribusikan Unisaki Studio. Pastikan membaca isinya sebelum menggunakan.

Kode sumber dan sumber daya repositori ini bukan sumber terbuka. Pembeli sah diberi izin penggunaan dalam batas ketentuan penggunaan yang disertakan.
