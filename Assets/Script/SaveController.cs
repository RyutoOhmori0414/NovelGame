using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveController : MonoBehaviour
{

    public void Save(int currentLineNum/*, int bitFlag*/)
    {
        Savedata _savedata = new Savedata(currentLineNum, 0);

        // Jsonにシリアル化
        string json = JsonUtility.ToJson(_savedata);
        // 余裕があれば暗号化してみたい
        Debug.Log(json);

        // 保存
        PlayerPrefs.SetString("SaveData", json);
    }
}
