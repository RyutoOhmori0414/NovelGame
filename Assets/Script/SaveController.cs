using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveController : MonoBehaviour
{
    void Save()
    {
        int _currentLineNum = default;
        
        Savedata _savedata = new Savedata(_currentLineNum, Savedata.BitFlag.Flag1);
    }
}
