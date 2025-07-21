-- =======================================================================
-- SCRIPT DE CRÉATION DE LA BASE DE DONNÉES ET D'INSERTION DES DONNÉES
-- PROJET : GESTION DES NOTES ISGA
-- =======================================================================

-- Suppression des tables existantes pour éviter les conflits (si ré-exécution)
DROP TABLE IF EXISTS Notes;
DROP TABLE IF EXISTS Matieres;
DROP TABLE IF EXISTS Etudiants;
DROP TABLE IF EXISTS Utilisateurs;
DROP TABLE IF EXISTS Filieres;
DROP TABLE IF EXISTS Roles;
GO

-- =======================================================================
-- PARTIE 1 : CRÉATION DES TABLES
-- L'ordre est important pour respecter les contraintes de clés étrangères
-- =======================================================================

-- Table pour les rôles des utilisateurs
CREATE TABLE Roles (
    ID_Role INT PRIMARY KEY IDENTITY(1,1),
    NomRole NVARCHAR(50) NOT NULL UNIQUE
);
GO

-- Table pour les filières de l'institut
CREATE TABLE Filieres (
    ID_Filiere INT PRIMARY KEY IDENTITY(1,1),
    NomFiliere NVARCHAR(100) NOT NULL,
    Cycle NVARCHAR(50) NOT NULL -- Ex: 'BTS', 'Master', 'Cycle Ingénieur'
);
GO

-- Table pour les utilisateurs de l'application (enseignants, secrétaires, admin)
CREATE TABLE Utilisateurs (
    ID_Utilisateur INT PRIMARY KEY IDENTITY(1,1),
    Nom NVARCHAR(50) NOT NULL,
    Prenom NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    -- IMPORTANT: Le mot de passe doit être stocké sous forme de hash sécurisé (ex: SHA256)
    MotDePasseHash NVARCHAR(256) NOT NULL,
    ID_Role INT NOT NULL,
    CONSTRAINT FK_Utilisateurs_Roles FOREIGN KEY (ID_Role) REFERENCES Roles(ID_Role)
);
GO

-- Table pour les étudiants inscrits
CREATE TABLE Etudiants (
    ID_Etudiant INT PRIMARY KEY IDENTITY(1,1),
    Matricule NVARCHAR(20) NOT NULL UNIQUE,
    Nom NVARCHAR(50) NOT NULL,
    Prenom NVARCHAR(50) NOT NULL,
    DateNaissance DATE NOT NULL,
    ID_Filiere INT NOT NULL,
    CONSTRAINT FK_Etudiants_Filieres FOREIGN KEY (ID_Filiere) REFERENCES Filieres(ID_Filiere)
);
GO

-- Table pour les matières enseignées dans chaque filière
CREATE TABLE Matieres (
    ID_Matiere INT PRIMARY KEY IDENTITY(1,1),
    NomMatiere NVARCHAR(100) NOT NULL,
    Coefficient DECIMAL(3, 1) NOT NULL DEFAULT 1.0,
    ID_Filiere INT NOT NULL,
    CONSTRAINT FK_Matieres_Filieres FOREIGN KEY (ID_Filiere) REFERENCES Filieres(ID_Filiere)
);
GO

-- Table principale pour enregistrer les notes
CREATE TABLE Notes (
    ID_Note INT PRIMARY KEY IDENTITY(1,1),
    ValeurNote DECIMAL(4, 2) NOT NULL,
    DateSaisie DATETIME NOT NULL DEFAULT GETDATE(),
    ID_Etudiant INT NOT NULL,
    ID_Matiere INT NOT NULL,
    ID_Utilisateur INT NOT NULL, -- L'enseignant qui a saisi la note
    CONSTRAINT FK_Notes_Etudiants FOREIGN KEY (ID_Etudiant) REFERENCES Etudiants(ID_Etudiant),
    CONSTRAINT FK_Notes_Matieres FOREIGN KEY (ID_Matiere) REFERENCES Matieres(ID_Matiere),
    CONSTRAINT FK_Notes_Utilisateurs FOREIGN KEY (ID_Utilisateur) REFERENCES Utilisateurs(ID_Utilisateur),
    -- Empêcher la saisie de deux notes pour le même étudiant dans la même matière
    CONSTRAINT UQ_Etudiant_Matiere UNIQUE (ID_Etudiant, ID_Matiere)
);
GO


-- =======================================================================
-- PARTIE 2 : INSERTION D'UN JEU DE DONNÉES DE TEST
-- =======================================================================
PRINT 'Insertion des données de test...'

-- 1. Rôles
INSERT INTO Roles (NomRole) VALUES
('Administrateur'),
('Enseignant'),
('Secrétaire');
GO

-- 2. Filières
INSERT INTO Filieres (NomFiliere, Cycle) VALUES
('Développement Informatique', 'BTS'),
('Génie Logiciel', 'Cycle Ingénieur'),
('Big Data & Intelligence Artificielle', 'Master');
GO

-- 3. Utilisateurs
-- Le mot de passe 'hash' est une simulation. En production, utilisez un algorithme de hachage.
INSERT INTO Utilisateurs (Nom, Prenom, Email, MotDePasseHash, ID_Role) VALUES
('El Alaoui', 'Fatima', 'fatima.admin@isga.ma', 'hash_admin_password', 1),       -- Admin (ID 1)
('Cherkaoui', 'Youssef', 'y.cherkaoui@isga.ma', 'hash_teacher_password1', 2),   -- Enseignant (ID 2)
('Bennani', 'Salim', 's.bennani@isga.ma', 'hash_teacher_password2', 2),      -- Enseignant (ID 3)
('Tazi', 'Nadia', 'nadia.secretaire@isga.ma', 'hash_secretary_password', 3);  -- Secrétaire (ID 4)
GO

-- 4. Étudiants
INSERT INTO Etudiants (Matricule, Nom, Prenom, DateNaissance, ID_Filiere) VALUES
('A101', 'Amrani', 'Ali', '2004-05-15', 1),       -- BTS Dev Info (ID 1)
('A102', 'Farissi', 'Khadija', '2004-08-22', 1),  -- BTS Dev Info (ID 2)
('B201', 'Kadiri', 'Omar', '2002-01-30', 2),      -- Ingénieur GL (ID 3)
('B202', 'Saadi', 'Leila', '2002-03-12', 2),      -- Ingénieur GL (ID 4)
('C301', 'Ziani', 'Mehdi', '2001-11-05', 3);      -- Master BDIA (ID 5)
GO

-- 5. Matières
-- BTS (Filiere ID 1)
INSERT INTO Matieres (NomMatiere, Coefficient, ID_Filiere) VALUES
('Algorithmique', 2.0, 1),
('Bases de Données', 2.5, 1),
('Programmation C#', 3.0, 1);
-- Ingénieur (Filiere ID 2)
INSERT INTO Matieres (NomMatiere, Coefficient, ID_Filiere) VALUES
('Architecture Logicielle', 3.0, 2),
('Génie Logiciel Avancé', 2.5, 2),
('Systèmes Embarqués', 1.5, 2);
-- Master (Filiere ID 3)
INSERT INTO Matieres (NomMatiere, Coefficient, ID_Filiere) VALUES
('Machine Learning', 3.0, 3),
('Cloud Computing', 2.0, 3);
GO

-- 6. Notes
-- Notes saisies par l'enseignant Youssef Cherkaoui (Utilisateur ID 2)
-- Étudiant Ali Amrani (Étudiant ID 1)
INSERT INTO Notes (ValeurNote, ID_Etudiant, ID_Matiere, ID_Utilisateur) VALUES
(14.50, 1, 1, 2), -- Note en Algorithmique
(16.00, 1, 2, 2), -- Note en Bases de Données
(12.75, 1, 3, 2); -- Note en Programmation C#
-- Étudiante Khadija Farissi (Étudiant ID 2)
INSERT INTO Notes (ValeurNote, ID_Etudiant, ID_Matiere, ID_Utilisateur) VALUES
(17.00, 2, 1, 2), -- Note en Algorithmique
(13.50, 2, 2, 2); -- Note en Bases de Données
-- Notes saisies par l'enseignant Salim Bennani (Utilisateur ID 3)
-- Étudiant Omar Kadiri (Étudiant ID 3)
INSERT INTO Notes (ValeurNote, ID_Etudiant, ID_Matiere, ID_Utilisateur) VALUES
(11.00, 3, 4, 3), -- Note en Architecture Logicielle
(15.25, 3, 5, 3); -- Note en Génie Logiciel Avancé
GO

PRINT 'Script terminé avec succès. La base de données est prête.';
GO

-- Exemple de requête pour vérifier les données : Moyenne d'un étudiant
SELECT
    e.Prenom,
    e.Nom,
    m.NomMatiere,
    n.ValeurNote,
    m.Coefficient
FROM Notes n
JOIN Etudiants e ON n.ID_Etudiant = e.ID_Etudiant
JOIN Matieres m ON n.ID_Matiere = m.ID_Matiere
WHERE e.ID_Etudiant = 1; -- Changer l'ID pour voir un autre étudiant