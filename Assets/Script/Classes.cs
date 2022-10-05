using System;

[Serializable]
public class Savedata
{
    public int LineNum;
    public BitFlag Flag;
    
    public enum BitFlag
    {
        Flag1 = 1,
        Flag2 = 2,
        Flag3 = 4,
        Flag4 = 8,
        Flag5 = 16
    }

    public Savedata(int lineNum, BitFlag flag)
    {
        this.LineNum = lineNum;
        this.Flag = flag;
    }
}
