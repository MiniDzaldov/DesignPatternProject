using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project;

internal interface IMemento
{
    public IMemento Commit(MyFile file);
}
