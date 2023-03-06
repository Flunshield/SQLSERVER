## Union

```sql
select 'A2' Lettre
UNION ALL
select 'B2' Lettre
UNION ALL
select 'C2' Lettre
UNION ALL
select 'D2' Lettre
```

retour : 

![[Pasted image 20230306135155.png]]

```sql
select 'A2' Lettre, 1 lien
UNION ALL
select 'B2' Lettre,2
UNION ALL
select 'C2' Lettre,3
UNION ALL
select 'D2' Lettre,4
```

retour :
![[Pasted image 20230306135221.png]]

 Cette requete SQL permet de créer une table temporaire et persistante (enregistré sur le disque dur) :
```sql
select * into table1 from 
(
select 'A2' Lettre
UNION ALL
select 'B2' Lettre
UNION ALL
select 'C2' Lettre
UNION ALL
select 'D2' Lettre
) t
```


 Cette requete SQL permet de créer une table temporaire et la détruit à la déconnexion grâce au '#' et sera stocké dans le master -> tempDb
 ```sql
 select * into #table2 from 
(
select 'A2' Lettre
UNION ALL
select 'B2' Lettre
UNION ALL
select 'C2' Lettre
UNION ALL
select 'D2' Lettre
) t
```

 Cette requete SQL permet de créer une table temporaire partagé et la détruit à la déconnexion grâce au '#' et sera stocké dans le master -> tempDb
 ```sql
 select * into #table2 from 
(
select 'A2' Lettre
UNION ALL
select 'B2' Lettre
UNION ALL
select 'C2' Lettre
UNION ALL
select 'D2' Lettre
) t
```

Cette requête sélectionne tout les combinaisons de t3 et t2.
```sql
select * from #t3, #t2
```

retour : 
![[Pasted image 20230306140936.png]]

On ajoute une condition pour trier.
```sql
select * from #t4, #t2
where #t4.lien = #t2.id
```

retour :
![[Pasted image 20230306141325.png]]

requete identique avec jointure : 
```sql 
select * from #t4, #t2
inner join #t2 on #t4.lien = #t2.id
```

Une jointure est plus rapide est plus rapide q'un where.

La requête que vous avez fournie est une requête SQL qui effectue une jointure interne entre les tables "Personne" et "Ville" à l'aide de la clause "INNER JOIN".
La clause "INNER JOIN" est utilisée pour combiner les enregistrements de deux tables différentes en utilisant une colonne commune entre elles. Dans ce cas, la colonne commune est "Ville.Id" qui relie la table "Personne" à la table "Ville".
La requête récupère toutes les colonnes de la table "Personne" et toutes les colonnes de la table "Ville" où la valeur de la colonne "Ville.Id" dans la table "Personne" correspond à la valeur de la colonne "Id" dans la table "Ville".
En d'autres termes, cette requête retourne toutes les informations de la personne ainsi que toutes les informations de la ville associée à cette personne en utilisant la clé étrangère "Ville" dans la table "Personne" qui fait référence à l'identifiant "Id" dans la table "Ville".
```sql
select * from Personne p inner join Ville v on p.Ville=v.Id
```

La requête que vous avez fournie est également une requête SQL qui effectue une jointure interne entre les tables "Ville" et "Personne" à l'aide de la clause "INNER JOIN".
Cependant, la différence avec la requête précédente est que l'ordre des tables dans la clause "FROM" a été inversé, ce qui signifie que la table "Ville" est maintenant la table principale à partir de laquelle les données sont récupérées.
La requête récupère toutes les colonnes de la table "Ville" et toutes les colonnes de la table "Personne" où la valeur de la colonne "Ville.Id" dans la table "Ville" correspond à la valeur de la colonne "p.Ville" dans la table "Personne".
En d'autres termes, cette requête retourne toutes les informations de la ville ainsi que toutes les informations des personnes qui vivent dans cette ville en utilisant la clé étrangère "Ville" dans la table "Personne" qui fait référence à l'identifiant "Id" dans la table "Ville".

```sql
select * from Ville v inner join Personne p on p.Ville=v.Id
```

La requête que vous avez fournie est une requête SQL qui effectue une jointure de type "left outer join" entre les tables "Ville" et "Personne" à l'aide de la clause "LEFT OUTER JOIN".
La clause "LEFT OUTER JOIN" est utilisée pour retourner toutes les lignes de la table de gauche "Ville", ainsi que les lignes correspondantes de la table de droite "Personne". Si une ligne de la table de gauche n'a pas de correspondance dans la table de droite, les colonnes de la table de droite contiendront des valeurs NULL.
Dans ce cas, la requête retourne toutes les informations de la table "Ville" et toutes les informations des personnes qui vivent dans cette ville en utilisant la clé étrangère "Ville" dans la table "Personne" qui fait référence à l'identifiant "Id" dans la table "Ville". Si une ville n'a pas de personne associée, les colonnes de la table "Personne" contiendront des valeurs NULL.
En d'autres termes, cette requête retourne toutes les informations des villes, même celles qui n'ont pas de personne associée dans la table "Personne", ainsi que toutes les informations des personnes associées aux villes dans la table "Personne".

```sql
select * from Ville v left outer join Personne p on p.Ville=v.Id
```


La requête que vous avez fournie est une requête SQL qui effectue une jointure de type "right outer join" entre les tables "Ville" et "Personne" à l'aide de la clause "RIGHT OUTER JOIN".
La clause "RIGHT OUTER JOIN" est utilisée pour retourner toutes les lignes de la table de droite "Personne", ainsi que les lignes correspondantes de la table de gauche "Ville". Si une ligne de la table de droite n'a pas de correspondance dans la table de gauche, les colonnes de la table de gauche contiendront des valeurs NULL.
Dans ce cas, la requête retourne toutes les informations des personnes associées aux villes dans la table "Personne", ainsi que toutes les informations des villes même celles qui n'ont pas de personne associée dans la table "Personne".
En d'autres termes, cette requête retourne toutes les informations des personnes, même celles qui n'ont pas de ville associée dans la table "Ville", ainsi que toutes les informations des villes associées aux personnes dans la table "Personne". Notez que si une ville n'a pas de correspondance dans la table "Personne", les colonnes de la table "Personne" contiendront des valeurs NULL.

```sql
select * from Ville v right outer join Personne p on p.Ville=v.Id
```


Cette requete utilise une transaction.
```sql
use BD1;
select * from Ville
select * from Personne

BEGIN TRANSACTION ou TRAN             // On commence une transaction
delete Personne where id=2
delete Ville where id=2
ROLLBACK TRAN // si besoin d'annuler la requete
COMMIT TRAN // si on valide la requete
```

Requete SQL en utilisant une transaction pour créer trois tables dans la bdd "CHESS"
```SQL
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Piece
	(
	id int NOT NULL IDENTITY (1, 1),
	Nom nvarchar(50) NOT NULL,
	Couleur nvarchar(50) NOT NULL,
	Position nvarchar(50) NOT NULL
	)  ON [PRIMARY]
GO
CREATE TABLE dbo.Deplacement
	(
	id int NOT NULL IDENTITY (1, 1),
	Piece int NOT NULL,
	Depart nvarchar(50) NOT NULL,
	Arrive nvarchar(50) NOT NULL,
	DateDeplacement datetime NOT NULL,
	Partie bigint NOT NULL,
	)  ON [PRIMARY]
GO
CREATE TABLE dbo.Partie
	(
	id bigint NOT NULL IDENTITY (1, 1),
	Joueur1 nvarchar(50) NOT NULL,
	Joueur2 nvarchar(50) NOT NULL,
	DateDebut datetime NOT NULL,
	DateFin datetime NOT NULL,
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Piece ADD CONSTRAINT
	PK_Piece PRIMARY KEY CLUSTERED 
	(
	id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Piece SET (LOCK_ESCALATION = TABLE)
GO
ALTER TABLE dbo.Partie ADD CONSTRAINT
	PK_Partie PRIMARY KEY CLUSTERED 
	(
	id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Partie SET (LOCK_ESCALATION = TABLE)
GO
ALTER TABLE dbo.Deplacement ADD CONSTRAINT
	FK_Deplacement_Partie FOREIGN KEY
	(
	Partie
	) REFERENCES dbo.Partie
	(
	id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Deplacement ADD CONSTRAINT
	FK_Deplacement_Piece FOREIGN KEY
	(
	Piece
	) REFERENCES dbo.Piece
	(
	id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Deplacement SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
```