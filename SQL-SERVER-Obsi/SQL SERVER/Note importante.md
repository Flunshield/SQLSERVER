Une requête TSQL renvoie du XML et des tables.
Eviter le select * !!!!!
Une application utilisée pour la gestion de BD : managment studio.

Un serveur possède trois instances de SQL Server. Cela signifie que SQL Server a été installé 3 fois.
Avec le langage TSQL, on peut faire :
	- Lire des infos de plusieurs tables en même temps
	- Créer une base de données
	- Affecter des autorisations

Bases de données système :
![[9.png]]

L'intégrité référentielle permet d'assurer la cohérence de la BD.

La clé étrangère pointe ver la clé primaire.

Pour une clé primaire, les meilleurs types sont :
	- int
	- bigint
	- uniqueidentifier

Quelle instruction du DDL pour créer un élément : CREATE ou cette commande : 
 Cette requete SQL permet de créé une table temporaire et persistante (enregistré sur le disque dur) :
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
) nomdelatable
```

Quelle instruction du DML pour créer un élément  : INSERET / SELECT

Quoi utiliser pour transformer du XML en XML ?
	- XSL

Peut-on créer un objet Dataset sans parler de BD ?
	- Oui

Select * from Ordinateur XXX clavier on Ordinateur.Clavier = Clavier.Id
Je veux voir tous les claviers, même ceux qui ne sont pas associés à un ordinateur. 
Il faut remplacer XXX par : left outer join

Un ORM comme Entity framework permet de faire le lien entre :
- la programmation Objet
- le système relationnel

select COUNT(*) from Produit where categorie=null
La table Produit contient 31 produits sans catégorie
Cette requête retourne :
- 0

Quels sont les intérêts des procédures stockées ?
- Performance
- Sécurité
- Faire des if et des while

Une table t1 contient 3 enregistrements et une table t2 7
Combien d'enregistrements avec select * from t1, t2
21

Pour créer une table temporaire persistente :
- select * into #t from Produit
- select * into ##t from Produit

Quels sont les instructions du TCL ?
- Grant
- Deny

Pour qu'un champ soit attribué d'une numérotation automatique :
- Identity
- bigint

Quelles classes utiliser en mode connecté ?
- SqlConnection
- SqlCommand
- SqlDataReader
- dataset

Une jointure est plus rapide est plus rapide q'un where.

# Vocabulaire

Une table peut être :
- **temporaire** ou **permanente/persistante**.

```SQL
select * into t from person -- La table t sera persistante et permanante (enregistré sur le disque dur (permanente))

select * into #t from person -- La table t sera persistante et temporaire (supprimé lors de la déconnexion au serveur ou le temps de la procédure)

select * into ##t from person -- La table t sera persistante, temporaire et partagé (supprimé lors de la déconnexion au serveur)

```


## Common table expression
La table sera volatile et temporaire. Elle sera plus rapide car elle sera stocké en mémoire, mais nous serons limité en taille.

L'expression de table commune (CTE) est une construction puissante en SQL qui permet de simplifier une requête. Les CTE fonctionnent comme des tables virtuelles (avec des enregistrements et des colonnes), créées lors de l'exécution d'une requête, utilisées par la requête et éliminées après l'exécution de la requête.

5 à 10 fois plus vite qu'une table normal.

```sql
use AdventureWorks2017
-- CTE
WITH t(id, nom) -- avec la table temporaire t
AS 
(
select ProductID, [Name] from Production.product -- remplit avec les champs ProductID et [Name] 
)
select * from t -- je sélectionne tout dans la table tempo t
```

C# est apparu a partir de .NET.

Historiquement c'est comme ça :
COM
.Net = windows Vista, office 2007, SQL server 2005....
Core .Net = SQL server 20017, IIS, ASP.Net, WPF (Blazor, MAUI...)

C# et Transact SQL sont de la famille *.net*.