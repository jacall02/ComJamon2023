using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AutoFillInputField : MonoBehaviour
{
    public TMP_InputField inputField1;
    public TMP_InputField inputField2;

    void OnInputField1ValueChanged(string value)
    {
        inputField2.text = value;
    }

    void Start()
    {
        inputField1.onValueChanged.AddListener(OnInputField1ValueChanged);
    }
}
