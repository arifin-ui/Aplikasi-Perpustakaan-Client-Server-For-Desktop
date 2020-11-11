-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 11 Nov 2020 pada 02.56
-- Versi server: 10.3.16-MariaDB
-- Versi PHP: 7.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_perpustakaan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbbuku`
--

CREATE TABLE `tbbuku` (
  `id_buku` int(50) NOT NULL,
  `JUDUL_BUKU` varchar(50) NOT NULL,
  `NAMA_PENERBIT` varchar(50) NOT NULL,
  `TAHUN_TERBIT` int(11) NOT NULL,
  `STOK` int(11) NOT NULL,
  `NAMA_PENGARANG` varchar(50) NOT NULL,
  `ASAL_BUKU` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbbuku`
--

INSERT INTO `tbbuku` (`id_buku`, `JUDUL_BUKU`, `NAMA_PENERBIT`, `TAHUN_TERBIT`, `STOK`, `NAMA_PENGARANG`, `ASAL_BUKU`) VALUES
(1, 'PEMROGRAMAN HTML & CSS', 'GRAMEDIA', 2018, 15, 'Arifin S.Kom.M,Kom.', 'BELI'),
(3, 'Membuat Game dengan UNITY 3D', 'GRAMEDIA', 2018, 10, 'Mahendra,S.Kom', 'SUMBANGAN'),
(4, 'Belajar Pemrograman JAVA Untuk Pemula', 'PUSTAKA', 2009, 19, 'Anang Subagyo,S.Kom', 'SUMBANGAN');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbpeminjaman`
--

CREATE TABLE `tbpeminjaman` (
  `id` int(11) NOT NULL,
  `ID_PENGGUNA` int(11) DEFAULT NULL,
  `ID_BUKU` int(11) NOT NULL,
  `TANGGAL_PINJAM` date DEFAULT NULL,
  `JUMLAH_PINJAM` int(11) NOT NULL,
  `STATUS` varchar(50) NOT NULL,
  `date_time` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbpeminjaman`
--

INSERT INTO `tbpeminjaman` (`id`, `ID_PENGGUNA`, `ID_BUKU`, `TANGGAL_PINJAM`, `JUMLAH_PINJAM`, `STATUS`, `date_time`) VALUES
(69, 2, 1, '2020-11-10', 1, 'DIKEMBALIKAN', '2020-11-10 12:40:24'),
(70, 3, 4, '2020-11-03', 1, 'DIPINJAM', '2020-11-10 14:06:13');

--
-- Trigger `tbpeminjaman`
--
DELIMITER $$
CREATE TRIGGER `STOK_BUKU_KEMBALI` AFTER UPDATE ON `tbpeminjaman` FOR EACH ROW BEGIN 
	UPDATE tbbuku SET STOK = STOK+NEW.JUMLAH_PINJAM 
    WHERE id_buku=NEW.id_buku;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `STOK_BUKU_KURANG` AFTER INSERT ON `tbpeminjaman` FOR EACH ROW BEGIN 
	UPDATE tbbuku SET STOK = STOK-NEW.JUMLAH_PINJAM 
    WHERE id_buku=NEW.id_buku;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `STOK_BUKU_TAMBAH` AFTER DELETE ON `tbpeminjaman` FOR EACH ROW BEGIN 
	UPDATE tbbuku SET STOK = STOK+OLD.JUMLAH_PINJAM 
    WHERE id_buku=OLD.id_buku;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbpengembalian`
--

CREATE TABLE `tbpengembalian` (
  `id` int(11) NOT NULL,
  `id_pinjam` int(11) NOT NULL,
  `id_buku` int(11) NOT NULL,
  `id_pengguna` int(11) NOT NULL,
  `JUMLAH_KEMBALI` int(11) NOT NULL,
  `TANGGAL_KEMBALI` date NOT NULL,
  `DENDA` int(11) NOT NULL,
  `KETERANGAN` text NOT NULL,
  `STATUS` text NOT NULL,
  `date_time` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbpengembalian`
--

INSERT INTO `tbpengembalian` (`id`, `id_pinjam`, `id_buku`, `id_pengguna`, `JUMLAH_KEMBALI`, `TANGGAL_KEMBALI`, `DENDA`, `KETERANGAN`, `STATUS`, `date_time`) VALUES
(14, 69, 1, 2, 1, '2020-11-18', 1000, 'TERLAMBAT 1 HARI', 'DIKEMBALIKAN', '2020-11-10 12:40:46');

--
-- Trigger `tbpengembalian`
--
DELIMITER $$
CREATE TRIGGER `PENGEMBALIAN` AFTER INSERT ON `tbpengembalian` FOR EACH ROW BEGIN 
	UPDATE tbpeminjaman SET STATUS = 'DIKEMBALIKAN'
    WHERE id_buku=NEW.id_buku;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbpengguna`
--

CREATE TABLE `tbpengguna` (
  `id_pengguna` int(11) NOT NULL,
  `NAMA` varchar(50) NOT NULL,
  `JURUSAN` varchar(50) NOT NULL,
  `KELAS` varchar(50) NOT NULL,
  `NIM` varchar(50) NOT NULL,
  `PASSWORD` varchar(50) NOT NULL,
  `AKSES` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbpengguna`
--

INSERT INTO `tbpengguna` (`id_pengguna`, `NAMA`, `JURUSAN`, `KELAS`, `NIM`, `PASSWORD`, `AKSES`) VALUES
(1, 'Arifin', '-', '-', '2020150032', '31', 'admin'),
(2, 'Doni', 'Teknik Informatika', '2', '2020150056', '12345', 'pengguna'),
(3, 'Budi', 'Teknik Informatika', '1', '2020150023', '12', 'pengguna');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbbuku`
--
ALTER TABLE `tbbuku`
  ADD PRIMARY KEY (`id_buku`);

--
-- Indeks untuk tabel `tbpeminjaman`
--
ALTER TABLE `tbpeminjaman`
  ADD PRIMARY KEY (`id`),
  ADD KEY `ID_BUKU` (`ID_BUKU`),
  ADD KEY `ID_PENGGUNA` (`ID_PENGGUNA`);

--
-- Indeks untuk tabel `tbpengembalian`
--
ALTER TABLE `tbpengembalian`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `tbpengguna`
--
ALTER TABLE `tbpengguna`
  ADD PRIMARY KEY (`id_pengguna`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tbbuku`
--
ALTER TABLE `tbbuku`
  MODIFY `id_buku` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT untuk tabel `tbpeminjaman`
--
ALTER TABLE `tbpeminjaman`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=71;

--
-- AUTO_INCREMENT untuk tabel `tbpengembalian`
--
ALTER TABLE `tbpengembalian`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT untuk tabel `tbpengguna`
--
ALTER TABLE `tbpengguna`
  MODIFY `id_pengguna` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbpeminjaman`
--
ALTER TABLE `tbpeminjaman`
  ADD CONSTRAINT `tbpeminjaman_ibfk_1` FOREIGN KEY (`ID_BUKU`) REFERENCES `tbbuku` (`id_buku`),
  ADD CONSTRAINT `tbpeminjaman_ibfk_2` FOREIGN KEY (`ID_PENGGUNA`) REFERENCES `tbpengguna` (`id_pengguna`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
