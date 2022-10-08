using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [Tooltip("���C���̕��͂��o���e�L�X�g"), SerializeField]
    Text _mainText = default;
    [Tooltip("���O���o���e�L�X�g"), SerializeField]
    Text _nameText = default;

    LineController _lineController = default;

    private void Start()
    {
        _lineController = GetComponent<LineController>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("submit"))
        {
            _mainText.text = _lineController.LineUpdate();
        }
    }
}
