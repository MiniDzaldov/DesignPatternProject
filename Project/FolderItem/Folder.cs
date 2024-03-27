using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.State;

namespace Project.FolderItem;

public class Folder : SystemFile
{
    private string name;
    Dictionary<string, SystemFile> filesInFolder;

    public Folder(string name) : base(name)
    {
        State = new Draft();
    }

    public override string Name { get; set; }
    public override IState State { get; set; }

    public SystemFile AddItem(SystemFile systemFile)
    {
        filesInFolder.Add(systemFile.Name, systemFile);
        return this;
    }

    public override SystemFile Merge(SystemFile systemFile)
    {
        throw new NotImplementedException();
    }

    public SystemFile RemoveItem(SystemFile systemFile)
    {
        filesInFolder.Remove(systemFile.Name);
        return this;
    }




    /*    public override SystemFile Merge(SystemFile systemFile)
        {
            foreach (SystemFile file in ((Folder)systemFile).filesInFolder)
            {
                if (filesInFolder.Contains(file))
                {
                    *//* SystemFile f = filesInFolder.Find(x => x.name == file.name);
                     this = f;
                 }*//*
                }
                return this;
            }
        }*/


    public override SystemFile Undo()
    {
        throw new NotImplementedException();
    }
}
