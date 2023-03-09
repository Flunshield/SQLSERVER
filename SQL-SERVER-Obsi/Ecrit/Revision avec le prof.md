Créer plusieurs tables et de les manipuler par la suite.

```SQL
-- Avion -> iDAvion, Modele, Compagnie
-- Pilote -> IdPilote, Nom, Prenom, DateNaissance
-- Vol -> IdVol, DateDepart, DateArrive, IdAvion, IdPilote, LieuDepart, LieuArrivee

-- Clés primaire / Clés étrangères

-- Remplir les tables avec C#

-- Fonction qui récupère le pilote sur un vol
-- Fonction qui récupère l'avion du vol
-- Focntion qui donne tout les vols avec : nom pilote + modèle de l'avion qui ont pour Depart l'argument
	-- Func(LieuDepart)
		--> ListeVols, Pilotes

BEGIN TRANSACTION
GO
CREATE TABLE dbo.Avion
	(
	IdAvion uniqueidentifier NOT NULL,
	Modele nvarchar(50) NOT NULL,
	Compagnie nvarchar(50) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Avion SET (LOCK_ESCALATION = TABLE)
GO
GO
CREATE TABLE dbo.Pilote
	(
	IdPilote uniqueidentifier NOT NULL,
	Nom nvarchar(50) NOT NULL,
	Prenom nvarchar(50) NOT NULL,
	DateNaissance datetime NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Pilote SET (LOCK_ESCALATION = TABLE)
GO
CREATE TABLE dbo.Vol
	(
	IdVol uniqueidentifier NOT NULL,
	DateDepart datetime NOT NULL,
	DateArrive datetime NULL,
	IdAvion uniqueidentifier NULL,
	IdPilote uniqueidentifier NULL,
	LieuDepart nvarchar(50) NULL,
	LieuArrivee nvarchar(50) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Vol SET (LOCK_ESCALATION = TABLE)
GO
GO
ALTER TABLE dbo.Pilote ADD CONSTRAINT
	PK_Pilote PRIMARY KEY CLUSTERED 
	(
	IdPilote
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Pilote SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Avion ADD CONSTRAINT
	PK_Avion PRIMARY KEY CLUSTERED 
	(
	IdAvion
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Avion SET (LOCK_ESCALATION = TABLE)
GO
ALTER TABLE dbo.Vol ADD CONSTRAINT
	FK_Vol_Avion FOREIGN KEY
	(
	IdAvion
	) REFERENCES dbo.Avion
	(
	IdAvion
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Vol ADD CONSTRAINT
	FK_Vol_Pilote FOREIGN KEY
	(
	IdPilote
	) REFERENCES dbo.Pilote
	(
	IdPilote
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Vol SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
```