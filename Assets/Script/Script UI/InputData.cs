using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using UnityEngine;

public class InputData : MonoBehaviour
{
    public TMP_InputField _inputJarak, _inputGravitasi;
    
    // Start is called before the first frame update

    public void InputSimulation()
    {
        Konstanta.jarak = int.Parse(_inputJarak.text);
        Konstanta.gravitasi = float.Parse(_inputGravitasi.text);
    }

    public void ResetField()
    {
        _inputJarak.text = " ";
        _inputGravitasi.text = " ";

    }
}
