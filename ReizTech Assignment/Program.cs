using ReizTech_Assignment;

bool exit = false;
int selection;


string[] menuVariants = new string[]
{
    "Task1",
    "Task3",
    "exit"
};

selection = Utility.getStringFromArray(menuVariants, "please select : ");

switch (selection)
{
    case 0: Task1();
        break;
    case 1: Task3();
        break;
    default: exit = true; break;

}


//Task 1
static void Task1()
{
    Console.WriteLine("please enter hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.WriteLine("please enter minutes: ");
    int minutes = int.Parse(Console.ReadLine());
    Task_1.Angle(hours, minutes);
}

//Task 3

static void Task3()
{
    BinaryTree tree = new BinaryTree();

    tree.root = new Node(1);
    tree.root.left = new Node(2);
    tree.root.right = new Node(3);
    tree.root.left.left = new Node(4);
    tree.root.left.right = new Node(5);
    tree.root.left.left.left = new Node(6);
    tree.root.left.left.left.left = new Node(7);

    Console.WriteLine("Depth is: "
                      + tree.maxDepth(tree.root));
}

