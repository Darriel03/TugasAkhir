-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 27, 2022 at 07:00 AM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 7.4.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_pemdesk`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblbarang`
--

CREATE TABLE `tblbarang` (
  `kodebarang` varchar(20) NOT NULL,
  `idkategori` int(11) NOT NULL,
  `namabarang` varchar(50) NOT NULL,
  `merekbarang` varchar(20) NOT NULL,
  `hargabeli` int(11) NOT NULL,
  `hargajual` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblbarang`
--

INSERT INTO `tblbarang` (`kodebarang`, `idkategori`, `namabarang`, `merekbarang`, `hargabeli`, `hargajual`) VALUES
('BR0001', 1, 'Sony Alpha 1', 'Sony', 55000000, 56000000),
('BR0002', 1, 'Sony Alpha A6000S', 'Sony', 3000000, 3200000),
('BR0003', 3, 'A Mount 50mm', 'Sony', 10000000, 11000000),
('BR0004', 3, 'E Mount 30mm', 'Sony', 2300000, 2500000);

-- --------------------------------------------------------

--
-- Table structure for table `tblkategori`
--

CREATE TABLE `tblkategori` (
  `idkategori` int(11) NOT NULL,
  `namakategori` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblkategori`
--

INSERT INTO `tblkategori` (`idkategori`, `namakategori`) VALUES
(1, 'Kamera'),
(2, 'Tripod'),
(3, 'Lensa'),
(12, 'monopod');

-- --------------------------------------------------------

--
-- Table structure for table `tblstok`
--

CREATE TABLE `tblstok` (
  `idstok` varchar(20) NOT NULL,
  `tglpembelian` datetime NOT NULL,
  `grandtotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblstok`
--

INSERT INTO `tblstok` (`idstok`, `tglpembelian`, `grandtotal`) VALUES
('FA22001', '2022-12-26 02:28:42', 2300000),
('INV0002601', '2022-12-26 10:36:26', 59600000),
('INV0011226', '2022-12-26 09:34:47', 138200000),
('INV01294321', '2022-12-26 03:52:56', 12300000),
('PMB0001', '2022-12-24 00:05:24', 91000000),
('PMB0002', '2022-12-24 00:12:59', 15800000),
('PMB0004', '2022-12-26 01:43:46', 123000000);

-- --------------------------------------------------------

--
-- Table structure for table `tblstokdetail`
--

CREATE TABLE `tblstokdetail` (
  `idstokdetail` int(11) NOT NULL,
  `idstok` varchar(20) NOT NULL,
  `kodebarang` varchar(20) NOT NULL,
  `qtystok` int(11) NOT NULL,
  `stokdhrgbeli` int(11) NOT NULL,
  `stokdhrgjual` int(11) NOT NULL,
  `totalhrgbeli` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblstokdetail`
--

INSERT INTO `tblstokdetail` (`idstokdetail`, `idstok`, `kodebarang`, `qtystok`, `stokdhrgbeli`, `stokdhrgjual`, `totalhrgbeli`) VALUES
(1, 'PMB0001', 'BR0001', 1, 55000000, 56000000, 55000000),
(2, 'PMB0001', 'BR0002', 2, 3000000, 3200000, 6000000),
(3, 'PMB0001', 'BR0003', 3, 10000000, 11000000, 30000000),
(4, 'PMB0002', 'BR0002', 2, 2900000, 3100000, 5800000),
(5, 'PMB0002', 'BR0003', 1, 10000000, 11000000, 10000000),
(6, 'PMB0004', 'BR0001', 2, 55000000, 56000000, 110000000),
(7, 'PMB0004', 'BR0002', 1, 3000000, 3200000, 3000000),
(8, 'PMB0004', 'BR0003', 1, 10000000, 11000000, 10000000),
(9, 'FA22001', 'BR0004', 1, 2300000, 2500000, 2300000),
(10, 'INV01294321', 'BR0003', 1, 10000000, 11000000, 10000000),
(11, 'INV01294321', 'BR0004', 1, 2300000, 2500000, 2300000),
(12, 'INV0011226', 'BR0001', 2, 55000000, 56000000, 110000000),
(13, 'INV0011226', 'BR0002', 3, 3000000, 3200000, 9000000),
(14, 'INV0011226', 'BR0003', 1, 10000000, 11000000, 10000000),
(15, 'INV0011226', 'BR0004', 4, 2300000, 2500000, 9200000),
(16, 'INV0002601', 'BR0001', 1, 55000000, 56000000, 55000000),
(17, 'INV0002601', 'BR0004', 2, 2300000, 2500000, 4600000);

-- --------------------------------------------------------

--
-- Table structure for table `tbltransaksi`
--

CREATE TABLE `tbltransaksi` (
  `idtransaksi` varchar(20) NOT NULL,
  `tglpenjualan` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `grandtotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbltransaksi`
--

INSERT INTO `tbltransaksi` (`idtransaksi`, `tglpenjualan`, `grandtotal`) VALUES
('FJ0010', '2022-12-26 02:10:51', 3200000),
('PJ0001', '2022-12-25 14:47:38', 3200000),
('PJ0002', '2022-12-25 14:49:51', 11000000),
('PJ0003', '2022-12-25 17:44:50', 62400000),
('PJ0004', '2022-12-25 19:32:25', 2500000),
('PJ0005', '2022-12-25 20:53:34', 78000000),
('PJ0006', '2022-12-26 01:48:27', 13500000),
('PJ0007', '2022-12-26 01:54:39', 3200000),
('PJ0008', '2022-12-26 01:56:00', 11000000),
('PJ0009', '2022-12-26 01:58:55', 11000000),
('PJ0010', '2022-12-26 02:14:24', 56000000),
('PJ0011', '2022-12-26 02:17:16', 3200000),
('PJ0012', '2022-12-26 02:35:38', 11000000),
('PJ0013', '2022-12-26 03:34:15', 8200000);

-- --------------------------------------------------------

--
-- Table structure for table `tbltransaksidetail`
--

CREATE TABLE `tbltransaksidetail` (
  `idtransaksidetail` int(11) NOT NULL,
  `idtransaksi` varchar(20) NOT NULL,
  `kodebarang` varchar(20) NOT NULL,
  `qtypenjualan` int(11) NOT NULL,
  `hargajual` int(11) NOT NULL,
  `totalhrgjual` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbltransaksidetail`
--

INSERT INTO `tbltransaksidetail` (`idtransaksidetail`, `idtransaksi`, `kodebarang`, `qtypenjualan`, `hargajual`, `totalhrgjual`) VALUES
(1, 'PJ0001', 'BR0002', 1, 3200000, 3200000),
(2, 'PJ0002', 'BR0003', 1, 11000000, 11000000),
(3, 'PJ0003', 'BR0001', 1, 56000000, 56000000),
(4, 'PJ0003', 'BR0002', 2, 3200000, 6400000),
(5, 'PJ0004', 'BR0004', 1, 2500000, 2500000),
(6, 'PJ0005', 'BR0001', 1, 56000000, 56000000),
(7, 'PJ0005', 'BR0003', 2, 11000000, 22000000),
(8, 'PJ0006', 'BR0003', 1, 11000000, 11000000),
(9, 'PJ0006', 'BR0004', 1, 2500000, 2500000),
(10, 'PJ0007', 'BR0002', 1, 3200000, 3200000),
(11, 'PJ0008', 'BR0003', 1, 11000000, 11000000),
(12, 'PJ0009', 'BR0003', 1, 11000000, 11000000),
(14, 'PJ0010', 'BR0001', 1, 56000000, 56000000),
(15, 'PJ0011', 'BR0002', 1, 3200000, 3200000),
(16, 'PJ0012', 'BR0003', 1, 11000000, 11000000),
(17, 'PJ0013', 'BR0002', 1, 3200000, 3200000),
(18, 'PJ0013', 'BR0004', 2, 2500000, 5000000);

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `iduser` int(11) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblbarang`
--
ALTER TABLE `tblbarang`
  ADD PRIMARY KEY (`kodebarang`);

--
-- Indexes for table `tblkategori`
--
ALTER TABLE `tblkategori`
  ADD PRIMARY KEY (`idkategori`);

--
-- Indexes for table `tblstok`
--
ALTER TABLE `tblstok`
  ADD PRIMARY KEY (`idstok`) USING BTREE;

--
-- Indexes for table `tblstokdetail`
--
ALTER TABLE `tblstokdetail`
  ADD PRIMARY KEY (`idstokdetail`);

--
-- Indexes for table `tbltransaksi`
--
ALTER TABLE `tbltransaksi`
  ADD PRIMARY KEY (`idtransaksi`);

--
-- Indexes for table `tbltransaksidetail`
--
ALTER TABLE `tbltransaksidetail`
  ADD PRIMARY KEY (`idtransaksidetail`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`iduser`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblkategori`
--
ALTER TABLE `tblkategori`
  MODIFY `idkategori` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tblstokdetail`
--
ALTER TABLE `tblstokdetail`
  MODIFY `idstokdetail` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `tbltransaksidetail`
--
ALTER TABLE `tbltransaksidetail`
  MODIFY `idtransaksidetail` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `tbluser`
--
ALTER TABLE `tbluser`
  MODIFY `iduser` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
