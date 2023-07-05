using System;

public class Jogador
{
    public int energia = 100;
    public bool vivo = true;
    public string is_vivo = " ";
    public string nome;

     public Jogador()
    {
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }

    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }

    public Jogador(string n, int e)
    {
        energia = e;
        vivo = true;
        nome = n;
    }

     public Jogador(string n, int e, bool v)
    {
        energia = e;
        vivo = v;
        nome = n;
    }

    public void Info()
    {
        Console.WriteLine("Nome Jogador...:{0}", nome);
        Console.WriteLine("Energia Jogador:{0}", energia);
        Console.WriteLine("Estado Jogador.:{0}\n", vivo);
    }

     public void Info(string n)
    {
        Console.WriteLine("Nome Jogador...:{0}", nome);
        Console.WriteLine("Energia Jogador:{0}", energia);
        Console.WriteLine("Estado Jogador.:{0}\n", vivo);
    }


    public String esta_vivo(int energia)
    {
        vivo = energia <= 0 ? vivo = false : vivo = true;
        is_vivo = vivo == true ? "Vivo" : "Morto";
        return is_vivo;
    }

}

public class inimigo
{
    public int dano = 50;
}

class aula28 { 
 
    static void Main()
    {
        //string nome1;

        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("clementina");
        Jogador j3 = new Jogador("clovis", 100);
        Jogador j4 = new Jogador("Jaire", 30, true);
        Jogador j5 = new Jogador("BenegundesFirno", 0, false);

        j1.Info();
        j2.Info();
        j3.Info();
        j4.Info();

    /*inimigo inimigo = new inimigo();

    Console.WriteLine("O nome do Jogador 1 é {0}", j1.nome);
    Console.WriteLine("O nome do Jogador 2 é {0}", j2.nome);
    
    j1.energia = 50;
    Console.WriteLine("A energia de {0} é: {1}",j1.nome, j1.energia);
    Console.WriteLine("A energia do Jogador 2 é: {0}", j2.energia);

    Console.WriteLine("O inimigo causa {0} de dano no jogador 1 e 2", inimigo.dano);
    j1.energia -= inimigo.dano;
    j2.energia -= inimigo.dano;

    Console.WriteLine("A energia do Jogador 1 é: {0}", j1.energia);
    Console.WriteLine("A energia do Jogador 2 é: {0}", j2.energia);

    Console.WriteLine("Jogador 1 está {0} e Jogador 2 está {1}", j1.esta_vivo(j1.energia), j2.esta_vivo(j2.energia));*/
    }
}
