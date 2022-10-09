using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveController : MonoBehaviour
{
    LineController _lineController;
    private void Start()
    {
        _lineController = GetComponent<LineController>();
    }

    public void Save(int currentLineNum/*, int bitFlag*/)
    {
        Savedata savedata = new Savedata(currentLineNum, 0);
        savedata.LineNum = _lineController.LineNum;

        // Json‚ÉƒVƒŠƒAƒ‹‰»
        string json = JsonUtility.ToJson(savedata);
        // —]—T‚ª‚ ‚ê‚ÎˆÃ†‰»‚µ‚Ä‚İ‚½‚¢
        Debug.Log(json);

        // •Û‘¶
        PlayerPrefs.SetString("SaveData", json);
    }
}
