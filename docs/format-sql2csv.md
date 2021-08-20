# SQL to CSV file format representation
A CSV representation of a SQL database was neccesary in order to have a practical representation of all the information retrieved and have constant updates of the data for both local and remote databases.

## File format
All column names and data werer represented in a csv format
```csv
columnName1,columnName2,columnName3
data1,data2,data3
...
```
And in order to save the table name, the `-` character was used at the beginning and end of it, i.e:
```csv
-tableName-
```
A real example of this way of representing SQL files in a CSV format is presented here below:
```csv
-clase-
ID,Nombre
1,'Arachnida'
2,'Bivalvia'
3,'Clitellata'
4,'Entognatha'
5,'Gasteropoda'
6,'Nematomorpha'
7,'Insecta'
8,'Malacostraca'
9,'Ostracoda'
10,'Rhabditophora'
-temporada-
ID,Responsable,Temporada,IdSitio
1,'Eduardo MM','2021-08-01 00:00:00',1
```
Where _clase_ and _temporada_ are tables and all the data below them is column names (first next line) and column data (next lines).