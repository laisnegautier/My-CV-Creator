
-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost:3306
-- Généré le :  ven. 20 déc. 2019 à 18:16
-- Version du serveur :  5.7.24
-- Version de PHP :  7.2.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `bdd_projet_glog`
--

-- --------------------------------------------------------

--
-- Structure de la table `tbl_container`
--

CREATE TABLE `tbl_container` (
  `container_id` int(11) NOT NULL,
  `container_name` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `container_favorite` tinyint(1) NOT NULL,
  `container_favorite_name` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `container_bg_color` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `container_border_color` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `resume_id` int(11) DEFAULT NULL,
  `resume_index` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `tbl_container`
--

INSERT INTO `tbl_container` (`container_id`, `container_name`, `container_favorite`, `container_favorite_name`, `container_bg_color`, `container_border_color`, `resume_id`, `resume_index`) VALUES
(1, 'CONTACT', 0, '', '', '', 1, 0),
(2, 'FORMATIONS', 0, '', '', '', 1, 1),
(3, 'EXPERIENCES PROFESSIONNELLES', 0, '', '', '', 1, 2),
(4, 'COMPETENCES', 0, '', '', '', 1, 3),
(5, 'CENTRES D’INTERET', 0, '', '', '', 1, 4),
(6, 'Information', 0, '', '', '', 2, 0),
(7, 'Mon parcours', 0, '', '', '', 2, 1),
(8, 'Mes Expériences', 0, '', '', '', 2, 2),
(9, 'Mes Compétences', 0, '', '', '', 2, 3),
(10, 'Intérêts', 0, '', '', '', 2, 4);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_date`
--

CREATE TABLE `tbl_date` (
  `date_id` int(11) NOT NULL,
  `date_content` datetime NOT NULL,
  `date_italic` tinyint(1) NOT NULL,
  `date_bold` tinyint(1) NOT NULL,
  `date_size` int(11) NOT NULL,
  `date_foreground_color` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `date_background_color` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `element_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `tbl_date`
--

INSERT INTO `tbl_date` (`date_id`, `date_content`, `date_italic`, `date_bold`, `date_size`, `date_foreground_color`, `date_background_color`, `element_id`) VALUES
(1, '2019-12-20 19:16:17', 0, 1, 11, '', '', 6),
(2, '2019-12-20 19:16:17', 0, 1, 11, '', '', 8),
(3, '2019-12-20 19:16:17', 0, 1, 11, '', '', 10),
(4, '2019-12-20 19:16:17', 0, 1, 11, '', '', 12),
(5, '2019-12-20 19:16:17', 0, 1, 11, '', '', 16),
(6, '2019-12-20 19:16:17', 0, 1, 11, '', '', 22),
(7, '2019-12-20 19:16:25', 0, 1, 11, '', '', 40),
(8, '2019-12-20 19:16:25', 0, 1, 11, '', '', 42);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_element`
--

CREATE TABLE `tbl_element` (
  `element_id` int(11) NOT NULL,
  `container_id` int(11) DEFAULT NULL,
  `container_index` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `tbl_element`
--

INSERT INTO `tbl_element` (`element_id`, `container_id`, `container_index`) VALUES
(1, 1, 0),
(2, 1, 1),
(3, 1, 2),
(4, 1, 3),
(5, 1, 4),
(6, 2, 0),
(7, 2, 1),
(8, 2, 2),
(9, 2, 3),
(10, 2, 4),
(11, 2, 5),
(12, 3, 0),
(13, 3, 1),
(14, 3, 2),
(15, 3, 3),
(16, 3, 4),
(17, 3, 5),
(18, 3, 6),
(19, 3, 7),
(20, 3, 8),
(21, 3, 9),
(22, 3, 10),
(23, 3, 11),
(24, 4, 0),
(25, 4, 1),
(26, 4, 2),
(27, 4, 3),
(28, 4, 4),
(29, 5, 0),
(30, 5, 1),
(31, 5, 2),
(32, 5, 3),
(33, 5, 4),
(34, 5, 5),
(35, 6, 0),
(36, 6, 1),
(37, 6, 2),
(38, 6, 3),
(39, 6, 4),
(40, 7, 0),
(41, 7, 1),
(42, 8, 0),
(43, 8, 1),
(44, 8, 2),
(45, 8, 3),
(46, 9, 0),
(47, 9, 1),
(48, 9, 2),
(49, 9, 3),
(50, 9, 4),
(51, 9, 5),
(52, 9, 6),
(53, 10, 0),
(54, 10, 1);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_h1`
--

CREATE TABLE `tbl_h1` (
  `h1_id` int(11) NOT NULL,
  `h1_content` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `h1_italic` tinyint(1) NOT NULL,
  `h1_bold` tinyint(1) NOT NULL,
  `h1_size` int(11) NOT NULL,
  `h1_foreground_color` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `h1_background_color` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `element_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `tbl_h1`
--

INSERT INTO `tbl_h1` (`h1_id`, `h1_content`, `h1_italic`, `h1_bold`, `h1_size`, `h1_foreground_color`, `h1_background_color`, `element_id`) VALUES
(1, 'Julien NOMDEFAMILLE', 0, 0, 24, '', '', 1),
(2, 'Sylvie LAISNE', 0, 0, 24, '', '', 35);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_h2`
--

CREATE TABLE `tbl_h2` (
  `h2_id` int(11) NOT NULL,
  `h2_content` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `h2_italic` tinyint(1) NOT NULL,
  `h2_bold` tinyint(1) NOT NULL,
  `h2_size` int(11) NOT NULL,
  `h2_foreground_color` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `h2_background_color` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `element_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `tbl_h2`
--

INSERT INTO `tbl_h2` (`h2_id`, `h2_content`, `h2_italic`, `h2_bold`, `h2_size`, `h2_foreground_color`, `h2_background_color`, `element_id`) VALUES
(1, '34 ans, né le 12/12/12', 0, 1, 18, '', '', 2),
(2, 'Stage de recherche en génie logiciel - ENSC, Talence', 0, 1, 18, '', '', 13),
(3, 'Stage de recherche en bases de données - ENSC, Talence', 0, 1, 18, '', '', 17),
(4, 'Autres expériences', 0, 1, 18, '', '', 21),
(5, 'Langues', 0, 1, 18, '', '', 24),
(6, 'Informatique', 0, 1, 18, '', '', 27),
(7, 'Musique', 0, 1, 18, '', '', 29),
(8, 'Sport', 0, 1, 18, '', '', 32),
(9, '12 ans, né le 23/12/20..', 0, 1, 18, '', '', 36),
(10, 'Job d\'été', 0, 1, 18, '', '', 43),
(11, 'Langues écrites et parlées', 0, 1, 18, '', '', 46),
(12, 'Informatique', 0, 1, 18, '', '', 50),
(13, 'Musique', 0, 1, 18, '', '', 53);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_line`
--

CREATE TABLE `tbl_line` (
  `date_id` int(11) NOT NULL,
  `line_color` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `element_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `tbl_line`
--

INSERT INTO `tbl_line` (`date_id`, `line_color`, `element_id`) VALUES
(1, '#00000', 20);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_paragraph`
--

CREATE TABLE `tbl_paragraph` (
  `paragraph_id` int(11) NOT NULL,
  `paragraph_content` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `paragraph_italic` tinyint(1) NOT NULL,
  `paragraph_bold` tinyint(1) NOT NULL,
  `paragraph_size` int(11) NOT NULL,
  `paragraph_foreground_color` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `paragraph_background_color` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `element_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `tbl_paragraph`
--

INSERT INTO `tbl_paragraph` (`paragraph_id`, `paragraph_content`, `paragraph_italic`, `paragraph_bold`, `paragraph_size`, `paragraph_foreground_color`, `paragraph_background_color`, `element_id`) VALUES
(1, '1 Rue de la Galaxy 33 000 BORDEAUX', 0, 0, 13, '#00000', '#ffffff', 3),
(2, '07 85 85 85 85', 0, 0, 13, '#00000', '#ffffff', 4),
(3, 'julien.vie@fatal.com', 0, 0, 13, '#00000', '#ffffff', 5),
(4, 'ENSC - Institut National Polytechnique de Bordeaux (33000), spécialité « Génie Logiciel »', 0, 0, 13, '#00000', '#ffffff', 7),
(5, 'Université de Pau - Pau (00000), Licence de Bio', 0, 0, 13, '#00000', '#ffffff', 9),
(6, 'Baccalauréat Scientifique mention passable', 0, 0, 13, '#00000', '#ffffff', 11),
(7, 'Stagiaire de qualité', 1, 0, 13, '#00000', '#ffffff', 14),
(8, 'Description du stage de 2A etc...', 0, 0, 13, '#00000', '#ffffff', 15),
(9, 'Petit stagiaire', 1, 0, 13, '#00000', '#ffffff', 18),
(10, 'Description du stage de 1A etc...', 0, 0, 13, '#00000', '#ffffff', 19),
(11, 'Chanteur d\'opéra', 0, 0, 13, '#00000', '#ffffff', 23),
(12, 'Anglais - Courant (TOEIC : 400/900 en 2019)', 0, 0, 13, '#00000', '#ffffff', 25),
(13, 'Occitan - Débutant', 0, 0, 13, '#00000', '#ffffff', 26),
(14, 'Cubase, Dorico, Visual Studio 1995', 0, 0, 13, '#00000', '#ffffff', 28),
(15, 'Piano depuis 10 ans', 0, 0, 13, '#00000', '#ffffff', 30),
(16, 'Guitare depuis la naissance', 0, 0, 13, '#00000', '#ffffff', 31),
(17, 'Marche depuis la naissance', 0, 0, 13, '#00000', '#ffffff', 33),
(18, 'S\'étire depuis quelques temps', 0, 0, 13, '#00000', '#ffffff', 34),
(19, '4 Rue de la GLog 76000 ROUEN', 0, 0, 13, '#00000', '#ffffff', 37),
(20, '07 12 12 12 12', 0, 0, 13, '#00000', '#ffffff', 38),
(21, 'sylvie.vie@fatal.com', 0, 0, 13, '#00000', '#ffffff', 39),
(22, 'Baccalauréat L parcours Musique et Danse', 0, 0, 13, '#00000', '#ffffff', 41),
(23, 'Vendanges', 1, 0, 13, '#00000', '#ffffff', 44),
(24, 'A joué avec des renards toute la journée.', 0, 0, 13, '#00000', '#ffffff', 45),
(25, 'Anglais - Courant (TOEIC : 900/900 en 2012)', 0, 0, 13, '#00000', '#ffffff', 47),
(26, 'Allemand - Confirmé', 0, 0, 13, '#00000', '#ffffff', 48),
(27, 'Chinois - Débutant', 0, 0, 13, '#00000', '#ffffff', 49),
(28, 'Word', 0, 0, 13, '#00000', '#ffffff', 51),
(29, 'Protégé', 0, 0, 13, '#00000', '#ffffff', 52),
(30, 'Joue du cithar des fois', 0, 0, 13, '#00000', '#ffffff', 54);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_resume`
--

CREATE TABLE `tbl_resume` (
  `resume_id` int(11) NOT NULL,
  `resume_title` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `resume_save` tinyint(1) NOT NULL,
  `resume_favorite` tinyint(1) NOT NULL,
  `resume_creation` datetime NOT NULL,
  `resume_last_update` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `tbl_resume`
--

INSERT INTO `tbl_resume` (`resume_id`, `resume_title`, `resume_save`, `resume_favorite`, `resume_creation`, `resume_last_update`) VALUES
(1, 'CV de Julien', 1, 0, '2019-12-20 19:16:15', '2019-12-20 19:16:17'),
(2, 'CV de Sylvie', 1, 0, '2019-12-20 19:16:22', '2019-12-20 19:16:25');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `tbl_container`
--
ALTER TABLE `tbl_container`
  ADD PRIMARY KEY (`container_id`),
  ADD KEY `resume_id` (`resume_id`);

--
-- Index pour la table `tbl_date`
--
ALTER TABLE `tbl_date`
  ADD PRIMARY KEY (`date_id`),
  ADD KEY `element_id` (`element_id`);

--
-- Index pour la table `tbl_element`
--
ALTER TABLE `tbl_element`
  ADD PRIMARY KEY (`element_id`),
  ADD KEY `container_id` (`container_id`);

--
-- Index pour la table `tbl_h1`
--
ALTER TABLE `tbl_h1`
  ADD PRIMARY KEY (`h1_id`),
  ADD KEY `element_id` (`element_id`);

--
-- Index pour la table `tbl_h2`
--
ALTER TABLE `tbl_h2`
  ADD PRIMARY KEY (`h2_id`),
  ADD KEY `element_id` (`element_id`);

--
-- Index pour la table `tbl_line`
--
ALTER TABLE `tbl_line`
  ADD PRIMARY KEY (`date_id`),
  ADD KEY `element_id` (`element_id`);

--
-- Index pour la table `tbl_paragraph`
--
ALTER TABLE `tbl_paragraph`
  ADD PRIMARY KEY (`paragraph_id`),
  ADD KEY `element_id` (`element_id`);

--
-- Index pour la table `tbl_resume`
--
ALTER TABLE `tbl_resume`
  ADD PRIMARY KEY (`resume_id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `tbl_container`
--
ALTER TABLE `tbl_container`
  MODIFY `container_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table `tbl_date`
--
ALTER TABLE `tbl_date`
  MODIFY `date_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT pour la table `tbl_element`
--
ALTER TABLE `tbl_element`
  MODIFY `element_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;

--
-- AUTO_INCREMENT pour la table `tbl_h1`
--
ALTER TABLE `tbl_h1`
  MODIFY `h1_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `tbl_h2`
--
ALTER TABLE `tbl_h2`
  MODIFY `h2_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT pour la table `tbl_line`
--
ALTER TABLE `tbl_line`
  MODIFY `date_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pour la table `tbl_paragraph`
--
ALTER TABLE `tbl_paragraph`
  MODIFY `paragraph_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT pour la table `tbl_resume`
--
ALTER TABLE `tbl_resume`
  MODIFY `resume_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `tbl_container`
--
ALTER TABLE `tbl_container`
  ADD CONSTRAINT `tbl_container_ibfk_1` FOREIGN KEY (`resume_id`) REFERENCES `tbl_resume` (`resume_id`);

--
-- Contraintes pour la table `tbl_date`
--
ALTER TABLE `tbl_date`
  ADD CONSTRAINT `tbl_date_ibfk_1` FOREIGN KEY (`element_id`) REFERENCES `tbl_element` (`element_id`);

--
-- Contraintes pour la table `tbl_element`
--
ALTER TABLE `tbl_element`
  ADD CONSTRAINT `tbl_element_ibfk_1` FOREIGN KEY (`container_id`) REFERENCES `tbl_container` (`container_id`);

--
-- Contraintes pour la table `tbl_h1`
--
ALTER TABLE `tbl_h1`
  ADD CONSTRAINT `tbl_h1_ibfk_1` FOREIGN KEY (`element_id`) REFERENCES `tbl_element` (`element_id`);

--
-- Contraintes pour la table `tbl_h2`
--
ALTER TABLE `tbl_h2`
  ADD CONSTRAINT `tbl_h2_ibfk_1` FOREIGN KEY (`element_id`) REFERENCES `tbl_element` (`element_id`);

--
-- Contraintes pour la table `tbl_line`
--
ALTER TABLE `tbl_line`
  ADD CONSTRAINT `tbl_line_ibfk_1` FOREIGN KEY (`element_id`) REFERENCES `tbl_element` (`element_id`);

--
-- Contraintes pour la table `tbl_paragraph`
--
ALTER TABLE `tbl_paragraph`
  ADD CONSTRAINT `tbl_paragraph_ibfk_1` FOREIGN KEY (`element_id`) REFERENCES `tbl_element` (`element_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
