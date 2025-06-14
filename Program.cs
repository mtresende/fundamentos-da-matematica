using System;

class Program
{

    //Distância entre pontos:

    static void DistanciaEntrePontos()
    {
        //Declaração das váriaveis
        int xPonto1, yPonto1, xPonto2, yPonto2;

        Console.WriteLine("Digite a coordenada X do ponto 1:");
            xPonto1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a coordenada Y do ponto 1:");
            yPonto1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a coordenada X do ponto 2:");
            xPonto2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a coordenada Y do ponto 2:");
            yPonto2 = int.Parse(Console.ReadLine());

        //Fórmula para calcular a distância entre dois pontos: d = √((xB - xA)² + (yB - yA)²)
        //Onde A se trata do Ponto 1 e B o Ponto 2

        double distancia = Math.Sqrt(Math.Pow((xPonto2 - xPonto1), 2) + Math.Pow((yPonto2 - yPonto1), 2));

        Console.WriteLine("A distância entre o ponto 1 ({0}, {1}) e o ponto 2({2}, {3}) é: {4:F2}", xPonto1, yPonto1, xPonto2, yPonto2, distancia);
    }


    public static void EqReta()
    {
        // Fórmula: y = ax + b

        Console.WriteLine("Calcule a equação de reta a partir de dois pontos");
        Console.Write("Digite o ponto 1 (x1,y1): ");
        string[] ponto1 = Console.ReadLine().Split(',');
        double x1 = double.Parse(ponto1[0]);
        double y1 = double.Parse(ponto1[1]);

        Console.Write("Digite o ponto 2 (x2, y2): ");
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

        if (b >= 0)
        {
            Console.WriteLine($"A equação da reta é: y = {a}x + {b}");
        }
        else
        {
            Console.WriteLine($"A equação da reta é: y = {a}x {b}");
        }
    }
    
     static void CalcularProdutoEscalarEVetor()
        {
            // Solicita o vetor A
            Console.WriteLine("Digite os 3 elementos do vetor A separados por espaço:");
            string[] entradaA = Console.ReadLine().Split(' ');
            int[] vetorA = new int[3];
            for (int i = 0; i < 3; i++)
            {
                vetorA[i] = int.Parse(entradaA[i]);
            }

            // Solicita o vetor B
            Console.WriteLine("Digite os 3 elementos do vetor B separados por espaço:");
            string[] entradaB = Console.ReadLine().Split(' ');
            int[] vetorB = new int[3];
            for (int i = 0; i < 3; i++)
            {
                vetorB[i] = int.Parse(entradaB[i]);
            }

            // Calcula o produto escalar
            /*
             * Produto Escalar:
             * A · B = a1 * b1 + a2 * b2 + a3 * b3
             * Resultado é um número (escalar)
             */
            int produtoEscalar = 0;
            for (int i = 0; i < 3; i++)
            {
                produtoEscalar += vetorA[i] * vetorB[i];
            }

            // Calcula o módulo dos vetores
            /*
             * Módulo (norma) de um vetor:
             * |A| = √(a1² + a2² + a3²)
             * |B| = √(b1² + b2² + b3²)
             */
            double moduloA = Math.Sqrt(vetorA[0] * vetorA[0] + vetorA[1] * vetorA[1] + vetorA[2] * vetorA[2]);
            double moduloB = Math.Sqrt(vetorB[0] * vetorB[0] + vetorB[1] * vetorB[1] + vetorB[2] * vetorB[2]);

            // Calcula o ângulo em radianos
            /*
             * Fórmula do cosseno do ângulo entre dois vetores:
             * cos(θ) = (A · B) / (|A| * |B|)
             * θ = arccos(cos(θ))
             */
            double cosseno = produtoEscalar / (moduloA * moduloB);
            double anguloRad = Math.Acos(cosseno);

            // Converte para graus
            /*
             * Conversão de radianos para graus:
             * graus = radianos * (180 / π)
             */
            double anguloGraus = anguloRad * (180.0 / Math.PI);

            // Exibe os resultados
            Console.WriteLine();
            Console.WriteLine("Resultado:");
            Console.WriteLine($"Produto Escalar: {produtoEscalar}");
            Console.WriteLine($"Ângulo entre os vetores: {anguloGraus:F2} graus");

            // Classificação com margem de tolerância por causa de precisão dos doubles
            /*
             * Se produto escalar ≈ 0 → vetores ortogonais (ângulo ≈ 90°)
             * Se ângulo ≈ 0° ou 180° → vetores paralelos
             * Caso contrário → vetores apenas oblíquos
             */
            if (Math.Abs(produtoEscalar) < 1e-6)
            {
                Console.WriteLine("Relação: Ortogonais");
            }
            else if (Math.Abs(anguloGraus) < 1e-6 || Math.Abs(anguloGraus - 180.0) < 1e-6)
            {
                Console.WriteLine("Relação: Paralelos");
            }
            else
            {
                Console.WriteLine("Relação: Apenas oblíquos");
            }
        }

    public static void Main(string[] args)
    {

        DistanciaEntrePontos();

        EqReta();

        CalcularProdutoEscalarEVetor();

    }
}
