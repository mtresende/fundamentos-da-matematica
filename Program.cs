using System;

class Program {

    //Distância entre pontos:

    static void DistanciaEntrePontos(int xPonto1, int yPonto1, int xPonto2, int yPonto2)
    {
        //Fórmula para calcular a distância entre dois pontos: d = √((xB - xA)² + (yB - yA)²)
        //Onde A se trata do Ponto 1 e B o Ponto 2
        
        double distancia = Math.Sqrt(Math.Pow((xPonto2 - xPonto1), 2) + Math.Pow((yPonto2 - yPonto1), 2));

        Console.WriteLine("A distância entre o ponto 1 ({0}, {1}) e o ponto 2({2}, {3}) é: {4:F2}", xPonto1, yPonto1, xPonto2, yPonto2, distancia);
    }


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

        Console.WriteLine("Digite a coordenada X do ponto 1:");
            int xPonto1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a coordenada Y do ponto 1:");
            int yPonto1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a coordenada X do ponto 2:");
            int xPonto2 = int.Parse(Console.ReadLine());        
        Console.WriteLine("Digite a coordenada Y do ponto 2:");
            int yPonto2 = int.Parse(Console.ReadLine());

        DistanciaEntrePontos(xPonto1, yPonto1, xPonto2, yPonto2);

        EqReta();
    }
}
