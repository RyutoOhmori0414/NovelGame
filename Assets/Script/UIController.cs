using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [Tooltip("メインの文章を出すテキスト"), SerializeField]
    Text _mainText = default;
    [Tooltip("名前を出すテキスト"), SerializeField]
    Text _nameText = default;
    [Tooltip("状態を出すテキスト"), SerializeField]
    Text _stateText = default;

    LineController _lineController = default;

    private void Start()
    {
        _lineController = FindObjectOfType<LineController>();
        TextUIUpdate();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            TextUIUpdate();
        }
    }

    void TextUIUpdate()
    {
        string tempName;
        string tempState;

        _mainText.text = _lineController.LineUpdate(out tempName, out tempState);

        if (tempName != null)
        {
            _nameText.text = tempName;
        }

        if (tempState != null)
        {
            _stateText.text = tempState;
        }
    }
}
