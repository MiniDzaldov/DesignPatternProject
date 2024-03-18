using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project;

public class MyFile : ISystemFile
{
    private IState state;
    public MyFile()
    {
        state = new Draft();
    }
    public void SetState(IState state)
    {
        this.state = state;
    }

    public void Commit()
    {
        throw new NotImplementedException();
    }

    public void Merge()
    {
        throw new NotImplementedException();
    }
    
}
