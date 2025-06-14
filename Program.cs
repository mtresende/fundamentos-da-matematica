using System;

class Program {
    public static void EqReta () {
        // Fórmula: y = ax + b

        Console.WriteLine ("Caucule a equação de reta a partir de dois pontos");
        Console.Write ("Digite o ponto 1 (x1,y1): ");
        string[] ponto1 = Console.ReadLine().Split(',');
        double x1 = double.Parse(ponto1[0]);
        double y1 = double.Parse(ponto1[1]);

        Console.Write ("Digite o ponto 2 (x2, y2): ");
        string[] ponto2 = Console.ReadLine().Split(',');
        double x2 = double.Parse(ponto2[0]);
        double y2 = double.Parse(ponto2[1]);

        /*
            Encontrar o coeficiente angular (a)
            y2 - y1
            -------
            x2 - x1
        */
        double a = (y2 - y1) / (x2 - x1);

        /*
            Encontrar o coeficiente linear (b)
            y1 = ax1 + b
            b = y1 - ax1
        */
        double b = y1 - a * x1;

        if (b >= 0) {
            Console.WriteLine ($"A equação da reta é: y = {a}x + {b}");
        } else {
            Console.WriteLine ($"A equação da reta é: y = {a}x {b}");
        }
    }

    public static void Main (string[] args) {
        EqReta();
    }
}
