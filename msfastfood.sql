-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 09 Wrz 2021, 14:39
-- Wersja serwera: 10.4.20-MariaDB
-- Wersja PHP: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `msfastfood`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `burgers`
--

CREATE TABLE `burgers` (
  `id_burger` int(10) UNSIGNED NOT NULL,
  `name` text NOT NULL,
  `vegan` enum('yes','no') NOT NULL,
  `price` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `burgers`
--

INSERT INTO `burgers` (`id_burger`, `name`, `vegan`, `price`) VALUES
(1001, 'hamburger', 'no', 15),
(1002, 'cheeseburger', 'no', 17),
(1003, 'veggieburger', 'yes', 17),
(1004, 'tofuburger', 'yes', 18),
(1005, 'doublehamburger', 'no', 23),
(1006, 'chickenwrap', 'no', 16),
(1007, 'wrap', 'no', 19),
(1008, 'falafel wrap', 'yes', 17),
(1009, 'burrito', 'no', 23),
(1010, 'veggie burrito', 'yes', 23);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `drinks`
--

CREATE TABLE `drinks` (
  `id_drink` int(10) UNSIGNED NOT NULL,
  `name` text NOT NULL,
  `size` enum('small','large') NOT NULL,
  `iced` enum('yes','no') NOT NULL,
  `price` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `drinks`
--

INSERT INTO `drinks` (`id_drink`, `name`, `size`, `iced`, `price`) VALUES
(2001, 'pepsi', 'small', 'yes', 6),
(2002, 'pepsi', 'large', 'yes', 9),
(2003, 'fanta', 'small', 'yes', 6),
(2004, 'fanta', 'large', 'yes', 9),
(2005, 'sprite', 'small', 'yes', 6),
(2006, 'fanta', 'large', 'yes', 9);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `orders`
--

CREATE TABLE `orders` (
  `id_order` int(10) UNSIGNED NOT NULL,
  `amount_to_pay` float UNSIGNED NOT NULL DEFAULT 0,
  `payment_method` enum('cash','card') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `order_items`
--

CREATE TABLE `order_items` (
  `id_order_items` int(10) UNSIGNED NOT NULL,
  `id_order` int(10) UNSIGNED NOT NULL,
  `id_burger` int(10) UNSIGNED DEFAULT NULL,
  `id_drink` int(10) UNSIGNED DEFAULT NULL,
  `id_set` int(11) UNSIGNED DEFAULT NULL,
  `price` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `sets`
--

CREATE TABLE `sets` (
  `id_set` int(10) UNSIGNED NOT NULL,
  `name` text NOT NULL,
  `id_product1` int(10) UNSIGNED NOT NULL,
  `id_product2` int(10) UNSIGNED NOT NULL,
  `price` float UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `sets`
--

INSERT INTO `sets` (`id_set`, `name`, `id_product1`, `id_product2`, `price`) VALUES
(3001, 'Burger-set', 1001, 2001, 17),
(3002, 'veggie-set', 1003, 2001, 18);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `burgers`
--
ALTER TABLE `burgers`
  ADD PRIMARY KEY (`id_burger`);

--
-- Indeksy dla tabeli `drinks`
--
ALTER TABLE `drinks`
  ADD PRIMARY KEY (`id_drink`);

--
-- Indeksy dla tabeli `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id_order`);

--
-- Indeksy dla tabeli `order_items`
--
ALTER TABLE `order_items`
  ADD PRIMARY KEY (`id_order_items`);

--
-- Indeksy dla tabeli `sets`
--
ALTER TABLE `sets`
  ADD PRIMARY KEY (`id_set`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `orders`
--
ALTER TABLE `orders`
  MODIFY `id_order` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT dla tabeli `order_items`
--
ALTER TABLE `order_items`
  MODIFY `id_order_items` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
