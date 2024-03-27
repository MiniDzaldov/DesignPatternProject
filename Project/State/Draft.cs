using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.FolderItem;

namespace Project.State;

public class Draft : IState
{
    public void ChangeState(SystemFile file)
    {
        file.SetState(new Staged());
    }

}
