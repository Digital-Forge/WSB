-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 01 Lip 2021, 19:57
-- Wersja serwera: 10.4.17-MariaDB
-- Wersja PHP: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `srsf_db`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `access`
--

CREATE TABLE `access` (
  `login` varchar(25) COLLATE utf8_polish_ci NOT NULL,
  `password` varchar(255) COLLATE utf8_polish_ci NOT NULL,
  `id_user` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `access`
--

INSERT INTO `access` (`login`, `password`, `id_user`) VALUES
('Azymut', '$2y$10$6l8qtQGuLkIDUppoOqjDI.38RHyuIUFb/DEwXrgJmgfknSMJYPhcu', 1),
('Bob123', '$2y$10$EXMy70e.Sgy0yqIWAWbShuoThPL74o7bS3pXjI0u74uppxE30Tegy', 3),
('Edziu_007', '$2y$10$CxxeWogNwvpedMCvDeA/5ewbRSfD1O3tiZFPVcjs8xe.i0p1F43hO', 4),
('Baczny.com', '$2y$10$B2NTHR0ZveMdl346fjMWwOeB215BhqF9dmecVfgFAUMcFd0U2Kh32', 5),
('Kucyk-hops', '$2y$10$aNvqq7cEcmNxHiX8jmmZIerSOiHiPShPyPXD.2sohJrhO4tJwM9mG', 6),
('Rost2048', '$2y$10$a1Fw2TLVBpe8a/K1W6zgz.3AnvJlCEaJCrrYjh/RFP3X0F1ID2enq', 7),
('BSiano25293', '$2y$10$PFDRy3p4EA0Baa96QVmj5ugAZQJflsVnAKgVbpk2liXExX4jeFap.', 8),
('Bulwa2', '$2y$10$WlLt26Z0dD1xs2lvJP3CWuQ7Arc.uIfAXBkvF3uB5G6Uh4rkOPgfa', 9),
('torcik21', '$2y$10$TJg6JCPeVVomzNg6Kukm/eqQKaXdr31TAvCwH9rIOTWROo1XiaWdq', 10),
('Anihilacja', '$2y$10$4QoDdeGRlXy.Ewt7zD55S.QtGbgNJjxpFBfwFEEqp9ehEb.4W8.em', 11);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `block_items`
--

CREATE TABLE `block_items` (
  `id_item` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `date_start` date NOT NULL,
  `date_end` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `items`
--

CREATE TABLE `items` (
  `id_item` int(11) NOT NULL,
  `item_type` varchar(30) COLLATE utf8_polish_ci NOT NULL,
  `item_name` varchar(70) COLLATE utf8_polish_ci NOT NULL,
  `description` text COLLATE utf8_polish_ci NOT NULL,
  `img` varchar(100) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `items`
--

INSERT INTO `items` (`id_item`, `item_type`, `item_name`, `description`, `img`) VALUES
(35437, 'laptop', 'Laptop MSI GF63 Thin 10SC-063XPL', 'Specyfikacja : <br/>\r\n+ Procesor - Intel Core i5-10300H 2.5 GHz / 4.5 GHz <br/>\r\n+ Ram - 8 GB 3200 MHz <br/>\r\n+ Karta Graficzka - NVIDIA GeForce GTX 1650 Max-Q 4 GB <br/>\r\n+ Ekran - 15.6\" IPS 1920 x 1080 (Full HD) 60 Hz <br/>\r\n+ USB 3.0 - 3 <br/>\r\n+ Bateria - 51 Wh około 7h pracy <br/>\r\n+ System - Windows 10 Pro <br/>\r\n+ Waga - 1.86 <br/>', 'img/laptop1.jpg'),
(35440, 'laptop', 'Laptop Apple MacBook Pro 13 M1', 'Specyfikacja : <br/>\r\n+ Procesor - Apple M1 3.2 GHz <br/>\r\n+ Ram - 8 GB 4266 MHz <br/>\r\n+ Karta Graficzka - Apple M1 <br/>\r\n+ Ekran - 13.3\" IPS 2560 x 1600 (WQXGA) 60 Hz <br/>\r\n+ Thunderbolt - 2 <br/>\r\n+ Bateria - 58 Wh około 20 h pracy <br/>\r\n+ System - macOS <br/>\r\n+ Waga - 1.4 <br/>', 'img/laptop2.jpg'),
(35441, 'laptop', 'Laptop Apple MacBook Pro 13 M1', 'Specyfikacja : <br/>\r\n+ Procesor - Apple M1 3.2 GHz <br/>\r\n+ Ram - 8 GB 4266 MHz <br/>\r\n+ Karta Graficzka - Apple M1 <br/>\r\n+ Ekran - 13.3\" IPS 2560 x 1600 (WQXGA) 60 Hz <br/>\r\n+ Thunderbolt - 2 <br/>\r\n+ Bateria - 58 Wh około 20 h pracy <br/>\r\n+ System - macOS <br/>\r\n+ Waga - 1.4 <br/>', 'img/laptop2.jpg'),
(35442, 'laptop', 'Laptop Toshiba Satellite Pro', 'Specyfikacja : <br/>\r\n+ Procesor - Intel Core i3-7020U 2.3 GHz / 4.5 GHz <br/>\r\n+ Ram - 8 GB 2666 MHz <br/>\r\n+ Karta Graficzka - NVIDIA GeForce GTX 1650 Max-Q 4 GB <br/>\r\n+ Ekran - 15.6\" TN 1920 x 1080 (Full HD) 60 Hz <br/>\r\n+ USB 3.0 - 2 <br/>\r\n+ Bateria - około 8h pracy <br/>\r\n+ System - Windows 10 Pro <br/>\r\n+ Waga - 1.76 <br/>', 'img/laptop3.jpg'),
(35443, 'laptop', 'Laptop Gigabyte G5', 'Specyfikacja : <br/>\r\n+ Procesor - Intel Core i5-10300H 2.5 GHz / 4.5 GHz <br/>\r\n+ Ram - 16 GB 3200 MHz <br/>\r\n+ Karta Graficzka - NVIDIA GeForce RTX 3060 Laptop GPU 6 GB <br/>\r\n+ Ekran - 15.6\" IPS 1920 x 1080 (Full HD) 144 Hz <br/>\r\n+ USB 3.0 - 2 <br/>\r\n+ Bateria - 49 Wh około 6h pracy <br/>\r\n+ System - Windows 10 Pro <br/>\r\n+ Waga - 2.2 <br/>', 'img/laptop4.jpg'),
(35444, 'telefon', 'Smartfon Samsung Galaxy S20 Plus 5G', 'Specyfikacja : <br/>\r\n+ Procesor - Exynos 990 2.7 GHz Octa Core <br/>\r\n+ Ram - 12 GB <br/>\r\n+ Pamięć - 128 GB <br/>\r\n+ Modem 5G - tak <br/>\r\n+ kolor - czarny <br/>\r\n+ Wodoodporny/pyłoodporny - IP68 <br/>\r\n+ Ekran - 6.7\" Dynamic AMOLED 1440 x 3200 60 Hz <br/>\r\n+ Aparat główny - 64 + 12 + 12 MPix + obiektyw głębi <br/>\r\n+ Aparat przedni - 10 MPix <br/>\r\n+ System - Android 10 <br/>\r\n+ Bateria - 4500[mAh] <br/>', 'img/telefon1.jpg'),
(35445, 'telefon', 'Smartfon Samsung Galaxy S21 Ultra 5G 128 GB Dual SIM Srebrny', 'Specyfikacja : <br/>\r\n+ Procesor - Exynos 2100 2.9 GHz Octa Core <br/>\r\n+ Ram - 12 GB <br/>\r\n+ Pamięć - 256 GB <br/>\r\n+ Wodoodporny/pyłoodporny - IP68 <br/>\r\n+ Ekran - 6.8\" Dynamic AMOLED 1440 x 3200 60 Hz <br/>\r\n+ Aparat główny - 108 + 12 + 10 + 10 MPix <br/>\r\n+ Aparat przedni - 40 MPix <br/>\r\n+ System - Android 11 <br/>\r\n+ Bateria - 5000[mAh] <br/>', 'img/telefon2.jpg'),
(35446, 'telefon', 'Smartfon Samsung Galaxy S21 Ultra 5G 128 GB Dual SIM Srebrny', 'Specyfikacja : <br/>\r\n+ Procesor - Exynos 2100 2.9 GHz Octa Core <br/>\r\n+ Ram - 12 GB <br/>\r\n+ Pamięć - 256 GB <br/>\r\n+ Wodoodporny/pyłoodporny - IP68 <br/>\r\n+ Ekran - 6.8\" Dynamic AMOLED 1440 x 3200 60 Hz <br/>\r\n+ Aparat główny - 108 + 12 + 10 + 10 MPix <br/>\r\n+ Aparat przedni - 40 MPix <br/>\r\n+ System - Android 11 <br/>\r\n+ Bateria - 5000[mAh] <br/>', 'img/telefon2.jpg'),
(35447, 'laptop', 'Laptop Gigabyte G5', 'Specyfikacja : <br/>\r\n+ Procesor - Intel Core i5-10300H 2.5 GHz / 4.5 GHz <br/>\r\n+ Ram - 16 GB 3200 MHz <br/>\r\n+ Karta Graficzka - NVIDIA GeForce RTX 3060 Laptop GPU 6 GB <br/>\r\n+ Ekran - 15.6\" IPS 1920 x 1080 (Full HD) 144 Hz <br/>\r\n+ USB 3.0 - 2 <br/>\r\n+ Bateria - 49 Wh około 6h pracy <br/>\r\n+ System - Windows 10 Pro <br/>\r\n+ Waga - 2.2 <br/>', 'img/laptop4.jpg'),
(35448, 'telefon', 'Smartfon Samsung Galaxy S21 Ultra 5G 128 GB Dual SIM Srebrny', 'Specyfikacja : <br/>\r\n+ Procesor - Exynos 2100 2.9 GHz Octa Core <br/>\r\n+ Ram - 12 GB <br/>\r\n+ Pamięć - 256 GB <br/>\r\n+ Wodoodporny/pyłoodporny - IP68 <br/>\r\n+ Ekran - 6.8\" Dynamic AMOLED 1440 x 3200 60 Hz <br/>\r\n+ Aparat główny - 108 + 12 + 10 + 10 MPix <br/>\r\n+ Aparat przedni - 40 MPix <br/>\r\n+ System - Android 11 <br/>\r\n+ Bateria - 5000[mAh] <br/>', 'img/telefon2.jpg'),
(35449, 'auto', 'Jeep Cherokee 3.2', '- Wersja - 3.2 V6 Active Drive I Limited <br/>\r\n- Rok produkcji - 2019 <br/>\r\n- Przebieg - 26 533 km <br/>\r\n- Pojemność skokowa - 3 239 cm3 <br/>\r\n- Rodzaj - paliwa Benzyna <br/>\r\n- Moc - 272 KM <br/>\r\n- Skrzynia biegów - Automatyczna <br/>\r\n- Napęd - Na przednie koła <br/>\r\n- Spalanie W Cyklu Mieszanym - 10 l/100km <br/>\r\n- Spalanie Poza Miastem - 7 l/100km <br/>\r\n- Spalanie W Mieście 13 - l/100km <br/>\r\n', 'img/auto1.jfif'),
(35450, 'auto', 'Škoda Superb 2.0', '- Wersja - 2.0 TSI 4x4 L&K DSG <br/>\r\n- Rok produkcji - 2018 <br/>\r\n- Przebieg - 65 588 km <br/>\r\n- Pojemność skokowa - 1 984 cm3 <br/>\r\n- Rodzaj paliwa - Benzyna <br/>\r\n- Moc - 280 KM <br/>\r\n- Skrzynia biegów - Automatyczna <br/>\r\n- Napęd - 4x4 (stały) <br/>\r\n- Spalanie W Cyklu Mieszanym - 7 l/100km <br/>\r\n- Spalanie Poza Miastem - 6 l/100km <br/>\r\n- Spalanie W Mieście - 8 l/100km <br/>\r\n', 'img/auto2.jfif'),
(35451, 'PC', 'Składany Najwyższa specyfikacja', 'Specyfikacja : <br/>\r\n+ Procesor - Procesor Intel Core i9-11900KF, 3.5GHz, 16 MB <br/>\r\n+ Ram - Pamięć G.Skill Trident Z Neo, DDR4, 128 GB, 3600MHz, CL18 <br/>\r\n+ Karta Graficzka - Karta graficzna Gigabyte GeForce RTX 3080 Ti Gaming OC 12GB GDDR6X <br/>\r\n+ System - Windows 10 Pro <br/>\r\n+ Pamięć SSD - Samsung 980 PRO 500 GB M.2 2280 PCI-E x4 Gen4 NVMe <br/>\r\n+ Pamięć HDD - Toshiba 4 TB 3.5\" SATA III X300 <br/>\r\n+ Chłodzenie - Wodne <br/>\r\n', 'img/PC1.jpg');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `items_type`
--

CREATE TABLE `items_type` (
  `item_type` varchar(30) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `items_type`
--

INSERT INTO `items_type` (`item_type`) VALUES
('auto'),
('laptop'),
('PC'),
('telefon');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `users`
--

CREATE TABLE `users` (
  `id_user` int(11) NOT NULL,
  `user_type` varchar(6) COLLATE utf8_polish_ci NOT NULL,
  `name` varchar(30) COLLATE utf8_polish_ci NOT NULL,
  `surname` varchar(30) COLLATE utf8_polish_ci NOT NULL,
  `phone` varchar(11) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `users`
--

INSERT INTO `users` (`id_user`, `user_type`, `name`, `surname`, `phone`) VALUES
(1, 'admin', 'Filip', 'Bączek', '123-123-123'),
(3, 'user', 'Bob', 'Rączka', '321-321-321'),
(4, 'user', 'Edward', 'Zając', '007-007-007'),
(5, 'user', 'Marek', 'Baczny', '222-222-222'),
(6, 'user', 'Natalia', 'Kucyk', '303-303-303'),
(7, 'admin', 'Emma', 'Rost', '587-586-768'),
(8, 'user', 'Barbara', 'Siano', '888-888-888'),
(9, 'user', 'Maciej', 'Ziemniak', '763-566-568'),
(10, 'user', 'Adam', 'Baczek', '345-345-345'),
(11, 'user', 'Przemysław', 'Grabarczuk', '876-576-455');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `users_type`
--

CREATE TABLE `users_type` (
  `user_type` varchar(30) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `users_type`
--

INSERT INTO `users_type` (`user_type`) VALUES
('admin'),
('user');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `access`
--
ALTER TABLE `access`
  ADD PRIMARY KEY (`id_user`),
  ADD UNIQUE KEY `login` (`login`);

--
-- Indeksy dla tabeli `block_items`
--
ALTER TABLE `block_items`
  ADD PRIMARY KEY (`id_item`);

--
-- Indeksy dla tabeli `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`id_item`);

--
-- Indeksy dla tabeli `items_type`
--
ALTER TABLE `items_type`
  ADD PRIMARY KEY (`item_type`);

--
-- Indeksy dla tabeli `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id_user`);

--
-- Indeksy dla tabeli `users_type`
--
ALTER TABLE `users_type`
  ADD PRIMARY KEY (`user_type`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `access`
--
ALTER TABLE `access`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT dla tabeli `items`
--
ALTER TABLE `items`
  MODIFY `id_item` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35452;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
