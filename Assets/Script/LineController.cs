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
    /// <summary>現在の行</summary>
    int _lineNum = default;

    /// <summary>現在の行</summary>
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
    /// 最初に現在の行を出力して、そのあとにlineのインデックスを1増やしている
    /// </summary>
    /// <returns></returns>
    public string LineUpdate()
    {
        string tmptext = _line[_lineNum];
        _lineNum++;
        return tmptext;
    }
}
