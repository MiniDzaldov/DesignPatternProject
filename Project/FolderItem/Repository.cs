using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.FolderItem;

public class Repository
{
    public string RepoName { get; set; }
    private Dictionary<string, Branch> branches { get; set; }
    public Repository(string name)
    {
        RepoName = name;
        branches = new Dictionary<string, Branch>
        {
            { "main", new Branch("main") }
        };
    }
    public void DeleteBranch(string name)
    {
        branches.Remove(name);
    }
    public Branch CreateBranch(string branchToCopy, string newBranch)
    {
        Branch b = branches[branchToCopy].Copy(newBranch);
        branches.Add(b.Name, b);
        return b;
    }
}
