![[image0.png]]

-   **La BDD hiérarchique**. Souvent présentée sous forme d’arbre avec ses ramifications, il s’agit du tout premier programme qui a permis de structurer l’information de façon hiérarchique. Ici, chaque enregistrement dépend d’un seul enregistrement, et chaque niveau d’enregistrement découle sur un ensemble de catégories plus petites. 
    
-   **La BDD réseau**. Dans ce cas, contrairement à la BDD hiérarchique, un objet peut avoir plusieurs objets parents et plusieurs objets enfants, ce qui permet de s’approcher du monde réel plus fidèlement. Des liens multiples sont ainsi créés entre les ensembles, permettant une vitesse et une polyvalence qui ont permis leur adoption massive. 
    
-   **La BDD SQL ou relationnelle**. C’est la plus connue et la plus pratiquée actuellement. Reposant sur l’algèbre relationnel, elle a pour fonction de modéliser facilement les systèmes du monde réel, et de créer des bases de données à la fois simples à maintenir et à faire évoluer. Constituées d’un ensemble de tableaux, ces bases de données contiennent des données classées par catégorie. L’API standard pour ces BDD est le Structured Query Language (SQL). 
	- Relation entre les tables
	-
    
-   **La BDD orientée objet**. Cette typologie de base de données est encore en cours d’élaboration. Elle est focalisée sur la base de données des objets en tant que concept de programmation qui va permettre de simplifier la création de logiciels. 
    
-   **La BDD orientée texte**. La “flat file database” se présente sous la forme d’un fichier .txt ou .ini, qui est soit un fichier texte, soit un fichier combinant du texte avec un fichier binaire. Chaque ligne ne comporte généralement qu’un seul enregistrement. 
    
-   **La BDD distribuée**. Ce type de base de données présente des portions stockées au sein de différents endroits physiques, avec un traitement réparti ou répliqué entre différents points d’un réseau. Elle peut être homogène ou hétérogène : soit tous les emplacements physiques fonctionnent avec le même hardware et tournent sous le même système d’exploitation et les mêmes applications de bases de données, soit ils varient entre différents endroits physiques. 
    
-   **La BDD cloud**. Optimisée ou directement créée pour les environnements virtualisés, elle peut être relative à un cloud privé, un cloud public ou un cloud hybride. Ses avantages sont multiples : paiement pour la capacité de stockage et la bande passante en fonction de l’usage, changement d’échelle sur demande, disponibilité plus élevée…
    
-   **La BDD NoSQL**. Poussées par l’essor du Big Data, elles sont utiles pour les larges ensembles de données distribuées, et parfaites pour analyser des quantités importantes de données non structurées, ou stockées sur plusieurs serveurs cloud virtuels. 
    
-   **La BDD orientée graph**. C’est un type de database NoSQL qui utilise la théorie des graphes pour stocker, cartographier et effectuer des requêtes sur les relations entre les données.

# BDD relationnelle
[Une base de données relationnelle](https://actualiteinformatique.fr/cloud/definition-base-de-donnee-relationelle) est un type de base de données où les données sont liées à d'autres informations au sein des [bases de données](https://www.oracle.com/fr/database/definition-base-de-donnees.html). Les bases de données relationnelles sont composées d’un ensemble de tables qui peuvent être accessibles et reconstruites de différentes manières, sans qu'il soit nécessaire de réarranger ces tables de quelque façon que ce soit. Le langage de requête structuré (SQL) est l’interface standard pour une base de données relationnelle. Les instructions SQL sont utilisées à la fois pour interroger de façon interactive les données contenues dans la base de données relationnelle et pour collecter les données dans le cadre de rapports.

#### Principe de fonctionnement d’une base de données relationnelle

Les [systèmes de gestion de base de données](https://www.oracle.com/fr/database/systeme-gestion-base-de-donnees-sgbd-definition.html) relationnelle permettent de mettre en avant les relations entre les données. Ces données sont organisées en table dans des lignes et colonnes afin d’être accessibles.

Les tables contiennent toutes des informations sur les relations entre les différentes données, telles qu'un type de produit. Chaque ligne est un produit ou une personne spécifique et les colonnes énumèrent les attributs qui se rapportent à ce produit ou à cette personne, tels que la couleur, la taille, etc.

Une clé est un groupe d'attributs minimum qui permet d'identifier de façon univoque une ligne dans une relation. Pour identifier un enregistrement, tous les attributs d'une clé doivent avoir une valeur, c'est-à-dire qu’on ne peut avoir de valeur NULL. Dire qu'un groupe d'attribut est une clé équivaut à dire qu'il est unique et non NULL (exemple : le groupe d’attribut nom et prénom).

Si plusieurs clés existent dans une table, il sera nécessaire de choisir une unique clé qui sera appelée clé primaire. Cette clé permettra d’identifier les informations contenues dans une table. La clé primaire est généralement choisie porte généralement sur le moins d'attributs possibles et sur les attributs les plus basiques.

La relation entre les tables peut ensuite être définie à l'aide de clés étrangères. Une clé étrangère est un champ d'une table qui est lié à la clé primaire d'une autre table.

#### Les contraintes du modèle relationnel

Les contraintes d'intégrité relationnelle se réfèrent aux conditions qui doivent être présentes pour qu'une relation soit valide. Il existe de nombreux types de contraintes d'intégrité. Les contraintes sur le système de gestion de base de données relationnelles sont principalement divisées en trois catégories principales : contraintes clés, contraintes de domaine et contraintes d'intégrité référentielle.

**Une contrainte de clé** : qui indiquent qu'une table doit toujours avoir une clé primaire La valeur de l'attribut pour les différents enregistrements de la relation doit être unique. Les contraintes clés sont également connues sous le nom de contraintes d'entité.

**Les contraintes de domaine** limitent la plage des valeurs de domaine d'un attribut. Ils spécifient également l'individualité et si un attribut peut avoir une valeur nulle. Il peut également spécifier une valeur par défaut pour un attribut lorsque aucune valeur n'est fournie.

Les contraintes du domaine peuvent être violées si une valeur d'attribut n'apparaît pas dans le domaine correspondant ou si elle n'est pas du type de données approprié.

**La contrainte d'intégrité référentielle** indique que les relations entre les tables doivent toujours être cohérentes. En d'autres termes, la zone de clé étrangère doit correspondre à la clé primaire référencée par la clé étrangère. Tout changement de champ de clé primaire doit être appliqué à toutes les clés étrangères, ou pas du tout.

#### Avantages et inconvénients d'une base de données relationnelle

Les bases de données relationnelles présentent plusieurs avantages par rapport aux bases de données traditionnelles.

-   Indépendance structurelle : La base de données relationnelle ne concerne que les données et non une structure. Cela peut améliorer les performances du modèle.
-   Facilité d’utilisation: Le modèle relationnel est très intuitif à utiliser car composé de tableaux organisés de lignes et de colonnes.
-   Capacité d'interrogation : Il permet à un langage de requête de haut niveau comme SQL d'éviter une navigation complexe dans la base de données.
-   Indépendance des données : La structure d'une base de données peut être modifiée sans avoir à changer d'application.
-   Redondance des données : Une base de données relationnelle garantit qu'aucun attribut n'est répété.

Cependant, il est important de garder à l'esprit que les bases de données relationnelles peuvent parfois être lentes et peu évolutives :

-   Certaines bases de données relationnelles ont des limites sur la longueur des champs utilisés.
-   Les bases de données relationnelles peuvent parfois devenir complexes à mesure que la quantité de données augmente et que les relations entre les éléments de données deviennent plus complexes.
-   Les systèmes de bases de données relationnelles complexes peuvent conduire à des bases de données isolées où l'information ne peut être partagée d'un système à l'autre.

Toujours utiliser que des lettre simple, des chiffre, des underscores, INTERDIT tout le reste

**La relation s'explique d'une clef étrangère qui pointe sur une clef primaire.**

Le SQL n'ets aps sensible à la casse.

![[image6.png]]

## Clef primaire
clef primaire : **Une clé primaire est un champ ou un ensemble de champs de table qui contient des valeurs uniques**. Les valeurs de la clé peuvent être utilisées pour faire référence à des enregistrements entiers, car chaque enregistrement dispose d'une valeur différente pour la clé.

## Clef étrangère 
La clé étrangère est un **outil essentiel dans une base de données (BDD) relationnelle.** **Elle permet de mettre en relation les différentes tables de la BDD**. C'est aussi une contrainte qui assure l'intégrité référentielle de celle-ci.
=> Doit être identique à la clef primaire.

L'ensemble d'une clef étrangère constitue l'intégrité référentiel de la base de données.

Ne pas confondre l'intégrité référentiel et les jointures. !!!!!

Les jointures sont des requettes SQL.

![[Pasted image 20230306094232.png]]

# SQL SERVER 
## SQL server est comme office, c'est une famille de produit :
	- Database Engine
	- BI (Business intelligence)
		- SSIS (SQL Server Integration Services) est ce qu'on appelle un ETL (Extract Transform Load)
			- Logiciel qui permet de transférer des données
		- SSAS Décisionnel Cube (SQL SERVER Analysys Services) : On réalise des stats et prévision avec.
		- SSRS (SQL SERVER Reporting Services) : Permet de réaliser des rapports au format html (exemple : directeur qui regarde els chiffres à la fin du mois)

![[Pasted image 20230306100609.png]]

## Installation d'unj SQL server
### Outils
- SQL EXPRESS 2017 (version du cours)
- Management studio

Quand j'installe SQL Server, j'installe une instance, quand j'installe une instance, je nomme cette instance.

![[image 6 1.png]]

Une instance = 1 SQL SERVER (1 service (Dans le cours c'est un service Windows))
Trois instance = 3 SQL SERVER

Chaque SQL Server peut avoir plusieurs BDD.

Une instance SQL Server est typée.
	- DBEngine (gère des données)
	- SSIS (gère des packages)
	- SSAS (gère les cubves)
	- SSRS (gère les rapports)

Clic droit sur base de donnée, puis donner un nom.

![[Pasted image 20230306103146.png]]

Une BDD de 10/20 Go est petite, une normal est en tera.

**Dans un SQL server, il y a toujours un fichier ldf et mdf**
mdf => bdd
ldf => journal de transaction (mis à jour à chaque nouvelle requête) => permet de faire un retour arrière. On ne peut pas lire le fichier. On ne peut que dire "restaure la bdd de tel heure"

Les fichiers ndf sont des extentions du fichier mdf.

**Si le nom du SQL server est el même que le nom du serveur, on dira que c'est une instance par défaud qui est payante**

Second instance SQL server comme ceci : 
nom du SQL server : Pionne\SQS1 => instance nommé

Troisième instance SQL server :
Pionne\SQLEXPRESS (instance nommé) version gratuite

### Les objets SQL Server

Dans SQL server nousa vons une BDD.
Dans une BDD on a des données qui sont dans des tables.
Login
Vue (table virtuelle) = Résultat suit à une requete SQL.
Stored Procedure (programme écrit en SQL)
Function
Assembly
Rule
Sequence
...

### Fonctionnement SQL SERVER
**Pour s'adresser à SQL server, il faut utilisrr le language SQL (seule manière) directement ou indirectement.**

![[8.png]]

SQL SERVER est un service, pour le visualiser, ilf aut passer par un client (management studio). Le client communique uniquement avec SQL SERVER via des requetes SQL (transact SQL).

Exemple : SELECT * FROM nomtable fo XML Auto (retourne du xml)

Le Go permet de temporiser. il peut être remplacer par un ; mais ce n'ets pas toujorus correct.

### Base de données Système
Quand on créé une BDD on créé une copie de model.
**Master** : Tout les objets au sens large présent dans SQL SERVER se trouve dans cette base de donnée. 
**Model** : C'est un model pour la création de la bdd (on utilisera ce template pour base)
**msdb** : La base de données msdb est **utilisée par l'Agent SQL Server pour la planification des alertes et des travaux et par d'autres fonctionnalités telles que SQL Server Management Studio, Service Broker et Database Mail** . Par exemple, SQL Server conserve automatiquement un historique complet de sauvegarde et de restauration en ligne dans les tables de msdb.
**tempDb** : La base de données système tempdb est **une ressource globale qui contient :** **Des objets utilisateur temporaires créés explicitement** . Ils incluent les tables et index temporaires globaux ou locaux, les procédures stockées temporaires, les variables de table, les tables renvoyées dans les fonctions table et les curseurs.

![[9.png]]

Si il y a un plantage lors d'une transaction, la transaction s'annule.

Une transaction peut avboir plusieurs instructions.

char = prend 1 octet, char(50) prend 50 octets.

nvarchar = prend au maximum 50 charactère.

**Un champ identity est un champ automatique.**

## Requete SQL

Il existe 4 type de requetes :
- DML (Data manipulation Langue) + CRUD (create read update delete)
	- SELECT 
	- INSERT
	- UPDATE
	- DELETE
- DDL (Data Description Language)
	-Instruction :
	- Tout les CREATE
	- Tout les halteres (modifié)
	- Tout les drop (Supprimé)
- DCL (Data Controle Language)
	- Instruction :
		- Grant (autorisation)
		- DENY 
		- REVOKE
- TCL (Transaction controle Language)
	- Instruction
		- Bguin Tran
		- Commit
		- Rollback

## Construction requete sql avec inner join
Pour construire une requête SQL comme celle-ci :
```SQL
SELECT sp.BusinessEntityID, p.FirstName, p.LastName, SUM(soh.SalesOrderID) AS TotalSales FROM Sales.SalesPerson sp 
INNER JOIN Person.Person p ON sp.BusinessEntityID = p.BusinessEntityID 
INNER JOIN Sales.SalesOrderHeader soh ON sp.BusinessEntityID = soh.SalesPersonID 
INNER JOIN Sales.SalesOrderDetail sod ON soh.SalesOrderID = sod.SalesOrderID 
GROUP BY sp.BusinessEntityID, p.FirstName, p.LastName
```

1.  Identifier les tables à utiliser et les colonnes nécessaires : Dans cette requête, les tables Sales.SalesPerson, Person.Person, Sales.SalesOrderHeader et Sales.SalesOrderDetail sont utilisées, et les colonnes BusinessEntityID, FirstName, LastName et SalesOrderID sont sélectionnées.
    
2.  Déterminer les clés de jointure entre les tables : Dans cette requête, la clé de jointure est BusinessEntityID pour la table Sales.SalesPerson et Person.Person, SalesPersonID pour la table Sales.SalesOrderHeader et Sales.SalesPerson, et SalesOrderID pour les tables Sales.SalesOrderHeader et Sales.SalesOrderDetail.
    
3.  Écrire la requête SQL : En utilisant les tables et les colonnes identifiées, écrire la requête SQL en utilisant les INNER JOIN pour joindre les tables et les clés de jointure pour spécifier comment les tables doivent être jointes. Dans cette requête, la fonction d'agrégation SUM est utilisée pour calculer le montant total des ventes pour chaque vendeur.
    
4.  Ajouter une clause GROUP BY : Pour agréger les résultats par vendeur, ajouter une clause GROUP BY avec les colonnes utilisées dans la sélection.
    
5.  Exécuter la requête : Exécuter la requête pour récupérer les résultats.

## Les procédures stockées

Ne pas s'inquiété si on perd la procédure stocké car elle est dans la bdd.
Une procédure stocké doit répondre au plus grand nombre de besoin.

### Créer/Modifier/Exécuter une procédure
```SQL
-- On créé la procédure stocké
CREATE PROC ListeProduit --(nom que l'on veut)
AS 
	SELECT 
		ProductID, Color, ListPrice, ProductNumber
	FROM 
		Production.Product
Go
-- On éxécute la procédure stocké
Exec ListeProduits

-- On modifi la procédure pour une couleur
ALTER PROC ListeProduit(@couleur nvarchar(MAX)) --(nom que l'on veut)
AS 
	SELECT 
		ProductID, Color, ListPrice, ProductNumber
	FROM 
		Production.Product
	WHERE 
		Color = @couleur
Go
-- On éxécute la procédure stocké pour changer la couleur
Exec ListeProduits 'silver'
Exec ListeProduits -- fait office de if si deuxieme Exec

```

Avec l'opérateur AND
```SQL
-- On modifi la procédure pour une couleur
ALTER PROC ListeProduit(@couleur nvarchar(15)=null, @seuil money=null, @type char(2)=null) --(nom que l'on veut)
AS 
	SELECT 
		ProductID, Color, ListPrice, ProductNumber
	FROM 
		Production.Product
	WHERE 
		(@couleur is null or color=@couleur)
		and
		(@seuil is null or ListPrice > @seuil)
		and
		(@type is null or LEFT(ProductNumber, 2) = @type)
Go
-- On éxécute la procédure stocké pour changer la couleur
Exec ListeProduits 'silver', '10' -- on recherche une couleur silver ou un prix minimum à 10
Exec ListeProduits
Exec ListeProduits @seuil='3000' -- si le paramètre est spécifié, pas besoin de s'occuper de l'ordre
Exec ListeProduits @type='SO', @Couleur='black'

```

## Le XML
**Extensible Markup Language** (XML) vous permet de définir et de stocker des données de manière à pouvoir les partager. XML prend en charge l'échange d'informations entre des systèmes informatiques tels que les sites web, les bases de données et les applications tierces.

!! Le HTML est du XML !! => apparut avant le XML.

### Règle xml
1 - Toute balise doit avoir une ouverte et une fermeture comme du **HTML**..
2 - Un XML doit etre contenue dans un ``noeud racine``.
3 - Le XML tient compte de la casse.
4 - On écrit en minuscule
5 - Lorsqu'on ajoute des attribu, on met toujours des "" même pour un nombre. // Ne pas en mettre dans les childrens des balises.

Le JSON est censé remplacer le XML mais n'ets pas encore arrivé à son niveau.

L'inconvénient du XML est qu'il est *verbeux* c'est à dire qu'il faut écrire beaucoup pour pas grand chose.
![[Pasted image 20230307142524.png]]

XAML est un **langage de balisage déclaratif**. Comme appliqué au modèle de programmation . NET, XAML simplifie la création d'une interface utilisateur pour une application .

Caml est un langage de programmation généraliste conçu pour la sécurité et la fiabilité des programmes. Il se prête à des styles de programmation fonctionnelle, impérative et orientée objet. C'est de plus un langage fortement typé.

Le _**Portable Document Format**_, communément [abrégé](https://fr.wikipedia.org/wiki/Abr%C3%A9viation "Abréviation") en **PDF**, est un [langage de description de page](https://fr.wikipedia.org/wiki/Langage_de_description_de_page "Langage de description de page") présenté par la société [Adobe Systems](https://fr.wikipedia.org/wiki/Adobe_(entreprise) "Adobe (entreprise)") en [1992](https://fr.wikipedia.org/wiki/1992_en_informatique "1992 en informatique") et qui est devenu une norme [ISO](https://fr.wikipedia.org/wiki/Organisation_internationale_de_normalisation "Organisation internationale de normalisation") en [2008](https://fr.wikipedia.org/wiki/2008 "2008"). La spécificité du PDF est de préserver la [mise en page](https://fr.wikipedia.org/wiki/Mise_en_page "Mise en page") d’un document — polices de caractères, images, objets graphiques, etc. — telle qu'elle a été définie par son auteur, et cela quels que soient le [logiciel](https://fr.wikipedia.org/wiki/Logiciel "Logiciel"), le [système d'exploitation](https://fr.wikipedia.org/wiki/Syst%C3%A8me_d%27exploitation "Système d'exploitation") et l'[ordinateur](https://fr.wikipedia.org/wiki/Ordinateur "Ordinateur") utilisés pour l’imprimer ou le visualiser.

### Type de xml

**XSL** eXtensible Stylesheet Language : Language de programmation qui s'écrit en xml. Il permet de transformer du xml en xml. Il ets universelle.
	Par exemple du **xml word**en **xml pdf**

**XSD** : C'est un language de description.  On lui donne un xml et il retourne le type : word, pdf..... ( il vérifit le shéma de votre xml.)
Les fichiers XML Schema Definition (XSD) **permettent de décrire la structure d'un document XML**. Le grand intérêt de ce fichier est de servir à la validation du document XML en définisant des règles.

**XPATH** : Language de programmation. C'est le SQL du XML. On fait des requêtes pour aller chercher des informations dans du XML.
**XPath** est un [langage de requête](https://fr.wikipedia.org/wiki/Langage_de_requ%C3%AAte "Langage de requête") pour localiser une portion d'un document [XML](https://fr.wikipedia.org/wiki/Extensible_markup_language "Extensible markup language"). Initialement créé pour fournir une syntaxe et une sémantique aux fonctions communes à [XPointer](https://fr.wikipedia.org/wiki/XPointer "XPointer") et [XSL](https://fr.wikipedia.org/wiki/Extensible_stylesheet_language "Extensible stylesheet language"), XPath a rapidement été adopté par les développeurs comme langage d'interrogation simple d'emploi.

HTML : Language de description.


### Requete avec du XML
```SQL
CREATE PROC ListeProduitsXML (@data xml)
AS
	DECLARE @couleur nvarchar(15)
	DECLARE @seuil money
	DECLARE @type char(2)
	-- ******************************************
	SELECT
		N.value('@couleur[1]', 'nvarchar(15)') AS couleur,
		N.value('@seuil[1]', 'money') AS seuil,
		N.value('type[1]', 'char(2)') AS type
	FROM
		@data.nodes('/produit') AS T(N)
	-- ******************************************
Go
Exec ListeProduitsXML '<produit couleur="Blue" seuil="3000"><type>BK</type></produit>'

--************************************************************************************
CREATE/ALTER PROC ListePersonneXML (@data xml)
AS
	DECLARE @prenom nvarchar(MAX)
	SELECT 
		@prenom = N.value('@prenom[1]','nvarchar(15)')
	FROM
		@data.nodes('/personne') AS T(N)
	SELECT * from Person.Person where FirstName=@prenom
Go
Exec ListePersonneXML '<personne prenom="ken"></personne>'

--**************************************************************************************
CREATE/ALTER PROC ListePersonneXML (@data xml)
AS
	SELECT 
		N.value('@prenom[1]','nvarchar(15)') prenom
	INTO #t -- La table tempo disparait a la fin de la procédure
	FROM
		@data.nodes('/personnes/personne') AS T(N)
	SELECT BusinessEntityID, FirstName, LastName, PersonType 
	FROM Person.Person 
	WHERE FirstName IN (prenom FROM #t)
Go
Exec ListePersonneXML 
	'<personne>
		<personne prenom="Robert" type="IM"/>
		<personne prenom="Marie" type="EM"/>
		<personne prenom="Mary"/>
	</personne>'
	
```