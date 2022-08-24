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
    [Tooltip("�{�������郊�X�g")]
    List<string> _lines = new List<string>();
    [Tooltip("���O�����郊�X�g")]
    List<string> _names = new List<string>();
    [Tooltip("��Ԃ����郊�X�g")]
    List<string> _state = new List<string>();
    [Tooltip("�N���b�N")]
    int _crickCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        SplitText();
    }

    private void Update()
    {
        ChangeLine();
    }

    void ChangeLine()
    {
        if (Input.GetButtonDown("Submit") || _crickCount == 0)
        {
            if (_state[_crickCount] != "none")
            {
                _situation.text = _state[_crickCount];
            }
            if (_names[_crickCount] != "none")
            {
                _name.text = _names[_crickCount];
            }
            if (_lines[_crickCount] != "none")
            {
                _line.text = _lines[_crickCount];
            }

            _crickCount++;
        }
    }

    void SplitText()
    {
        var stringLine = _novelText.text.Split('|');
        foreach (var line in stringLine)
        {
            if (!line.Contains("@situation:"))
            {
                _state.Add("none");
            }
            if (!line.Contains("@name:"))
            {
                _names.Add("none");
            }
            if (!line.Contains("@line:"))
            {
                _lines.Add("none");
            }

            var str = line.Split(',');
            foreach (var text in str)
            {
                if (text.Contains("@situation:"))
                {
                    _state.Add(text.Replace("@situation:", "").TrimStart('\r', '\n'));
                }
                else if (text.Contains("@name:"))
                {
                    _names.Add(text.Replace("@name:", "").TrimStart('\r', '\n'));
                }
                else if (text.Contains("@line:"))
                {
                    _lines.Add(text.Replace("@line:", "").TrimStart('\r', '\n'));
                }
            }
        }
    }
}