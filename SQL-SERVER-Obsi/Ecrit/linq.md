Une _requête_ est une expression qui récupère des données d’une source de données. Les requêtes sont généralement exprimées dans un langage de requête spécialisé. Les différents langages ont été développés au fil du temps pour les différents types de sources de données, par exemple, SQL pour les bases de données relationnelles et XQuery pour XML. Les développeurs devaient donc apprendre un nouveau langage de requête pour chaque nouveau type de source de données ou format de données qu’ils devaient prendre en charge. LINQ simplifie cette situation en proposant un modèle cohérent pour travailler avec des données dans différents types de sources et de formats de données. Dans une requête LINQ, vous travaillez toujours avec des objets. Vous utilisez les mêmes modèles de codage de base pour interroger et transformer des données dans des documents XML, des bases de données SQL, des jeux de données ADO.NET, des collections .NET et tout autre format pour lequel un fournisseur LINQ est disponible.

[Lien doc officiel](https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries#three-parts-of-a-query-operation)

## Les trois parties d’une opération de requête

Toutes les opérations de requête LINQ se composent de trois actions distinctes :

1.  Obtention de la source de données
    
2.  Création de la requête
    
3.  exécutez la requête.
    

L’exemple suivant montre comment les trois parties d’une opération de requête sont exprimées dans le code source. Cet exemple utilise un tableau d’entiers comme source de données pour des raisons pratiques. Toutefois, ces mêmes concepts s’appliquent également aux autres sources de données. Le reste de la rubrique fait référence à cet exemple.

C#Copier

```
class IntroToLINQ
{
    static void Main()
    {
        // The Three Parts of a LINQ Query:
        // 1. Data source.
        int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

        // 2. Query creation.
        // numQuery is an IEnumerable<int>
        var numQuery =
            from num in numbers
            where (num % 2) == 0
            select num;

        // 3. Query execution.
        foreach (int num in numQuery)
        {
            Console.Write("{0,1} ", num);
        }
    }
}
```

L’illustration suivante montre l’intégralité de l’opération de requête. Dans LINQ, l’exécution de la requête est distincte de la requête elle-même. En d’autres termes, vous n’avez récupéré aucune donnée en créant simplement une variable de requête.

![Diagramme de l’opération de requête LINQ complète.](https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/concepts/linq/media/introduction-to-linq-queries/linq-query-complete-operation.png)

[](https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries#the-data-source)

## Source de données

Dans l’exemple précédent, comme la source de données est un tableau, elle prend en charge implicitement l’interface générique [IEnumerable<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.generic.ienumerable-1). Cela signifie qu’elle peut être interrogée avec LINQ. Une requête est exécutée dans une instruction `foreach`, et `foreach` nécessite [IEnumerable](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.ienumerable) ou [IEnumerable<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.generic.ienumerable-1). Les types qui prennent en charge [IEnumerable<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.generic.ienumerable-1) ou une interface dérivée, comme l’interface générique [IQueryable<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.linq.iqueryable-1), sont appelés des _types requêtables_.

Un type requêtable ne nécessite aucune modification ni traitement spécial pour servir de source de données LINQ. Si les données sources ne sont pas déjà en mémoire en tant que type requêtable, le fournisseur LINQ doit le représenter comme tel. Par exemple, LINQ to XML charge un document XML dans un type requêtable [XElement](https://learn.microsoft.com/fr-fr/dotnet/api/system.xml.linq.xelement) :

C#Copier

```
// Create a data source from an XML document.
// using System.Xml.Linq;
XElement contacts = XElement.Load(@"c:\myContactList.xml");
```

Avec LINQ to SQL, vous créez tout d’abord un mappage relationnel d’objet au moment de la conception, soit manuellement, soit à l’aide des [outils de LINQ to SQL dans Visual Studio](https://learn.microsoft.com/fr-fr/visualstudio/data-tools/linq-to-sql-tools-in-visual-studio2). Vous écrivez vos requêtes sur les objets, et à l’exécution ; LINQ to SQL gère la communication avec la base de données. Dans l’exemple suivant, `Customers` représente une table spécifique de la base de données et le type du résultat de la requête, [IQueryable<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.linq.iqueryable-1), dérive de [IEnumerable<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.generic.ienumerable-1).

C#Copier

```
Northwnd db = new Northwnd(@"c:\northwnd.mdf");

// Query for customers in London.
IQueryable<Customer> custQuery =
    from cust in db.Customers
    where cust.City == "London"
    select cust;
```

Pour plus d’informations sur la création de types spécifiques de sources de données, consultez la documentation relative aux différents fournisseurs LINQ. Toutefois, la règle de base est très simple : une source de données LINQ est un objet qui prend en charge l’interface générique [IEnumerable<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.generic.ienumerable-1) ou une interface qui hérite de celui-ci.

 Notes

Les types tels que [ArrayList](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.arraylist) qui prennent en charge l’interface non générique [IEnumerable](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.ienumerable) peuvent également être utilisés comme source de données Linq. Pour plus d’informations, consultez [Guide pratique pour interroger une liste de tableaux avec LINQ (C#)](https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/concepts/linq/how-to-query-an-arraylist-with-linq).

[](https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries#query)

## La requête

La requête spécifie les informations à récupérer à partir de la ou des sources de données. Si vous le souhaitez, une requête peut également spécifier la manière dont ces informations doivent être triées, regroupées et mises en forme avant d’être retournées. Une requête est stockée dans une variable de requête et initialisée avec une expression de requête. Pour faciliter l’écriture de requêtes, le langage C# propose désormais une nouvelle syntaxe de requête.

La requête de l’exemple précédent retourne tous les nombres pairs du tableau d’entiers. L’expression de requête contient trois clauses : `from`, `where` et `select`. (Si vous connaissez SQL, vous aurez remarqué que l’ordre des clauses est inversé par rapport à l’ordre dans SQL.) La clause `from` spécifie la source de données, la clause `where` applique le filtre et la clause `select` spécifie le type des éléments retournés. Celles-ci et les autres clauses de requête sont abordées en détail dans la section [Language Integrated Query (LINQ)](https://learn.microsoft.com/fr-fr/dotnet/csharp/linq/). Pour le moment, le point important est que dans LINQ, la variable de requête elle-même n’effectue aucune action et ne retourne aucune donnée. Elle stocke simplement les informations qui seront nécessaires pour produire des résultats lors de l’exécution ultérieure de la requête. Pour plus d’informations sur la construction des requêtes en arrière-plan, consultez [Vue d’ensemble des opérateurs de requête standard (C#)](https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/concepts/linq/standard-query-operators-overview).

 Notes

Les requêtes peuvent également être exprimées à l’aide d’une syntaxe de méthode. Pour plus d’informations, consultez [Syntaxe de requête et syntaxe de méthode dans LINQ](https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/concepts/linq/query-syntax-and-method-syntax-in-linq).

[](https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries#query-execution)

## Exécution des requêtes

[](https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries#deferred-execution)

### Exécution différée

Comme indiqué précédemment, la variable de requête stocke uniquement les commandes de requête. L’exécution de la requête est différée jusqu’à ce que vous itériez au sein de la variable de requête dans une instruction `foreach`. Ce concept est appelé _exécution différée_ et est illustré dans l’exemple suivant :

C#Copier

```
//  Query execution.
foreach (int num in numQuery)
{
    Console.Write("{0,1} ", num);
}
```

C’est dans l’instruction `foreach` que les résultats de requête sont récupérés. Par exemple, dans la requête précédente, la variable d’itération `num` contient chaque valeur (une à la fois) de la séquence retournée.

Étant donné que la variable de requête ne contient jamais les résultats de requête, vous pouvez l’exécuter aussi souvent que vous le voulez. Par exemple, vous disposez peut-être d’une base de données qui est constamment mise à jour par une application distincte. Vous pouvez créer dans cette dernière une requête dans le but d’extraire les données les plus récentes, puis l’exécuter à intervalle régulier. Vous obtiendrez à chaque fois des résultats différents.

[](https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries#forcing-immediate-execution)

### Forcer l’exécution immédiate

Les requêtes qui exécutent des fonctions d’agrégation sur une plage d’éléments sources doivent d’abord itérer au sein de ces éléments. Ces requêtes sont par exemple `Count`, `Max`, `Average` et `First`. Elles s’exécutent sans instruction `foreach` explicite, car les requêtes doivent utiliser `foreach` pour retourner un résultat. Notez également que ces types de requêtes retournent une seule valeur, et non une collection `IEnumerable`. La requête suivante retourne un nombre de chiffres pairs du tableau source :

C#Copier

```
var evenNumQuery =
    from num in numbers
    where (num % 2) == 0
    select num;

int evenNumCount = evenNumQuery.Count();
```

Pour forcer l’exécution immédiate de n’importe quelle requête et mettre en cache ses résultats, vous pouvez appeler les méthodes [ToList](https://learn.microsoft.com/fr-fr/dotnet/api/system.linq.enumerable.tolist) ou [ToArray](https://learn.microsoft.com/fr-fr/dotnet/api/system.linq.enumerable.toarray).

C#Copier

```
List<int> numQuery2 =
    (from num in numbers
     where (num % 2) == 0
     select num).ToList();

// or like this:
// numQuery3 is still an int[]

var numQuery3 =
    (from num in numbers
     where (num % 2) == 0
     select num).ToArray();
```

Vous pouvez également forcer l’exécution en plaçant la boucle `foreach` immédiatement après l’expression de requête. Toutefois, en appelant `ToList` ou `ToArray`, vous mettez également en cache toutes les données dans un même objet de collection.