using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NovelController : MonoBehaviour
{
    [Tooltip("�ǂݎ��TextAsset")]
    [SerializeField] TextAsset _novelText;
    [Tooltip("situation��\������UI")]
    [SerializeField] Text _situation;
    [Tooltip("���O��\������UI")]
    [SerializeField] Text _name;
    [Tooltip("�{����\������UI")]
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
