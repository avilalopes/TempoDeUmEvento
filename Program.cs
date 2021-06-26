using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;

            Console.WriteLine("Dê um espaço e informe o dia do mês que o evento iniciou (exemplo: 5): ");
            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            Console.WriteLine("Informe o horário (hh : mm : ss) do dia que o evento iniciou: ");
            string[] dadosMomentoInicio = Console.ReadLine().Split();
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[4]);

            Console.WriteLine("Dê um espaço e informe o dia do mês que o evento encerrou (exemplo: 5): ");
            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            Console.WriteLine("Informe o horário (hh : mm : ss) do dia que o evento encerrou: ");
            string[] dadosMomentoTermino = Console.ReadLine().Split();
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[2]);
            segundoMomentoTerminio = Convert.ToInt32(dadosMomentoTermino[4]);

            int transformaSegundosInicio = (diaInicio*86400 + horaMomentoInicio*3600 + minutoMomentoInicio*60 + segundoMomentoInicio);
            int transformaSegundosTermino = (diaTermino*86400 + horaMomentoTermino*3600 + minutoMomentoTermino*60 +segundoMomentoTerminio);
            int somaTotalSegundos = (transformaSegundosTermino - transformaSegundosInicio); 

            int W =  (somaTotalSegundos/86400);
            int restW = (somaTotalSegundos%86400);
            Console.WriteLine();
            Console.WriteLine("{0} dia(s)", W); 

            int X =  (restW/3600);
            int restX = (restW%3600);
            Console.WriteLine("{0} hora(s)", X);

            int Y =  (restX/60);
            int restY = (restX%60);
            Console.WriteLine("{0} minuto(s)", Y);

            int Z =  (restY);
            Console.WriteLine("{0} segundo(s)", Z);                           
    }

}
