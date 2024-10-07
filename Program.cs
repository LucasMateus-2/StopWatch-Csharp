// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
      Menu(); 
    }
    
    static void Menu()
    {
      int time;
      string data;
      char type;


      Console.Clear();
      Console.WriteLine("Digite sua opção de StopWatch(segundos ou minutos)");
      Console.WriteLine("---------------");
      Console.WriteLine("S = Segundos => 10s = 10 segundos");
      Console.WriteLine("M = Minutos => 10m = 10 minutos");
      Console.WriteLine("0 = Sair");
      Console.Write("Quanto tempo deseja contar:");

      data = Console.ReadLine()
                            .ToLower();
      
      if ( data != "0" )
      {
          type = char.Parse(data.Substring(data.Length -1 ,1));
          time = int.Parse(data.Substring(0,data.Length -1));
      }
      else
      {
          time = 0;
          type ='s';
      }
      

      int multplier =1;

      if (type == 'm' )
      {
        multplier = 60;
        
      }
      if (time == 0)
      {
        Console.WriteLine("Saindo do StopWatch , obrigado por usar");
        System.Environment.Exit(0);
      }

      Start(time*multplier);

    }
    static void Start(int time)
    {
        Console.Clear();
        int currentTime=0;

        while (currentTime != time)
        {
          Console.Clear();
          currentTime++;
          
          Console.Write(currentTime);
          
          Thread.Sleep(1000);
          
        }
        
        Console.Clear();
        Console.WriteLine("StopWatch finalizado!!");
        Thread.Sleep(1000);
        Menu();
    }



}

