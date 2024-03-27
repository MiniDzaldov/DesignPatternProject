using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.State;

namespace Project.FolderItem;

public abstract class SystemFile
{
    public abstract string Name { get; set; }
    public abstract IState State { get; set; }

    public SystemFile(string name)
    {
        Name = name;
        State = new Draft();
    }
    public void SetState(IState state)
    {
        State = state;
    }
    public abstract SystemFile Merge(SystemFile systemFile);
    public SystemFile Commit()
    {
        if (State.GetType() != typeof(Staged))
        {
            Console.WriteLine("cannot commit - not staged");
        }
        else
        {
            State.ChangeState(this);
        }
        return this;
    }
    public abstract SystemFile Undo();
    public SystemFile Add()
    {
        if (State.GetType() != typeof(Draft))
        {
            Console.WriteLine("cannot add - not draft");
        }
        else
        {
            State.ChangeState(this);
        }
        return this;
    }



}
