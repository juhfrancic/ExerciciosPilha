// See https://aka.ms/new-console-template for more information
using TarefaPilha;

EditorTexto editor = new EditorTexto();

int opcao = 0;

do
{
    Console.WriteLine("Escolha uma opcao: ");
    Console.WriteLine("------------------");
    Console.WriteLine("1.Digitar novo texto");
    Console.WriteLine("2.Desfazer última ação");
    Console.WriteLine("3.Mostrar histórico");
    Console.WriteLine("4.Sair");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite o texto");
            string texto = Console.ReadLine();
            editor.Digitar(texto);
            editor.Digitar(texto);
            break;
        case 2:
            editor.Desfazer();
            break;
        case 3:
            editor.ExibirHistorico();
            break;
        default:
            Console.WriteLine("Saindo do programa...");
            break;
    }
} while (opcao != 4);
