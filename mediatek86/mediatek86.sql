-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mer. 28 mai 2025 à 18:44
-- Version du serveur : 10.4.32-MariaDB
-- Version de PHP : 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : mediatek86
--
CREATE DATABASE IF NOT EXISTS mediatek86 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
CREATE USER 'mediatek86'@'%' IDENTIFIED BY 'motdepasse1234';
GRANT USAGE ON *.* TO 'mediatek86'@'%';
GRANT ALL PRIVILEGES ON `mediatek86`.* TO 'mediatek86'@'%';
USE mediatek86;

-- --------------------------------------------------------

--
-- Structure de la table absence
--

CREATE TABLE absence (
  idpersonnel int(11) NOT NULL,
  datedebut datetime NOT NULL,
  datefin datetime DEFAULT NULL,
  idmotif int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table absence
--

INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES
(1, '2023-01-10 08:00:00', '2023-01-12 18:00:00', 1),
(1, '2023-02-12 08:00:00', '2023-02-15 18:00:00', 1),
(1, '2023-06-20 08:00:00', '2023-06-24 18:00:00', 2),
(1, '2023-07-17 08:00:00', '2023-07-20 18:00:00', 2),
(1, '2023-11-10 08:00:00', '2023-11-12 18:00:00', 4),
(1, '2023-12-19 08:00:00', '2023-12-20 18:00:00', 4),
(1, '2024-04-07 08:00:00', '2024-04-08 18:00:00', 3),
(1, '2024-05-18 08:00:00', '2024-05-21 18:00:00', 2),
(1, '2024-09-09 08:00:00', '2024-09-10 18:00:00', 1),
(1, '2025-02-05 08:00:00', '2025-02-07 18:00:00', 2),
(2, '2023-02-03 08:00:00', '2023-02-07 18:00:00', 2),
(2, '2023-03-06 08:00:00', '2023-03-07 18:00:00', 2),
(2, '2023-07-05 08:00:00', '2023-07-08 18:00:00', 3),
(2, '2023-08-28 08:00:00', '2023-08-29 18:00:00', 3),
(2, '2023-12-14 08:00:00', '2023-12-18 18:00:00', 1),
(2, '2024-01-25 08:00:00', '2024-01-28 18:00:00', 1),
(2, '2024-05-01 08:00:00', '2024-05-04 18:00:00', 4),
(2, '2024-06-06 08:00:00', '2024-06-08 18:00:00', 3),
(2, '2024-10-13 08:00:00', '2024-10-16 18:00:00', 2),
(2, '2025-03-10 08:00:00', '2025-03-13 18:00:00', 3),
(3, '2023-03-15 08:00:00', '2023-03-15 18:00:00', 3),
(3, '2023-04-25 08:00:00', '2023-04-27 18:00:00', 3),
(3, '2023-08-11 08:00:00', '2023-08-15 18:00:00', 1),
(3, '2023-09-04 08:00:00', '2023-09-06 18:00:00', 1),
(3, '2024-01-03 08:00:00', '2024-01-05 18:00:00', 2),
(3, '2024-02-14 08:00:00', '2024-02-16 18:00:00', 2),
(3, '2024-06-11 08:00:00', '2024-06-14 18:00:00', 1),
(3, '2024-07-29 08:00:00', '2024-07-30 18:00:00', 1),
(3, '2024-11-22 08:00:00', '2024-11-24 18:00:00', 3),
(3, '2025-04-01 08:00:00', '2025-04-02 18:00:00', 1),
(4, '2023-04-01 08:00:00', '2023-04-04 18:00:00', 1),
(4, '2023-05-30 08:00:00', '2023-06-01 18:00:00', 1),
(4, '2023-09-22 08:00:00', '2023-09-23 18:00:00', 2),
(4, '2023-10-18 08:00:00', '2023-10-21 18:00:00', 2),
(4, '2024-02-09 08:00:00', '2024-02-09 18:00:00', 3),
(4, '2024-07-21 08:00:00', '2024-07-22 18:00:00', 2),
(4, '2024-08-24 08:00:00', '2024-08-25 18:00:00', 4),
(4, '2024-12-01 08:00:00', '2024-12-04 18:00:00', 3),
(4, '2025-02-07 15:07:00', '2025-02-14 15:07:00', 1),
(4, '2025-05-24 15:00:30', '2025-05-25 15:00:30', 4),
(4, '2025-05-28 14:36:06', '2025-05-28 14:36:06', 3),
(4, '2025-05-28 14:36:11', '2025-05-28 14:36:11', 1),
(4, '2025-07-18 14:17:36', '2025-07-19 14:17:36', 2),
(4, '2026-06-09 08:00:00', '2026-07-11 18:00:00', 2),
(5, '2023-01-21 08:00:00', '2023-01-22 18:00:00', 3),
(5, '2023-05-12 08:00:00', '2023-05-13 18:00:00', 4),
(5, '2023-06-12 08:00:00', '2023-06-13 18:00:00', 4),
(5, '2023-10-01 08:00:00', '2023-10-03 18:00:00', 3),
(5, '2023-11-08 08:00:00', '2023-11-10 18:00:00', 3),
(5, '2024-03-16 08:00:00', '2024-03-20 18:00:00', 1),
(5, '2024-04-10 08:00:00', '2024-04-12 18:00:00', 1),
(5, '2024-08-01 08:00:00', '2024-08-05 18:00:00', 3),
(5, '2024-09-26 08:00:00', '2024-09-28 18:00:00', 3),
(5, '2025-01-15 08:00:00', '2025-01-17 18:00:00', 4),
(6, '2025-05-28 13:11:05', '2025-05-30 13:11:05', 2);

-- --------------------------------------------------------

--
-- Structure de la table motif
--

CREATE TABLE motif (
  idmotif int(11) NOT NULL,
  libelle varchar(128) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table motif
--

INSERT INTO motif (idmotif, libelle) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table personnel
--

CREATE TABLE personnel (
  idpersonnel int(11) NOT NULL,
  nom varchar(50) DEFAULT NULL,
  prenom varchar(50) DEFAULT NULL,
  tel varchar(15) DEFAULT NULL,
  mail varchar(128) DEFAULT NULL,
  idservice int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table personnel
--

INSERT INTO personnel (idpersonnel, nom, prenom, tel, mail, idservice) VALUES
(1, 'Bellamy', 'Anna', '04 68 81 82 69', 'anna.bellamy@hotmail.edu', 2),
(2, 'Plourde', 'Leila', '07 27 17 84 27', 'nibh.lacinia@google.couk', 2),
(3, 'Van Der Aart', 'Amandine', '03 11 49 15 15', 'vitae.posuere@icloud.couk', 2),
(4, 'Janssens', 'Caroline', '09 93 16 37 12', 'nam.ac@protonmail.net', 3),
(5, 'Spijker', 'Luca', '06 25 97 46 55', 'aenean.euismod.mauris@hotmail.couk', 3),
(6, 'Achterberg', 'Thibaut', '08 85 28 34 27', 'eget.metus@hotmail.net', 2),
(8, 'Duval', 'Mélissa', '06 23 89 75 73', 'id.nunc.interdum@outlook.org', 2),
(9, 'Plamondon', 'Rémi', '07 66 41 21 82', 'dui@google.com', 3),
(10, 'Kloet', 'Nathan', '03 38 77 42 15', 'taciti.sociosqu@outlook.net', 2),
(11, 'Kadet', 'Hachelet', '05 74 65 98 41', 'kadet.hachelet@outlook.com', 1),
(12, 'Justa', 'Larry', '07 52 41 65 98', 'justa.larry@hotmail.com', 2);

-- --------------------------------------------------------

--
-- Structure de la table responsable
--

CREATE TABLE responsable (
  login varchar(64) DEFAULT NULL,
  pwd varchar(64) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table responsable
--

INSERT INTO responsable (login, pwd) VALUES
('camille', 'e9d6e40a0405c78bd92b9aee1d92276ab4a8736d0367713fa0d0e7834dd90fc1');

-- --------------------------------------------------------

--
-- Structure de la table service
--

CREATE TABLE service (
  idservice int(11) NOT NULL,
  nom varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table service
--

INSERT INTO service (idservice, nom) VALUES
(1, 'Administratif'),
(2, 'Médiation culturelle'),
(3, 'Prêt');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table absence
--
ALTER TABLE absence
  ADD PRIMARY KEY (idpersonnel,datedebut),
  ADD KEY idmotif (idmotif);

--
-- Index pour la table motif
--
ALTER TABLE motif
  ADD PRIMARY KEY (idmotif);

--
-- Index pour la table personnel
--
ALTER TABLE personnel
  ADD PRIMARY KEY (idpersonnel),
  ADD KEY idservice (idservice);

--
-- Index pour la table service
--
ALTER TABLE service
  ADD PRIMARY KEY (idservice);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table motif
--
ALTER TABLE motif
  MODIFY idmotif int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table personnel
--
ALTER TABLE personnel
  MODIFY idpersonnel int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT pour la table service
--
ALTER TABLE service
  MODIFY idservice int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table absence
--
ALTER TABLE absence
  ADD CONSTRAINT absence_ibfk_1 FOREIGN KEY (idpersonnel) REFERENCES personnel (idpersonnel),
  ADD CONSTRAINT absence_ibfk_2 FOREIGN KEY (idmotif) REFERENCES motif (idmotif);

--
-- Contraintes pour la table personnel
--
ALTER TABLE personnel
  ADD CONSTRAINT personnel_ibfk_1 FOREIGN KEY (idservice) REFERENCES service (idservice);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
