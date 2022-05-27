using static System.Console;

class Program
{

    static void Demo2()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Diego";
        p1.Idade = 30;
        p1.Documento = "1234";

        Pessoa p2 = p1.Clone();



        TrocarNome(p1, "Jose Cuervo");

        WriteLine($@"
            O nome de p1 é : {p1.Nome}
            O nome de p2 é : {p2.Nome}
        ");
    }

    static void Demo1()
    {
        int a = 2;
        a = Adicionar20(a);
        WriteLine($"O valor da variavel a é {a}");
    }

    static int Adicionar20(int a)
    {
        return a + 20;
    }

    static void TrocarNome(Pessoa p1, string nomeNovo){
        p1.Nome = nomeNovo;        
    }

    static StructPessoa TrocarNome(StructPessoa p1, string nomeNovo){
        p1.Nome = nomeNovo;
        return p1;
    }
    

    public static void Main(){
        StructPessoa p1 = new StructPessoa()
        {
            Documento = "1234",
            Idade = 30,
            Nome = "Diego"
        };

        var p2 = p1;

        p1 = TrocarNome(p1, "João");

        WriteLine($@"
            O nome de p1 é : {p1.Nome}
            O nome de p2 é : {p2.Nome}
        ");


        // StructPessoa p = default;                        
        // p.Documento = "1234",
        // p.Idade = 30,
        // p.Nome = "Diego"
        
    }
}