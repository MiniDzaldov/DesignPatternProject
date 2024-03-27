using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.FolderItem;

namespace Project;

public class Memento : IMemento
{
    public IMemento Commit(SystemFile file)
    {
        throw new NotImplementedException();
    }
}
