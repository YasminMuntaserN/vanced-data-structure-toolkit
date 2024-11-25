using AVL_Tree;

class Program
{
    static void Main(string[] args)
    {
        AVLTree tree = new AVLTree();


        // Inserting values
        int[] values = { 10, 20, 30, 40, 50, 25 };
        foreach (var value in values)
        {
            tree.Insert(value);
        }

        tree.PrintTree();

        Console.WriteLine("-----------------------------------------------");
        tree.Delete(40);
        tree.PrintTree();
        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine($"Find 20 :{tree.Search(20)}");
        Console.WriteLine($"Find 80 :{tree.Search(80)}");

    }
}
