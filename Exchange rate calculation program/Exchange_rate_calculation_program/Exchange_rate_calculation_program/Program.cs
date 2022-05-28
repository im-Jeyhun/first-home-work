// See https://aka.ms/new-console-template for more information
using System;

int sumAzn = 10000;
float sumDollar = 0.59f;
float sumEuro = 0.55f;
float sumRub = 39.14f;

float totalDollar = sumAzn * sumDollar;
float totalEuro = sumAzn * sumEuro;
float totalRub = sumAzn * sumRub;

string textsumAzn = "Mebleg (AZN) : ";
Console.WriteLine(textsumAzn);
Console.WriteLine(sumAzn);

string textsumDollar = "ABŞ dollari (USD) :";
Console.WriteLine(textsumDollar);
Console.WriteLine(totalDollar);

string textsumEuro = "Avro (EUR) :";
Console.WriteLine(textsumEuro);
Console.WriteLine(totalEuro);

string textsumRub = "Rusiya rublu (RUB) :";
Console.WriteLine(textsumRub);
Console.WriteLine(totalRub);

Console.ReadLine();
