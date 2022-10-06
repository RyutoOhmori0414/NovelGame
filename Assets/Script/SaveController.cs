using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveController : MonoBehaviour
{

    public void Save(int currentLineNum/*, int bitFlag*/)
    {
        Savedata _savedata = new Savedata(currentLineNum, 0);

        // Json‚ÉƒVƒŠƒAƒ‹‰»
        string json = JsonUtility.ToJson(_savedata);
        // —]—T‚ª‚ ‚ê‚ÎˆÃ†‰»‚µ‚Ä‚İ‚½‚¢
        Debug.Log(json);

        // •Û‘¶
        PlayerPrefs.SetString("SaveData", json);
    }
}
