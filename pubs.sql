-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 16-11-2026 a las 07:18:13
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `pubs`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `authors`
--

CREATE TABLE `authors` (
  `au_id` varchar(11) NOT NULL,
  `au_lname` varchar(40) NOT NULL,
  `au_fname` varchar(20) NOT NULL,
  `phone` char(12) NOT NULL,
  `address` varchar(40) DEFAULT NULL,
  `city` varchar(20) DEFAULT NULL,
  `state` char(2) DEFAULT NULL,
  `zip` char(5) DEFAULT NULL,
  `contract` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `authors`
--

INSERT INTO `authors` (`au_id`, `au_lname`, `au_fname`, `phone`, `address`, `city`, `state`, `zip`, `contract`) VALUES
('172-32-1176', 'White', 'Johnson', '408 496-7223', '1122 Old Ranch Rd.', 'Menlo Park', 'CA', '94025', 1),
('213-46-8915', 'Green', 'Marjorie', '415 986-7020', '520 34th St. Apt. #3', 'Oakland', 'CA', '94609', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `discounts`
--

CREATE TABLE `discounts` (
  `discounttype` varchar(40) NOT NULL,
  `stor_id` char(4) DEFAULT NULL,
  `lowqty` smallint(6) DEFAULT NULL,
  `highqty` smallint(6) DEFAULT NULL,
  `discount` decimal(4,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `discounts`
--

INSERT INTO `discounts` (`discounttype`, `stor_id`, `lowqty`, `highqty`, `discount`) VALUES
('Volume Discount', '7066', 1, 100, 10.00),
('Volume Discount', '7067', 1, 50, 5.00),
('Volume Discount', '7131', 1, 100, 10.00),
('Initial Order', NULL, 1, 200, 12.50);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `employee`
--

CREATE TABLE `employee` (
  `emp_id` char(9) NOT NULL,
  `fname` varchar(20) NOT NULL,
  `min` char(1) DEFAULT NULL,
  `lname` varchar(30) NOT NULL,
  `job_id` smallint(6) NOT NULL,
  `job_lvl` smallint(6) DEFAULT NULL,
  `pub_id` char(4) NOT NULL,
  `hire_date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `employee`
--

INSERT INTO `employee` (`emp_id`, `fname`, `min`, `lname`, `job_id`, `job_lvl`, `pub_id`, `hire_date`) VALUES
('FEN56534M', 'Francisco', 'E', 'Navarro', 6, 35, '0877', '1992-02-05 00:00:00'),
('HBE30932M', 'Howard', 'B', 'Epstein', 12, 95, '0877', '1991-03-01 00:00:00'),
('PMA42628M', 'Paolo', 'M', 'Accorti', 13, 35, '0877', '1992-08-29 00:00:00'),
('PSA89086F', 'Pedro', 'S', 'Afonso', 14, 17, '0877', '1990-12-24 00:00:00'),
('VPA30890F', 'Victoria', 'P', 'Ashworth', 7, 127, '0877', '1990-06-13 00:00:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `jobs`
--

CREATE TABLE `jobs` (
  `job_id` smallint(6) NOT NULL,
  `job_desc` varchar(50) NOT NULL,
  `min_lvl` smallint(6) NOT NULL,
  `max_lvl` smallint(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `jobs`
--

INSERT INTO `jobs` (`job_id`, `job_desc`, `min_lvl`, `max_lvl`) VALUES
(1, 'New Hire - Misc', 10, 10),
(2, 'Chief Executive Officer', 127, 127),
(3, 'Business Operations Manager', 127, 127),
(4, 'Chief Financial Officer', 127, 127),
(5, 'Publisher', 127, 127),
(6, 'Managing Editor', 127, 127),
(7, 'Marketing Associate', 120, 127),
(8, 'Public Relations Manager', 127, 127),
(9, 'Database Administrator', 125, 127),
(10, 'Acquisitions Manager', 120, 127),
(11, 'Operations Manager', 127, 127),
(12, 'Editor', 100, 127),
(13, 'Sales Representative', 90, 127),
(14, 'Designer', 80, 120);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `publishers`
--

CREATE TABLE `publishers` (
  `pub_id` char(4) NOT NULL,
  `pub_name` varchar(40) DEFAULT NULL,
  `city` varchar(20) DEFAULT NULL,
  `state` char(2) DEFAULT NULL,
  `country` varchar(30) DEFAULT 'USA'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `publishers`
--

INSERT INTO `publishers` (`pub_id`, `pub_name`, `city`, `state`, `country`) VALUES
('0736', 'New Moon Books', 'Boston', 'MA', 'USA'),
('0877', 'Binnet & Hardley', 'Washington', 'DC', 'USA'),
('1389', 'Algodata Infosystems', 'Berkeley', 'CA', 'USA'),
('1622', 'Five Lakes Publishing', 'Chicago', 'IL', 'USA'),
('1756', 'Ramona Publishers', 'Dallas', 'TX', 'USA');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pub_info`
--

CREATE TABLE `pub_info` (
  `pub_id` char(4) NOT NULL,
  `logo` longblob DEFAULT NULL,
  `pr_info` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `pub_info`
--

INSERT INTO `pub_info` (`pub_id`, `logo`, `pr_info`) VALUES
('0736', NULL, 'New Moon Books (NMB) publishes new age books and a quarterly magazine.'),
('0877', NULL, 'Binnet & Hardley publishes a wide range of trade and textbook titles.'),
('1389', NULL, 'Algodata Infosystems specializes in computer software and database manuals.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `roysched`
--

CREATE TABLE `roysched` (
  `title_id` varchar(6) NOT NULL,
  `lorange` int(11) DEFAULT NULL,
  `hirange` int(11) DEFAULT NULL,
  `royalty` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `roysched`
--

INSERT INTO `roysched` (`title_id`, `lorange`, `hirange`, `royalty`) VALUES
('BU1032', 1, 50, 10),
('BU1032', 51, 100, 12),
('BU1032', 101, 500, 14),
('BU1111', 1, 100, 10),
('MC2222', 1, 100, 12);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sales`
--

CREATE TABLE `sales` (
  `stor_id` char(4) NOT NULL,
  `ord_num` varchar(20) NOT NULL,
  `ord_date` datetime NOT NULL,
  `qty` smallint(6) NOT NULL,
  `payterms` varchar(20) NOT NULL,
  `title_id` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `sales`
--

INSERT INTO `sales` (`stor_id`, `ord_num`, `ord_date`, `qty`, `payterms`, `title_id`) VALUES
('7066', 'A297', '1993-05-24 00:00:00', 50, 'Net 60', 'BU1032'),
('7067', 'D4482', '1994-09-14 00:00:00', 10, 'Net 30', 'PC1035'),
('7067', 'QA7442.3', '1992-09-13 00:00:00', 75, 'On Invoice', 'PS2091'),
('7131', 'N914008', '1994-09-14 00:00:00', 20, 'Net 30', 'MC2222'),
('8042', 'P3087a', '1993-05-29 00:00:00', 25, 'Net 60', 'BU1111');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `stores`
--

CREATE TABLE `stores` (
  `stor_id` char(4) NOT NULL,
  `stor_name` varchar(40) DEFAULT NULL,
  `stor_address` varchar(40) DEFAULT NULL,
  `city` varchar(20) DEFAULT NULL,
  `state` char(2) DEFAULT NULL,
  `zip` char(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `stores`
--

INSERT INTO `stores` (`stor_id`, `stor_name`, `stor_address`, `city`, `state`, `zip`) VALUES
('7066', 'Barnum\'s', '567 Binney St.', 'Boston', 'MA', '02133'),
('7067', 'News & Brews', '577 First St.', 'Los Gatos', 'CA', '95030'),
('7089', 'Bookbeat', '679 Porscha St.', 'Seattle', 'WA', '98105'),
('7131', 'Doc-U-Mat: Quality Laundry and Books', '2416 Andiles St.', 'Seattle', 'WA', '98105'),
('7896', 'Fricative Bookshop', '123 Main St.', 'Fremont', 'CA', '94536'),
('8042', 'Eric the Read Books', '788 Catamaugus Ave.', 'Seattle', 'WA', '98105');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `titleauthor`
--

CREATE TABLE `titleauthor` (
  `au_id` varchar(11) NOT NULL,
  `title_id` varchar(6) NOT NULL,
  `au_ord` tinyint(4) DEFAULT NULL,
  `royaltyper` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `titleauthor`
--

INSERT INTO `titleauthor` (`au_id`, `title_id`, `au_ord`, `royaltyper`) VALUES
('172-32-1176', 'BU1032', 1, 100),
('213-46-8915', 'BU1111', 1, 100),
('238-95-7766', 'MC2222', 1, 100),
('267-41-2394', 'PC1035', 1, 100);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `titles`
--

CREATE TABLE `titles` (
  `title_id` varchar(6) NOT NULL,
  `title` varchar(80) NOT NULL,
  `type` char(12) NOT NULL,
  `pub_id` char(4) DEFAULT NULL,
  `price` decimal(19,4) DEFAULT NULL,
  `advance` decimal(19,4) DEFAULT NULL,
  `royalty` int(11) DEFAULT NULL,
  `ytd_sales` int(11) DEFAULT NULL,
  `notes` varchar(200) DEFAULT NULL,
  `pubdate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `titles`
--

INSERT INTO `titles` (`title_id`, `title`, `type`, `pub_id`, `price`, `advance`, `royalty`, `ytd_sales`, `notes`, `pubdate`) VALUES
('BU1032', 'The Busy Executive\'s Database Guide', 'business', '1389', 19.9900, 5000.0000, 10, 4095, 'An overview of available database systems with emphasis on common business applications. Illustrated.', '1991-06-12 00:00:00'),
('BU1111', 'Cooking with Computers: Surreptitious Balance Sheets', 'business', '1389', 11.9500, 5000.0000, 10, 3876, 'Helpful hints on how to use your electronic resources to the best advantage.', '1991-06-09 00:00:00'),
('MC2222', 'Silicon Valley Gastronomic Treats', 'mod_cook', '0877', 19.9900, 0.0000, 12, 2032, 'Favorite recipes for quick, easy, and elegant meals.', '1991-06-09 00:00:00'),
('PC1035', 'But Is It User Friendly?', 'popular_comp', '1389', 22.9500, 7000.0000, 16, 8780, 'A survey of software for the naive user, focusing on the \'friendliness\' of each.', '1991-06-30 00:00:00'),
('PS2091', 'Is Anger the Enemy?', 'psychology', '0736', 10.9500, 2275.0000, 12, 2045, 'Carefully researched study of the effects of strong emotions on the body. Metabolic charts included.', '1991-06-15 00:00:00');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `authors`
--
ALTER TABLE `authors`
  ADD PRIMARY KEY (`au_id`);

--
-- Indices de la tabla `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`emp_id`);

--
-- Indices de la tabla `jobs`
--
ALTER TABLE `jobs`
  ADD PRIMARY KEY (`job_id`);

--
-- Indices de la tabla `publishers`
--
ALTER TABLE `publishers`
  ADD PRIMARY KEY (`pub_id`);

--
-- Indices de la tabla `pub_info`
--
ALTER TABLE `pub_info`
  ADD PRIMARY KEY (`pub_id`);

--
-- Indices de la tabla `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`stor_id`,`ord_num`,`title_id`);

--
-- Indices de la tabla `stores`
--
ALTER TABLE `stores`
  ADD PRIMARY KEY (`stor_id`);

--
-- Indices de la tabla `titleauthor`
--
ALTER TABLE `titleauthor`
  ADD PRIMARY KEY (`au_id`,`title_id`);

--
-- Indices de la tabla `titles`
--
ALTER TABLE `titles`
  ADD PRIMARY KEY (`title_id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `jobs`
--
ALTER TABLE `jobs`
  MODIFY `job_id` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
