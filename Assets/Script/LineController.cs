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

        string State { get => _state; }
        string Name { get => _name; }
        string Line { get => _line; }

        Linedata(string line = "", string name = "", string state = "")
        {
            _name = name;
            _state = state;
            _line = line;
        }
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
        string introductionPath = Application.persistentDataPath + "/introduction.txt";
        var introductionText = File.ReadAllText(introductionPath).Split('|');

        foreach (var n in introductionText)

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
