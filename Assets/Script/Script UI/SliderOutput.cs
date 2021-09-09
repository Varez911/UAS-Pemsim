using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderOutput : MonoBehaviour
{
    private Slider _slider;
    
    private void Start()
    {
        _slider = GetComponent<Slider>();
    }

    public void ShowValue(TMP_Text _textOutput)
    {
        _textOutput.text = _slider.value.ToString();
    }
}
