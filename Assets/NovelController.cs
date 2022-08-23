using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NovelController : MonoBehaviour
{
    [Tooltip("読み取るTextAsset")]
    [SerializeField] TextAsset _novelText;
    [Tooltip("situationを表示するUI")]
    [SerializeField] Text _situation;
    [Tooltip("名前を表示するUI")]
    [SerializeField] Text _name;
    [Tooltip("本文を表示するUI")]
    [SerializeField] Text _line;
    // Start is called before the first frame update
    void Start()
    {
        var stringLine = _novelText.text.Split(',');
        foreach (var line in stringLine)
        {
            if (line.Contains("@situation:"))
            {
                _situation.text = line.Replace("@situation:", "");
            }
            else if (line.Contains("@name:"))
            {
                _name.text = line.Replace("@name:", "").TrimStart('\r', '\n');
            }
            else if (line.Contains("line:"))
            {
                _line.text = line.Replace("@line:", "").TrimStart('\r', '\n');
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
