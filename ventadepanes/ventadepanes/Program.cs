Console.WriteLine("Ingrese precio de fresco");
string numfresco = Console.ReadLine();

Console.WriteLine("Ingrese cantidad de fresco");
string cantfresco = Console.ReadLine();


Console.WriteLine("Ingrese precio de panes");
string numpanes = Console.ReadLine();

Console.WriteLine("Ingrese cantidad de panes");
string cantpanes = Console.ReadLine();


float numfrescof = float.Parse(numfresco);
float cantfrescof = float.Parse(cantfresco);

float numpanesf = float.Parse(numpanes);
float cantpanesf = float.Parse(cantpanes);


float resultadofresco = numfrescof * cantfrescof;
float resultadopanes = numpanesf * cantpanesf;

float total = resultadofresco + resultadopanes;
Console.WriteLine("Total a pagar");

Console.WriteLine("De fresco: "+resultadofresco);
Console.WriteLine("De panes: "+resultadopanes);
Console.WriteLine(total);