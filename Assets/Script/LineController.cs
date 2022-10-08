using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    [Header("読み込むテキスト")]
    [Tooltip("シナリオのテキスト"), SerializeField]
    TextAsset _scenarioText;

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
        Array.ForEach(_scenarioText.text.Split(), i => _line.Add(i));
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
