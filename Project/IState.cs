using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project;

public interface IState
{
    public void ChangeState(MyFile file);
}
