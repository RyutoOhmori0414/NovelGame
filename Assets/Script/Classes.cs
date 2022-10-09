using System;

[Serializable]
public class Savedata
{
    public int Chapter;
    public int LineNum;
    public int Flag;
    

    public Savedata(int lineNum, int flag)
    {
        this.LineNum = lineNum;
        this.Flag = flag;
    }
}
