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

        // Json�ɃV���A����
        string json = JsonUtility.ToJson(savedata);
        // �]�T������ΈÍ������Ă݂���
        Debug.Log(json);

        // �ۑ�
        PlayerPrefs.SetString("SaveData", json);
    }
}
