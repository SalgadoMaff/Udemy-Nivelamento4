using System.ComponentModel;
using System.Globalization;

Console.WriteLine("1 : Senha Correta?");
Console.WriteLine("2 : Coordenadas");
Console.WriteLine("3 : Posto de gasolina");
Console.Write("\nOpção: ");
int op = int.Parse(Console.ReadLine());
Console.Clear();
switch (op) {
    case 1:
        bool continua = true;
        while (continua) {
            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();
            Console.WriteLine();
            if (senha == "2002") {
                Console.WriteLine("Acesso Permitido");
                continua = false;
            }
            else {
                Console.WriteLine("\nSenha Inválida");
            }
        }
        break;
    case 2:
        bool Cont = true;
        while (Cont) {
            Console.Write("Digite as coordenadas: ");
            string[] coords = Console.ReadLine().Split(' ');
            int x = int.Parse(coords[0]);
            int y = int.Parse(coords[1]);
            if (x == 0 || y == 0) {
                Cont = false;
            }
            else if(x>0 && y>0) {
                Console.WriteLine("primeiro");

            }
            else if(x<0 && y>0){
                Console.WriteLine("segundo");
            }
            else if(x<0 && y < 0) {
                Console.WriteLine("terceiro");
            }
            else if (x>0 && y < 0) {
                Console.WriteLine("quarta");
            }
            else {
                Cont=false;
            }
        }       
        break;
    case 3:
        int alcool = 0;
        int gas = 0;
        int diesel = 0;
        int opcao = 0;
        while(opcao != 4) {
            Console.Clear();
            Console.WriteLine("1: Alcool");
            Console.WriteLine("2: Gasolina");
            Console.WriteLine("3: Diesel");
            Console.WriteLine("4: FIM");
            Console.Write("Digite opção: ");
            opcao = int.Parse(Console.ReadLine());
            if (opcao==1) {
                alcool++;
            }else if (opcao == 2) {
                gas++;
            }else if(opcao== 3) {
                diesel++;
            }
        }
        Console.Clear();
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {alcool}");
        Console.WriteLine($"Gasolina: {gas}");
        Console.WriteLine($"Diesel: {diesel}");
        break;

    default:
        break;
}

