-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Oct 23, 2025 at 08:54 PM
-- Server version: 12.0.2-MariaDB
-- PHP Version: 8.4.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `9.24.3-12-ct2`
--

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE `client` (
  `passport` bigint(32) NOT NULL,
  `address` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL CHECK (json_valid(`address`)),
  `phoneNumber` varchar(45) NOT NULL,
  `email` varchar(45) DEFAULT NULL,
  `creditcartList` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL CHECK (json_valid(`creditcartList`)),
  `footSize` int(16) DEFAULT NULL,
  `login` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `fullName` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`passport`, `address`, `phoneNumber`, `email`, `creditcartList`, `footSize`, `login`, `password`, `fullName`) VALUES
(4314884336, '[\r\n  {\"type\": \"Домашний\", \"address\": \"г. Москва, ул. Ясенево, д. 54, стр. 7\"},\r\n  {\"type\": \"Домашний\", \"address\": \"г. Москва, ул. Нагорная, д. 28, стр. 2\"}\r\n]', '+7(948)796-47-89', 'pavlov_d_e@fmail.com', '[\r\n  {\"number\": \"0173 6112 6682 6335\", \"expiry\": \"02/24\"},\r\n  {\"number\": \"0652 7172 4452 7743\", \"expiry\": \"11/25\"},\r\n  {\"number\": \"6822 7622 5773 7832\", \"expiry\": \"10/24\"}\r\n]', 28, 'PavlovDE', 'Pa$$w0rd', 'Павлов Дмитрий Егорович'),
(4512632567, '[\r\n  {\"type\": \"Домашний\", \"address\": \"г. Москва, ул. Достоевская, д. 52, к.6\"},\r\n  {\"type\": \"Рабочий\", \"address\": \"г. Москва, ул. Кропоткинская, д. 6, стр. 3\"}\r\n]', '+7(952)728-91-62', 'vladimirova_o_p@ya.ru', '[\r\n  {\"number\": \"8822 7782 1135 7622\", \"expiry\": \"01/25\"},\r\n  {\"number\": \"9952 6582 8983 1134\", \"expiry\": \"03/24\"}\r\n]', 25, 'VladimirovaOP', 'Pa$$w0rd', 'Владимирова Ольга Петровна'),
(4763226632, '[\r\n  {\"type\": \"Рабочий\", \"address\": \"г. Москва, ул. Каширская, д. 16, к. 2\"}\r\n]', '+7(982)543-34-67', 'ivanov_e_a@gmail.com', '[\r\n  {\"number\": \"0622 7235 7879 7889\", \"expiry\": \"12/24\"}\r\n]', 29, 'IvanovEA', 'Pa$$w0rd', 'Иванов Евгений Андреевич'),
(4576221454, '[\r\n  {\"type\": \"Рабочий\", \"address\": \"г. Москва, ул. Лесопарковая, д. 1, стр. 6\"},\r\n  {\"type\": \"Домашний\", \"address\": \"г. Москва, ул. Шабловская, д. 18, стр. 7\"}\r\n]', '+7(986)883-83-16', 'marinina_v_p@gmail.com', '[\r\n  {\"number\": \"4772 8833 6363 7133\", \"expiry\": \"09/24\"}\r\n]', 24, 'MarininaVP', 'Pa$$w0rd', 'Маринина Вероника Павловна');

-- --------------------------------------------------------

--
-- Table structure for table `contract`
--

CREATE TABLE `contract` (
  `number` int(11) NOT NULL,
  `creationDate` date NOT NULL,
  `term` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  `employeeLogin` varchar(45) NOT NULL,
  `shipper` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `contract`
--

INSERT INTO `contract` (`number`, `creationDate`, `term`, `status`, `employeeLogin`, `shipper`) VALUES
(1, '2023-02-05', '5 лет', 'Активен', 'emp_PetrovPP', 'ООО «Foot Delivery»'),
(2, '2023-04-10', '5 лет', 'Активен', 'emp_PetrovPP', 'НПАО «Быстрая поставка»'),
(3, '2023-04-23', '5 лет', 'Активен', 'emp_PetrovPP', 'НПАО «Обувь к продаже»');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `login` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `fullname` varchar(64) DEFAULT NULL,
  `post` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`login`, `password`, `fullname`, `post`) VALUES
('emp_AleksndrovAA', 'Pa$$w0rd', 'Александров Александр Александрович', 'Кассир'),
('emp_MichailovMM', 'Pa$$w0rd', 'Михаилов Михаил Михайлович', 'Кассир'),
('emp_NikitinNN', 'Pa$$w0rd', 'Никитин Никита Никитич', 'Кассир'),
('emp_PetrovPP', 'Pa$$w0rd', 'Петров Пётр Петрович', 'Менеджер по работе с поставщиками');

-- --------------------------------------------------------

--
-- Table structure for table `estimate`
--

CREATE TABLE `estimate` (
  `number` int(11) NOT NULL,
  `contractNum` int(11) DEFAULT NULL,
  `creationDate` date DEFAULT NULL,
  `deliveryTime` varchar(45) DEFAULT NULL,
  `fullCost` varchar(45) DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  `productList` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL CHECK (json_valid(`productList`))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `estimate`
--

INSERT INTO `estimate` (`number`, `contractNum`, `creationDate`, `deliveryTime`, `fullCost`, `status`, `productList`) VALUES
(1, 1, '2023-08-15', '10 дней', '224500', 'Доставлено', '[\n  {\"article\": 1, \"quantity\": 10, \"cost\": 120000},\n  {\"article\": 5, \"quantity\": 10, \"cost\": 104500}\n]'),
(2, 2, '2023-08-20', '10 дней', '174000', 'Доставлено', '[\n  {\"article\": 3, \"quantity\": 15, \"cost\": 174000}\n]'),
(3, 2, '2023-08-31', '14 дней', '163000', 'Повторная отправка', '[\n  {\"article\": 2, \"quantity\": 10, \"cost\": 115000},\n  {\"article\": 4, \"quantity\": 5, \"cost\": 48000}\n]');

-- --------------------------------------------------------

--
-- Table structure for table `order`
--

CREATE TABLE `order` (
  `orderId` int(11) NOT NULL,
  `creationDateTime` datetime(6) DEFAULT NULL,
  `receivingType` varchar(45) DEFAULT NULL,
  `cost` int(45) DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  `clientPhoneNumber` varchar(45) DEFAULT NULL,
  `EmployeeLogin` varchar(45) DEFAULT NULL,
  `orderPositions` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL CHECK (json_valid(`orderPositions`))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `order`
--

INSERT INTO `order` (`orderId`, `creationDateTime`, `receivingType`, `cost`, `status`, `clientPhoneNumber`, `EmployeeLogin`, `orderPositions`) VALUES
(1, '2023-09-04 11:32:30.000000', 'Самовывоз', 11520, 'Ожидает', '+7(982)543-34-67', 'emp_MichailovMM', '[\n  {\"article\": 4, \"quantity\": 1, \"cost\": 9600}\n]'),
(2, '2023-09-04 15:41:17.000000', 'Самовывоз', 27720, 'Оплачен', '+7(948)796-47-89', 'emp_AleksndrovAA', '[\n  {\"article\": 2, \"quantity\": 1, \"cost\": 11500},\n  {\"article\": 3, \"quantity\": 1, \"cost\": 11600}\n]');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `article` int(11) NOT NULL,
  `country` varchar(45) NOT NULL,
  `mark` varchar(45) NOT NULL,
  `model` varchar(45) NOT NULL,
  `season` varchar(45) NOT NULL,
  `materiallist` varchar(45) NOT NULL,
  `type` varchar(45) NOT NULL,
  `description` text DEFAULT NULL,
  `available` int(11) NOT NULL,
  `cost` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`article`, `country`, `mark`, `model`, `season`, `materiallist`, `type`, `description`, `available`, `cost`) VALUES
(1, 'Китай', 'Nike', 'Air 60', 'Весна, Лето', 'кожа, резина', 'Кроссовки-прогулочные', 'Удобные и комфортные, не позволяет стопам уставать', 100, 12000),
(2, 'Китай', 'Puma', 'Rs X', 'Лето', 'кожа', 'Кроссовки-спортивные', 'Амортизирует стопу при быстром перемещении', 94, 11500),
(3, 'Вьетнам', 'Nike', 'Air Force', 'Осень, Зима', 'кожа, резина, утеплитель', 'Ботинки-прогулочные', 'Удобное для любого времени года, особенности холодного', 29, 11600),
(4, 'Вьетнам', 'Rebook', 'Classic', 'Лето, Осень', 'кожа, замша', 'Ботинки прогулочные', 'Позволят проходить километры, не обращая внимания ни на что', 76, 9600),
(5, 'Вьетнам', 'Rebook', 'Sneak', 'Лето', 'кожа, замша', 'Для активного образа жизни', 'Идеально подойдут для любых поверхностей земли', 40, 10450);

-- --------------------------------------------------------

--
-- Table structure for table `returnCertificate`
--

CREATE TABLE `returnCertificate` (
  `actId` int(11) NOT NULL,
  `estimateNumber` int(45) NOT NULL,
  `productArticle` int(45) NOT NULL,
  `reason` text NOT NULL,
  `creationDateTime` datetime NOT NULL,
  `cost` int(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `returnCertificate`
--

INSERT INTO `returnCertificate` (`actId`, `estimateNumber`, `productArticle`, `reason`, `creationDateTime`, `cost`) VALUES
(1, 3, 4, 'Не тот товар доставлен', '2023-09-02 00:00:00', 52000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`phoneNumber`);

--
-- Indexes for table `contract`
--
ALTER TABLE `contract`
  ADD PRIMARY KEY (`number`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`login`);

--
-- Indexes for table `estimate`
--
ALTER TABLE `estimate`
  ADD PRIMARY KEY (`number`);

--
-- Indexes for table `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`orderId`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`article`);

--
-- Indexes for table `returnCertificate`
--
ALTER TABLE `returnCertificate`
  ADD PRIMARY KEY (`actId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
