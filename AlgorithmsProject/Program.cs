using System.Numerics;

Console.WriteLine("Podaj a, b, c, d w takiej kolejności oddzielone przecinkiem:");
string input = Console.ReadLine();

string[] inputSplit = input.Split(',');
double[] inputArray = new double[inputSplit.Length];
for (int i = 0; i < inputSplit.Length; i++)
{
    inputArray[i] = Convert.ToDouble(inputSplit[i]);
}

double a = inputArray[0];
double b = inputArray[1];
double c = inputArray[2];
double d = inputArray[3];

double f = ((3.0 * c / a) - ((b * b) / (a * a))) / 3.0;
double g = ((2.0 * Math.Pow(b, 3) / Math.Pow(a, 3)) - (9.0 * b * c / (a * a)) + (27.0 * d / a)) / 27.0;
double h = (Math.Pow(g, 2) / 4.0) + (Math.Pow(f, 3) / 27.0);

Complex[] roots = new Complex[3];

if (h > 0)
{
    double R = -(g / 2.0) + Math.Sqrt(h);
    double S = Math.Cbrt(R);
    double T = -(g / 2.0) - Math.Sqrt(h);
    double U = Math.Cbrt(T);

    roots[0] = new Complex((S + U) - (b / (3.0 * a)), 0);
    roots[1] = new Complex(-(S + U) / 2.0 - (b / (3.0 * a)), (S - U) * Math.Sqrt(3) / 2.0);
    roots[2] = new Complex(-(S + U) / 2.0 - (b / (3.0 * a)), -(S - U) * Math.Sqrt(3) / 2.0);
}
else if (h == 0)
{
    double R = -(g / 2.0);
    double S = Math.Cbrt(R);

    roots[0] = new Complex(2.0 * S - (b / (3.0 * a)), 0);
    roots[1] = new Complex(-S - (b / (3.0 * a)), 0);
    roots[2] = new Complex(-S - (b / (3.0 * a)), 0);
}
else
{
    double i = Math.Sqrt((Math.Pow(g, 2) / 4.0) - h);
    double j = Math.Cbrt(i);
    double k = Math.Acos(-(g / (2.0 * i)));
    double L = -j;
    double M = Math.Cos(k / 3.0);
    double N = Math.Sqrt(3) * Math.Sin(k / 3.0);
    double P = -(b / (3.0 * a));

    roots[0] = new Complex(2.0 * j * Math.Cos(k / 3.0) - (b / (3.0 * a)), 0);
    roots[1] = new Complex(L * (M + N) + P, 0);
    roots[2] = new Complex(L * (M - N) + P, 0);
}

Console.WriteLine("Rozwiązania równania:");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"x{i + 1} = {roots[i]}");
}

Console.WriteLine("Naciśnij ENTER, aby zakończyć");
Console.ReadLine();
