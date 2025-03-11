// See https://aka.ms/new-console-template for more information


16. *** Словник ***
// - Створити програму, яку буде зберігати словники різними мовами 
// - дозволяти користувачеві знаходити переклад потрібного слова або фрази.
// - Створення, редагування, видалення словників
// - Додавання, редагування, видалення слів в словнику та їх перекладів
// - Пошук слів та перекладів
// - Зберігати словники в файл

Console.WriteLine("Hello, Dictionary!");
Console.WriteLine("-------- menu: ---------");
Console.WriteLine("1. Save Vocabulary");


        Console.WriteLine("\tMENU:");
Console.WriteLine("\t1. Add new translate ");
Console.WriteLine("\t2. Save to file");
Console.WriteLine("\t3. Load from file");
Console.WriteLine("\t4. Show all translates");
Console.WriteLine("\t5. Delete translate");


public class Dictionary
{
    public string Name { get; set; }
    public string Category { get; set; }
    public int Quantity { get; set; }

}

class Translate
