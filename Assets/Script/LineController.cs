using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    [Header("�ǂݍ��ރe�L�X�g")]
    [Tooltip("�V�i���I�̃e�L�X�g"), SerializeField]
    TextAsset _scenarioText;

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
        Array.ForEach(_scenarioText.text.Split(), i => _line.Add(i));
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
