-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 06 Oca 2017, 15:06:28
-- Sunucu sürümü: 10.1.16-MariaDB
-- PHP Sürümü: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `mezar`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tblmezar`
--

CREATE TABLE `tblmezar` (
  `MID` int(11) NOT NULL,
  `MAD` varchar(255) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `tblmezar`
--

INSERT INTO `tblmezar` (`MID`, `MAD`) VALUES
(1, ''),
(2, ''),
(3, ''),
(4, ''),
(5, ''),
(6, ''),
(7, ''),
(8, ''),
(9, ''),
(10, ''),
(11, ''),
(12, ''),
(13, ''),
(14, ''),
(15, ''),
(16, ''),
(17, ''),
(18, ''),
(19, ''),
(20, ''),
(21, ''),
(22, ''),
(23, ''),
(24, ''),
(25, ''),
(26, ''),
(27, ''),
(28, ''),
(29, ''),
(30, ''),
(31, ''),
(32, ''),
(33, ''),
(34, ''),
(35, ''),
(36, ''),
(37, ''),
(38, ''),
(39, ''),
(40, ''),
(41, ''),
(42, ''),
(43, ''),
(44, ''),
(45, ''),
(46, ''),
(47, ''),
(48, ''),
(49, ''),
(50, '');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbluye`
--

CREATE TABLE `tbluye` (
  `UID` int(11) NOT NULL,
  `UMID` int(11) NOT NULL,
  `UAD` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  `UDOGUMTAR` varchar(20) COLLATE utf8_turkish_ci NOT NULL,
  `UOLUMTAR` varchar(20) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `tbluye`
--

INSERT INTO `tbluye` (`UID`, `UMID`, `UAD`, `UDOGUMTAR`, `UOLUMTAR`) VALUES
(19, 1, 'Ali Veli', '6.01.2017 00:00:00', '6.01.2017 00:00:00');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `tblmezar`
--
ALTER TABLE `tblmezar`
  ADD PRIMARY KEY (`MID`);

--
-- Tablo için indeksler `tbluye`
--
ALTER TABLE `tbluye`
  ADD PRIMARY KEY (`UID`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `tblmezar`
--
ALTER TABLE `tblmezar`
  MODIFY `MID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;
--
-- Tablo için AUTO_INCREMENT değeri `tbluye`
--
ALTER TABLE `tbluye`
  MODIFY `UID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
