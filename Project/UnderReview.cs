﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project;

public class UnderReview : IState
{
    public void ChangeState(MyFile file)
    {
        file.SetState(new ReadyToMerge());
    }
}
