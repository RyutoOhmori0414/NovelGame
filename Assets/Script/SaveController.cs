using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveController : MonoBehaviour
{

    public void Save(int currentLineNum/*, int bitFlag*/)
    {
        Savedata _savedata = new Savedata(currentLineNum, 0);

        // Json�ɃV���A����
        string json = JsonUtility.ToJson(_savedata);
        // �]�T������ΈÍ������Ă݂���
        Debug.Log(json);

        // �ۑ�
        PlayerPrefs.SetString("SaveData", json);
    }
}
