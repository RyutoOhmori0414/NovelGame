using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadController : MonoBehaviour
{
    public void Load()
    {
        string json = PlayerPrefs.GetString("SaveData");

        Savedata saveData = JsonUtility.FromJson<Savedata>(json);
    }
}
