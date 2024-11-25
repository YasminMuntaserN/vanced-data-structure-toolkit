using General_Tree;

class Program
{
    static void Main(string[] args)
    {
        var companyTree = new Tree<string>("CEO");
        var finance = new TreeNode<string>("CFO");
        var tech = new TreeNode<string>("CTO");
        var marketing = new TreeNode<string>("CMO");


        companyTree.Root.AddChild(finance);
        companyTree.Root.AddChild(tech);
        companyTree.Root.AddChild(marketing);


        finance.AddChild(new TreeNode<string>("Accountant"));
        tech.AddChild(new TreeNode<string>("Developer"));
        tech.AddChild(new TreeNode<string>("UX Designer"));
        marketing.AddChild(new TreeNode<string>("Social Media Manager"));


        companyTree.PrintTreeElements();

       if( companyTree.Find("UX Designer") != null)
            Console.WriteLine("Found"); 
        else
            Console.WriteLine("Not Found");

            Console.ReadKey();
    }



}
