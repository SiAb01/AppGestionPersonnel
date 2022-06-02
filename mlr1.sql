-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 02 juin 2022 à 15:19
-- Version du serveur : 5.7.36
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mlr1`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idAbsence` int(11) NOT NULL AUTO_INCREMENT,
  `IDPERSONNEL` int(2) NOT NULL,
  `DATEDEBUT` datetime NOT NULL,
  `IDMOTIF` int(2) NOT NULL,
  `DATEFIN` datetime DEFAULT NULL,
  PRIMARY KEY (`idAbsence`),
  KEY `FK_ABSENCE_MOTIF` (`IDMOTIF`),
  KEY `IDPERSONNEL` (`IDPERSONNEL`,`DATEDEBUT`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idAbsence`, `IDPERSONNEL`, `DATEDEBUT`, `IDMOTIF`, `DATEFIN`) VALUES
(1, 2, '2021-03-13 10:10:46', 3, '2022-05-17 13:50:13'),
(2, 7, '2021-03-10 06:02:29', 2, '2022-01-05 14:58:27'),
(4, 1, '2021-03-30 17:36:17', 4, '2022-02-21 07:34:07'),
(5, 2, '2021-03-31 01:12:41', 3, '2022-11-01 07:48:57'),
(6, 7, '2021-03-20 05:20:53', 2, '2023-04-08 11:06:25'),
(7, 5, '2021-03-31 05:12:52', 2, '2021-08-15 11:32:09'),
(8, 4, '2021-03-19 22:23:48', 3, '2021-06-15 10:01:58'),
(9, 13, '2021-03-21 00:27:17', 3, '2022-09-22 02:05:12'),
(10, 2, '2021-03-11 09:57:20', 1, '2022-04-27 12:58:41'),
(11, 10, '2021-03-15 02:37:28', 2, '2022-09-01 18:13:17'),
(12, 5, '2021-03-17 02:47:18', 1, '2022-05-30 16:05:41'),
(13, 7, '2021-03-27 18:29:13', 1, '2021-10-04 18:06:53'),
(14, 4, '2021-03-09 04:32:18', 3, '2022-08-04 10:10:22'),
(15, 12, '2021-03-19 11:11:51', 3, '2022-06-17 20:43:09'),
(16, 11, '2021-02-22 23:21:25', 2, '2021-05-10 20:49:42'),
(17, 11, '2021-02-03 22:02:46', 3, '2021-05-05 17:40:49'),
(18, 10, '2021-01-19 00:33:02', 4, '2021-05-07 03:41:38'),
(19, 7, '2021-01-02 12:33:13', 2, '2021-05-11 08:33:24'),
(20, 2, '2020-12-31 06:16:32', 3, '2021-05-17 11:25:58'),
(21, 4, '2021-02-16 17:53:48', 1, '2021-05-08 04:39:05'),
(22, 9, '2021-03-13 20:29:58', 4, '2021-05-16 22:54:18'),
(23, 5, '2021-02-04 03:47:28', 3, '2021-05-18 18:44:46'),
(24, 5, '2021-02-09 06:22:09', 1, '2021-05-09 01:37:29'),
(25, 5, '2021-02-03 22:55:52', 2, '2021-05-13 03:10:44'),
(26, 4, '2021-02-17 04:11:41', 3, '2021-05-10 14:29:23'),
(27, 8, '2021-01-24 19:58:09', 2, '2021-05-02 21:16:18'),
(28, 11, '2021-03-10 17:58:26', 4, '2021-05-12 16:31:17'),
(29, 9, '2021-01-13 12:39:32', 3, '2021-05-05 14:38:29'),
(30, 5, '2020-12-27 06:25:16', 2, '2021-05-17 14:59:20'),
(31, 1, '2021-02-22 23:21:25', 2, '2021-05-10 20:49:42'),
(32, 2, '2021-02-03 22:02:46', 3, '2021-05-05 17:40:49'),
(33, 10, '2022-08-12 13:45:12', 2, '2022-08-20 13:45:12'),
(34, 5, '2022-08-12 13:45:12', 2, '2022-08-20 13:45:12'),
(35, 4, '2022-06-09 17:50:02', 1, '2022-06-10 17:50:02'),
(36, 3, '2022-06-03 17:54:46', 3, '2022-06-16 17:54:46'),
(37, 3, '2022-05-11 17:58:42', 1, '2022-05-24 17:58:42'),
(38, 6, '2022-05-05 21:08:21', 2, '2022-05-11 21:08:21'),
(39, 18, '2022-06-13 15:22:38', 1, '2022-06-17 15:22:38');

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `IDMOTIF` int(2) NOT NULL AUTO_INCREMENT,
  `LIBELLE` varchar(128) COLLATE latin1_general_ci DEFAULT NULL,
  PRIMARY KEY (`IDMOTIF`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`IDMOTIF`, `LIBELLE`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familiale'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `IDPERSONNEL` int(2) NOT NULL AUTO_INCREMENT,
  `IDSERVICE` int(2) NOT NULL,
  `NOM` varchar(50) COLLATE latin1_general_ci DEFAULT NULL,
  `PRENOM` varchar(50) COLLATE latin1_general_ci DEFAULT NULL,
  `TEL` varchar(15) COLLATE latin1_general_ci DEFAULT NULL,
  `MAIL` varchar(128) COLLATE latin1_general_ci DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`),
  KEY `FK_PERSONNEL_SERVICE` (`IDSERVICE`)
) ENGINE=MyISAM AUTO_INCREMENT=21 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`IDPERSONNEL`, `IDSERVICE`, `NOM`, `PRENOM`, `TEL`, `MAIL`) VALUES
(1, 2, 'Jody', 'Cescotti', '2014389263', 'jcescotti0@domainmarket.com'),
(2, 3, 'Martin', 'Sylvie', '06XX', 'sylvie.m@aol.com'),
(3, 2, 'Red', 'Conechie', '6224922321', 'rconechie2@cnet.com'),
(4, 1, 'Adriano', 'Leere', '1023102197', 'aleere3@washington.edu'),
(5, 3, 'Letty', 'Barnson', '5782972804', 'lbarnson4@tumblr.com'),
(6, 3, 'TEDDI', 'Rudy', '2316439036', 'tcousin5@nba.com'),
(7, 1, 'Nessie', 'Ashpital', '7667230599', 'nashpital6@cmu.edu'),
(8, 2, 'Russell', 'Lavelle', '8005520960', 'rlavelle7@friendfeed.com'),
(9, 3, 'CLAYBOURNE', 'Pete', '3181382086', 'cpidcock8@opensource.org'),
(10, 3, 'Kathleen', 'Gaddes', '2241423131', 'kgaddes9@jimdo.com'),
(11, 2, 'Ware', 'Cruikshank', '6607186129', 'wcruikshanka@walmart.com'),
(12, 3, 'Eunice', 'Carlisle', '4886680363', 'ecarlisleb@4shared.com'),
(15, 2, 'Grey', 'Judith', '07XXXXX', 'grey.judith@gmail.com'),
(18, 2, 'Julie', 'ffrffff', 'fff', 'ddddd'),
(17, 0, 'Portant', 'Olivier', '07XXXX', 'o.portant@mail.com'),
(19, 2, 'Martin', 'Lucien', '06XXXXXX', 'gmail.com'),
(20, 2, 'Martin', 'Olivier', 'O7XX', 'm.olivier@mail.fr');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE latin1_general_ci NOT NULL,
  `pwd` varchar(64) COLLATE latin1_general_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('admin23', '967520ae23e8ee14888bae72809031b98398ae4a636773e18fff917d77679334');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `IDSERVICE` int(2) NOT NULL AUTO_INCREMENT,
  `NOMSERVICE` varchar(50) COLLATE latin1_general_ci DEFAULT NULL,
  PRIMARY KEY (`IDSERVICE`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`IDSERVICE`, `NOMSERVICE`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'pret');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
