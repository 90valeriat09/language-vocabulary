// 16. *** Словник ***
// - Створити програму, яка буде зберігати словники різними мовами 
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

// Dictionary language = new();

while (true)

{

    Console.Write("Your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    {
        Console.Write("Your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
     {

            Console.Write("Enter dictionary name: ");
            dictionary.Name = Console.ReadLine();
            Console.Write("Enter category: ");
            dictionary.Category = Console.ReadLine();
            Console.Write("Enter category price: ");
            dictionary.Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter dictionary quantity: ");


            Console.WriteLine("------- Product ---------");
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Category: {product.Category}");
            Console.WriteLine($"Price: {product.Price}");
            Console.WriteLine($"Quantity: {product.Quantity}");
            Console.WriteLine($"Manufacturer: {product.Manufacturer}");
            break;
        }
    }


public class Dictionary
{
    public string Name { get; set; }
    public string Category { get; set; }
    public int Quantity { get; set; }

}


