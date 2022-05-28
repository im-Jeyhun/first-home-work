// See https://aka.ms/new-console-template for more information
// Total budget 20000000000 , 20% for Ministry of Defend , 10% for To the Ministry of High Technologies 

long allBudget = 20000000000;

long modBudget = allBudget * 20 / 100;

long mohtBudget = allBudget * 10 / 100;

long currentBudget = allBudget - modBudget - mohtBudget;



string textAllBudget = "Budce :";
Console.WriteLine(textAllBudget);
Console.WriteLine(allBudget);

string textmodBudget = "Mudafie Nazirliyine :";
Console.WriteLine(textmodBudget);
Console.WriteLine(modBudget);

string textmohtBudget  = "Yuksek Texnologiyalar Nazirliyine :";
Console.WriteLine(textmohtBudget);
Console.WriteLine(mohtBudget);

string textcurrentBudget = "Yerde qalan budce :";
Console.WriteLine(textcurrentBudget);
Console.WriteLine(currentBudget);




