﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project;

public class Memento : IMemento
{
    IMemento IMemento.Commit(MyFile file)
    {
        throw new NotImplementedException();
    }
}
