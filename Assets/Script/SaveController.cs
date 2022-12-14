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

        // Jsonにシリアル化
        string json = JsonUtility.ToJson(savedata);
        // 余裕があれば暗号化してみたい
        Debug.Log(json);

        // 保存
        PlayerPrefs.SetString("SaveData", json);
    }
}
