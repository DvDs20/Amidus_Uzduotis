# Amidus_Uzduotis

Kad veiktų duomenų bazė, reikia pakeisti DB failo link'ą pagal savo lokalaus kompiuterio adresą.<br>
Klasę galima rasti čia -> Models/ApplicationDbContext.cs
> Pakeisti kodo eilutę čia:<br>
> `optionsBuilder.UseSqlite(@"Data Source=C:\Users\Deividas\source\repos\Amidus_Uzduotis\DB\ProgrammingLanguageDB.db");`
