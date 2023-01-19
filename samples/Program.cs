using OkoloIt.Collections;
using OkoloIt.Collections.Generic;

#region Functions

static void ShowTreeInConsole(ITreeNode tree, int offset)
{
    Console.WriteLine($"{new string(' ', offset)}{tree.GetData()}");
    offset += 2;

    foreach (ITreeNode node in tree) {
        if (node.IsLeaf == false) {
            ShowTreeInConsole(node, offset);
            continue;
        }

        Console.WriteLine($"{new string(' ', offset)}{node.GetData()}");
    }
}

#endregion Functions

#region Script

TreeNode<string> tree = new("OkoloIt.Collections.sln");

TreeNode<string> node1 = new("OkoloIt.Collections.csproj", tree);

node1.AddNode(new TreeNode<string>("ITreeNode.cs", node1));
node1.AddNode(new TreeNode<string>("TreeNode.cs", node1));
node1.AddNode(new TreeNode<string>("ITreeNode.cs", node1));

TreeNode<string> node2 = new("OkoloIt.Collections.Example.csproj", tree);

node2.AddNode(new TreeNode<string>("Program.cs", node2));

tree.AddNode(node1);
tree.AddNode(node2);

ShowTreeInConsole(tree, 0);

#endregion Script