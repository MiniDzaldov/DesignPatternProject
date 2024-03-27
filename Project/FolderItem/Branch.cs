using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.State;

namespace Project.FolderItem;

public class Branch : SystemFile
{


    public override string Name { get; set; }
    public override IState State { get; set; }

    Dictionary<string, SystemFile> files;

    public Branch(string name) : base(name)
    {
        Name = name;
    }
    public Branch Copy(string newBranchName)
    {
        Branch b = new Branch(newBranchName)
        {
            State = State,
            files = new()
        };
        foreach (var file in files)
        {
            b.files.Add(file.Key, file.Value);
        }
        return b;
    }

    public SystemFile AddItem(SystemFile systemFile)
    {
        files.Add(systemFile.Name, systemFile);
        return this;
    }
    public SystemFile RemoveItem(SystemFile systemFile)
    {
        files.Remove(systemFile.Name);
        return this;
    }
    public override SystemFile Merge(SystemFile systemFile)
    {
        throw new NotImplementedException();
    }
    public override SystemFile Undo()
    {
        throw new NotImplementedException();
    }


}
