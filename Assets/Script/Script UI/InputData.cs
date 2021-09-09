using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using UnityEngine;

public class InputData : MonoBehaviour
{
    public TMP_InputField _inputTinggiRing, _inputTinggiPemain, _inputJarak, _inputGravitasi;
    
    // Start is called before the first frame update

    public void InputSimulation()
    {
        Konstanta.ring = int.Parse(_inputTinggiRing.text);
        Konstanta.tinggiPemain = int.Parse(_inputTinggiPemain.text);
        Konstanta.jarak = int.Parse(_inputJarak.text);
        Konstanta.gravitasi = float.Parse(_inputGravitasi.text);
    }

    public void ResetField()
    {
        _inputTinggiRing.text = " ";
        _inputTinggiPemain.text = " ";
        _inputJarak.text = " ";
        _inputGravitasi.text = " ";

    }
}
