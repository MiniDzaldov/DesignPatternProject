using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.FolderItem;

namespace Project.State;

public interface IState
{
    public void ChangeState(SystemFile file);
}
