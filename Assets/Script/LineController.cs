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
}
