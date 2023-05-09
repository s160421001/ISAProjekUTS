-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 09, 2023 at 05:22 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `manajemenartis`
--

-- --------------------------------------------------------

--
-- Table structure for table `artis`
--

CREATE TABLE `artis` (
  `id` int(11) NOT NULL,
  `nama` varchar(150) NOT NULL,
  `tanggal_lahir` datetime NOT NULL,
  `tanggal_masuk` datetime NOT NULL,
  `username` varchar(150) NOT NULL,
  `password` varchar(250) NOT NULL,
  `status_manajer` enum('kosong','aktif') NOT NULL DEFAULT 'kosong',
  `manajer_id` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `artis`
--

INSERT INTO `artis` (`id`, `nama`, `tanggal_lahir`, `tanggal_masuk`, `username`, `password`, `status_manajer`, `manajer_id`) VALUES
(1, 'Sehun', '2004-06-15 00:00:00', '2023-05-09 00:00:00', 'artis1', '7wG+XlaSp84=', 'kosong', 0),
(2, 'Beyonce', '2001-02-15 00:00:00', '2023-05-09 00:00:00', 'artis2', 'u6Mm1IRXZdM=', 'kosong', 0),
(3, 'Ariana', '2002-03-13 00:00:00', '2023-05-09 00:00:00', 'artis3', 'zguiqWkNKxY=', 'kosong', 0);

-- --------------------------------------------------------

--
-- Table structure for table `kontrak_kerja`
--

CREATE TABLE `kontrak_kerja` (
  `id` int(11) NOT NULL,
  `judul` varchar(150) NOT NULL,
  `pengaju` varchar(150) NOT NULL,
  `lokasi` varchar(250) NOT NULL,
  `deskripsi` varchar(250) NOT NULL,
  `tanggal_buat` datetime NOT NULL,
  `tanggal_acara` datetime NOT NULL,
  `status_artis` enum('kosong','proses','terima','tolak') NOT NULL,
  `manajer_id` int(11) NOT NULL,
  `artis_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `manajer`
--

CREATE TABLE `manajer` (
  `id` int(11) NOT NULL,
  `nama` varchar(150) NOT NULL,
  `tanggal_lahir` datetime NOT NULL,
  `tanggal_masuk` datetime NOT NULL,
  `username` varchar(150) NOT NULL,
  `password` varchar(250) NOT NULL,
  `jabatan` enum('superAdmin','biasa') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `manajer`
--

INSERT INTO `manajer` (`id`, `nama`, `tanggal_lahir`, `tanggal_masuk`, `username`, `password`, `jabatan`) VALUES
(0, '-', '2023-04-21 08:42:14', '2023-04-21 08:42:14', '-', '-', 'biasa'),
(1, 'Super Admin', '2003-04-23 21:26:25', '2023-05-09 00:00:00', 'super1', '2WZwaLcasEA=', 'superAdmin'),
(2, 'Anthon', '2004-02-10 00:00:00', '2023-05-09 00:00:00', 'manaj1', 'eQLABxJY7S8=', 'biasa'),
(3, 'Risa', '2005-06-04 00:00:00', '2023-05-09 00:00:00', 'manaj2', 'Y+3dA779mP0=', 'biasa');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `artis`
--
ALTER TABLE `artis`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_artis_manajer1_idx` (`manajer_id`);

--
-- Indexes for table `kontrak_kerja`
--
ALTER TABLE `kontrak_kerja`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_kontrak_kerja_manajer1_idx` (`manajer_id`),
  ADD KEY `fk_kontrak_kerja_artis1_idx` (`artis_id`);

--
-- Indexes for table `manajer`
--
ALTER TABLE `manajer`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `artis`
--
ALTER TABLE `artis`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=115;

--
-- AUTO_INCREMENT for table `manajer`
--
ALTER TABLE `manajer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=107;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `artis`
--
ALTER TABLE `artis`
  ADD CONSTRAINT `fk_artis_manajer1` FOREIGN KEY (`manajer_id`) REFERENCES `manajer` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `kontrak_kerja`
--
ALTER TABLE `kontrak_kerja`
  ADD CONSTRAINT `fk_kontrak_kerja_artis1` FOREIGN KEY (`artis_id`) REFERENCES `artis` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_kontrak_kerja_manajer1` FOREIGN KEY (`manajer_id`) REFERENCES `manajer` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
