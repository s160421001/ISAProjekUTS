Pada aplikasi yang sudah kami buat menggunakan teknik steganography dalam menyimpan data. Namun ada code yang wajib dirubah secara manual karena path gambar di setiap komputer itu berbeda. Berikut code yang harus dirubah:

CLASS Kontrak_kerja:
Bagian "........" nantinya silahkan diisi dengan lokasi path gambar sebelum memasuki file ISAProjekUTS. Klik kanan pada gambar "kontrak" pada file "SteganoPict" lalu pilih properties. Jika sudah maka akan terlihat location gambar tersebut.

Berikut line yang harus diubah:
> Line 308: Ubah bagian
"C:\\Users\\Steven Christopher\\Desktop\\UBAYA\\Semester 4\\Information Security and Assurance\\ISAProjekUTS\\ProjekISA_01_SVF_ManajemenArtis\\SteganoPict\\kontrak.png"

Menjadi:
"........\\ISAProjekUTS\\ProjekISA_01_SVF_ManajemenArtis\\SteganoPict\\kontrak.png"


> Line 314: Ubah bagian
"C:\\Users\\Steven Christopher\\Desktop\\UBAYA\\Semester 4\\Information Security and Assurance\\ISAProjekUTS\\ProjekISA_01_SVF_ManajemenArtis\\SteganoPict\\kontrak" + GenerateIdKontrakTerbaru() + ".png";

Menjadi:
........\\ISAProjekUTS\\ProjekISA_01_SVF_ManajemenArtis\\SteganoPict\\kontrak" + GenerateIdKontrakTerbaru() + ".png";


> Line 315: Ubah bagian
"C:\\\Users\\\Steven Christopher\\\Desktop\\\UBAYA\\\Semester 4\\\Information Security and Assurance\\\ISAProjekUTS\\\ProjekISA_01_SVF_ManajemenArtis\\\SteganoPict\\\kontrak" + GenerateIdKontrakTerbaru() + ".png"

Menjadi:
"........\\\ISAProjekUTS\\\ProjekISA_01_SVF_ManajemenArtis\\\SteganoPict\\\kontrak" + GenerateIdKontrakTerbaru() + ".png"