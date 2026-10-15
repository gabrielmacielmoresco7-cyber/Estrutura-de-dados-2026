﻿using Arvores;

Console.WriteLine ("Agora com Árvores");

Tree<int> tree = new Tree<int> ();

tree.Root = new TreeNode<int> () { Data = 100};

//TreeNode<int> root = new TreeNode<int> ();
//root.Data = 100;

//tree.Root = root;

// Filhos do 100
tree.Root.Children = new List<TreeNode<int>>
{
    new TreeNode<int>() { Data = 50, Parent = tree.Root },
    new TreeNode<int>() { Data = 1, Parent = tree.Root },
    new TreeNode<int>() { Data = 150, Parent = tree.Root }
};

// Filhos do 50
tree.Root.Children[0].Children = new List<TreeNode<int>>
{
    new TreeNode<int>() { Data = 12, Parent = tree.Root.Children[0] }
};

// Filhos do 12
tree.Root.Children[0].Children[0].Children = new List<TreeNode<int>>
{
    new TreeNode<int>() { Data = 45, Parent = tree.Root.Children[0].Children[0] },
    new TreeNode<int>() { Data = 21, Parent = tree.Root.Children[0].Children[0] }
};

// Filhos do 21
tree.Root.Children[0].Children[0].Children[1].Children = new List<TreeNode<int>>
{
    new TreeNode<int>() { Data = 6, Parent = tree.Root.Children[0].Children[0].Children[1] }
};

// Filhos do 1
tree.Root.Children[1].Children = new List<TreeNode<int>>
{
    new TreeNode<int>() { Data = 70, Parent = tree.Root.Children[1] },
    new TreeNode<int>() { Data = 61, Parent = tree.Root.Children[1] }
};

// Filhos do 150
tree.Root.Children[2].Children = new List<TreeNode<int>>
{
    new TreeNode<int>() { Data = 30, Parent = tree.Root.Children[2] },
    new TreeNode<int>() { Data = 5, Parent = tree.Root.Children[2] },
    new TreeNode<int>() { Data = 11, Parent = tree.Root.Children[2] }
};

// Filhos do 30
tree.Root.Children[2].Children[0].Children = new List<TreeNode<int>>
{
    new TreeNode<int>() { Data = 96, Parent = tree.Root.Children[2].Children[0] },
    new TreeNode<int>() { Data = 9, Parent = tree.Root.Children[2].Children[0] }
};

Console.WriteLine(tree.Root.Data);
Console.WriteLine(tree.Root.Children[0].Data);
Console.WriteLine(tree.Root.Children[1].Data);
Console.WriteLine(tree.Root.Children[2].Data);
