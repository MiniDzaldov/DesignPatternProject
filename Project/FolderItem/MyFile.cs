using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.State;

namespace Project.FolderItem;

public class MyFile : SystemFile
{
    private IState state;
    private string text;
    private string name;

    public override string Name { get; set; }
    public override IState State { get; set; }

    public MyFile(string text, string name) : base(name)
    {
        state = new Draft();
        this.text = text;
        this.name = name;
    }
    public void SetState(IState state)
    {
        this.state = state;
    }

    public override SystemFile Merge(SystemFile systemFile)
    {
        name = ((MyFile)systemFile).name;
        text = ((MyFile)systemFile).text;
        return this;
    }

    public override SystemFile Undo()
    {
        throw new NotImplementedException();
    }




}
