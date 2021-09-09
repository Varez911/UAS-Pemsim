using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SimulasiManagerScript : MonoBehaviour
{
    [Header("Script")] public ParaScript _ParaScript;
    
    [Header("Slider")] public Slider _sliderKecepatan;
    public Slider _sliderDerajat;

    [Header("Humanoid")]
    public Animator playerAnimator;
    public GameObject posisiLengan;

    [Header("Text Output")] public TMP_Text _tinggiMaks;
    public TMP_Text _waktuTinggiMaks, _jarakMaks, _waktuJarakMaks;
    
    //Private
    private GameObject basketBall;

    private void Update()
    {
        _tinggiMaks.text = _ParaScript.KetinggianMaksimum().ToString();
        _waktuTinggiMaks.text = _ParaScript.WaktuTitikPuncak().ToString();
        _jarakMaks.text = _ParaScript.JangkauanMaksimum().ToString();
        _waktuJarakMaks.text = _ParaScript.WaktuJangkauanMaksimum().ToString();
    }

    public void ShootBall()
    {
        StartCoroutine(LemparBola());
    }

    private IEnumerator LemparBola()
    {
        playerAnimator.SetTrigger("Shoot");
        basketBall = posisiLengan.transform.Find("Basketball_size6_SF").gameObject;

        yield return new WaitForSeconds(1);

        basketBall.transform.parent = transform;
        ParaScript parabola = basketBall.GetComponent<ParaScript>();

        parabola.Vo = _sliderKecepatan.value;
        parabola.Sudut = _sliderDerajat.value;
        parabola.enabled = true;

    }
}
