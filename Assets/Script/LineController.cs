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

    [Tooltip("������"), SerializeField]
    TextAsset _introduction;

    List<Linedata> _linedata = new List<Linedata>();
    /// <summary>���݂̍s</summary>
    int _lineNum = 0;

    /// <summary>���݂̍s</summary>
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
            
            // ������̎d����
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
                    Debug.LogWarning($"�u{tempLine}�v�͎w�肳�ꂽ�����ł͂Ȃ�");
                }
            }
        }

    }

    /// <summary>
    /// �ŏ��Ɍ��݂̍s���o�͂��āA���̂��Ƃ�line�̃C���f�b�N�X��1���₵�Ă���
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
