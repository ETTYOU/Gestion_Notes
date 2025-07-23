# Gestion_Notes

## Description
Ce projet est une application C# Windows Forms conçue pour la gestion des notes des étudiants au sein d'un établissement académique. Il offre des fonctionnalités pour gérer les étudiants, les matières et les notes, ainsi que pour générer des statistiques.

---

## Fonctionnalités 🚀
- **Gestion des Étudiants :** Ajouter, modifier, supprimer et consulter les informations des étudiants.
- **Gestion des Matières :** Gérer les matières académiques et leurs coefficients.
- **Saisie des Notes :** Saisir et mettre à jour les notes des étudiants pour les différentes matières.
- **Rapports Statistiques :** Consulter les données statistiques relatives aux performances des étudiants (ex: moyennes des notes).
- **Authentification des Utilisateurs :** (Implicite par les tables `Utilisateur` et `Role`) Accès sécurisé à l'application.

---

## Technologies Utilisées 🛠️
- **Frontend :** C# Windows Forms (.NET)
- **Backend/Logique :** Bibliothèques de classes C# (.NET)
- **Base de Données :** SQL Server (via `System.Data.SqlClient`)
- **Langage :** C#

---

## Démarrage

### Prérequis
Avant de commencer, assurez-vous d'avoir installé les éléments suivants :
- **Visual Studio 2022** (ou une version compatible) avec la charge de travail "Développement desktop .NET".
- **SDK .NET 8.0** (ou la version du framework cible utilisée dans le projet).
- **SQL Server** (par exemple, SQL Server Express, SQL Server Developer Edition) installé et en cours d'exécution.
- **SQL Server Management Studio (SSMS)** ou un outil similaire pour exécuter des scripts SQL.

### Installation

1.  **Clonez le dépôt :**
    ```bash
    git clone [https://github.com/VOTRE_NOM_UTILISATEUR/Gestion_Notes.git](https://github.com/VOTRE_NOM_UTILISATEUR/Gestion_Notes.git)
    cd Gestion_Notes
    ```
    *(Remplacez `VOTRE_NOM_UTILISATEUR` par votre nom d'utilisateur GitHub et `Gestion_Notes` par le nom de votre dépôt s'il est différent)*

2.  **Configuration de la Base de Données :**
    a.  Ouvrez **SQL Server Management Studio (SSMS)** et connectez-vous à votre instance SQL Server.
    b.  Créez une nouvelle base de données (ex: `GestionNotesDB`).
    c.  Ouvrez le fichier `SQLQuery2.sql` situé à la racine du projet (`Gestion_Notes/SQLQuery2.sql`) dans SSMS.
    d.  Exécutez le script sur la base de données que vous venez de créer. Ce script créera les tables nécessaires et les remplira avec des données initiales.

3.  **Configurer la Connexion à la Base de Données :**
    a.  Ouvrez le fichier de solution `Gestion_Notes.sln` dans Visual Studio.
    b.  Localisez le fichier `ConnexionDB.cs` dans le projet `GestionNotes.DAL`.
    c.  Mettez à jour la chaîne de connexion dans `ConnexionDB.cs` pour qu'elle pointe vers votre instance SQL Server et la base de données `GestionNotesDB`.
        *(Exemple de chaîne de connexion - à ajuster selon votre configuration SQL Server)*
        ```csharp
        // Dans GestionNotes.DAL/ConnexionDB.cs
        public static SqlConnection GetConnection()
        {
            // Remplacez 'VOTRE_NOM_SERVEUR' par le nom de votre instance SQL Server (ex: DESKTOP-ABCDEF\SQLEXPRESS)
            // Remplacez 'GestionNotesDB' par le nom de votre base de données
            string connectionString = "Data Source=VOTRE_NOM_SERVEUR;Initial Catalog=GestionNotesDB;Integrated Security=True;TrustServerCertificate=True";
            return new SqlConnection(connectionString);
        }
        ```
        *Note : Si vous utilisez l'authentification SQL Server, votre chaîne de connexion sera différente (ex: `User ID=votre_utilisateur;Password=votre_mot_de_passe`).*

4.  **Compiler la Solution :**
    a.  Dans Visual Studio, allez dans `Générer` > `Générer la solution` (ou appuyez sur `Ctrl+Maj+B`).
    b.  Assurez-vous qu'il n'y a pas d'erreurs de compilation.

### Exécuter l'Application
1.  Après une compilation réussie, vous pouvez lancer l'application en appuyant sur `F5` ou en allant dans `Déboguer` > `Démarrer le débogage`.
2.  Le formulaire principal de l'application (probablement un écran de connexion ou un tableau de bord) devrait apparaître.

---

## Utilisation
(Cette section peut être complétée avec plus de détails sur l'utilisation des fonctionnalités de l'application une fois celle-ci lancée.)
- Connectez-vous avec les identifiants de test fournis (vérifiez le fichier `SQLQuery2.sql` pour les données utilisateur initiales).
- Naviguez à travers les différents formulaires (ex: Gestion des Étudiants, Saisie des Notes, Statistiques) pour effectuer des opérations.

---
