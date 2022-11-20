using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Rendering;

public class LineController : MonoBehaviour
{
    class Linedata
    { 
        string _state;
        string _name;
        string _line;

        public string State { get => _state; set => _state = value; }
        public string Name { get => _name; set => _name = value; }
        public string Line { get => _line; set => _line = value; }
    }

    [Tooltip("導入部"), SerializeField]
    TextAsset _introduction;

    List<Linedata> _linedata = new List<Linedata>();
    /// <summary>現在の行</summary>
    int _lineNum = 0;

    /// <summary>現在の行</summary>
    public int LineNum
    {
        get { return _lineNum; }
    }

    private void Awake()
    {
        var introductionText = _introduction.text.Split('|');

        for (int i = 0; i < introductionText.Length; i++)
        {
            var temp = introductionText[i].Split(',');
            _linedata.Add(new Linedata());
            
            // 文字列の仕分け
            foreach(var o in temp)
            {
                var tempLine = o.Replace("\n", "");

                if(tempLine.Contains("@state:"))
                {
                    _linedata[i].State = tempLine.Replace("@state:", "");
                }
                else if (tempLine.Contains("@name:"))
                {
                    _linedata[i].Name = tempLine.Replace("@name:", "");
                }
                else if (tempLine.Contains("@line:"))
                {
                    _linedata[i].Line = tempLine.Replace("@line:", "");
                }
                else
                {
                    Debug.LogWarning($"「{tempLine}」は指定された書式ではない");
                }
            }
        }

    }

    /// <summary>
    /// 最初に現在の行を出力して、そのあとにlineのインデックスを1増やしている
    /// </summary>
    /// <returns></returns>
    public string LineUpdate(out string nameUI, out string stateUI)
    {
        string tmptext = _linedata[_lineNum].Line;
        nameUI = _linedata[_lineNum].Name;
        stateUI = _linedata[_lineNum].State;
        _lineNum++;
        return tmptext;
    }
}
