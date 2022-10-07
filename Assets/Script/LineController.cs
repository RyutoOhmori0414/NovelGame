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
}
