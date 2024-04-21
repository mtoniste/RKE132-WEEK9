string folderPath = @"C:\Users\PC\Desktop\Julia aine\Week5\Week9Lists";
string filename = "shoppingList.txt";
string filePath = Path.Combine(folderPath, filename);
List<string> myShoppingList = new List<string>();

if (File.Exists(filePath))
{
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {filename} has been created.");
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}

static List<string> GetItemsFromUser()
{
    List<string> userlist = new List<string>();

    while (true)
    {
        Console.WriteLine("Choose an action (add/exit):");
        string userChoice = Console.ReadLine();

        if (userChoice == "add")
        {
            Console.WriteLine("Enter an item:");
            string userItem = Console.ReadLine();
            userlist.Add(userItem);
        }
        else
        {
            Console.WriteLine("Bye!");
            break;
        }
    }

    return userlist;
}

static void ShopItemsFromList(List<string> somelist)
{
    Console.Clear();

    int listLength = somelist.Count;
    Console.WriteLine($"You have added {listLength} items to your shopping list");

    int i = 1;
    foreach (string item in somelist)
    {
        Console.WriteLine($"{i}.{item}");
        i++;
    }
}

