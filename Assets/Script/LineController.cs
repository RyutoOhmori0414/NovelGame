using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LineController : MonoBehaviour
{
    class Linedata
    { 
        string _state;
        string _name;
        string _line;

        string State { get => _state; set => _state = value; }
        string Name { get => _name; set => _name = value; }
        string Line { get => _line; set => _line = value; }
    }

    List<Linedata> _linedata = new List<Linedata>();
    /// <summary>���݂̍s</summary>
    int _lineNum = default;

    /// <summary>���݂̍s</summary>
    public int LineNum
    {
        get { return _lineNum; }
    }

    List<string> _line = new();

    private void Start()
    {
        string textPath = Application.persistentDataPath + "/introduction.txt";
        var introductionText = File.ReadAllText(textPath).Split('|');

        for (int i = 0; i < introductionText.Length; i++)
        {
            var temp = introductionText[i].Split(',');
            _linedata.Add(new Linedata());
            foreach(var o in temp)
            {
                
            }

            
        }

    }

    /// <summary>
    /// �ŏ��Ɍ��݂̍s���o�͂��āA���̂��Ƃ�line�̃C���f�b�N�X��1���₵�Ă���
    /// </summary>
    /// <returns></returns>
    public string LineUpdate()
    {
        string tmptext = _line[_lineNum];
        _lineNum++;
        return tmptext;
    }
}
