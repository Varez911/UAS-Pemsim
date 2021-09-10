using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaScript : MonoBehaviour
{
    private float timer;
    [SerializeField] float vo;
    [SerializeField] float sudut;
    [SerializeField] const float gravitasi = 9.8f;

    private Vector3 initialPosisiton;
    void Start()
    {
        initialPosisiton = transform.position;
    }

    public float Vo
    {
        get => vo;
        set => vo = value;
    }

    public float Sudut
    {
        get => sudut;
        set => sudut = value;
    }

    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime/2;

        transform.position = new Vector3
            (
                initialPosisiton.x + PosX(vo, sudut, timer),
                initialPosisiton.y + PosY(vo, sudut, timer),
                transform.position.z
            );
        Debug.Log("Ketinggian Maks: " + KetinggianMaksimum());
        Debug.Log("Waktu ke Ketinggian Maks: " + WaktuTitikPuncak());
        Debug.Log("Jangkauan Maks: " + JangkauanMaksimum());
        Debug.Log("Waktu ke Jangkauan Maks: " + WaktuJangkauanMaksimum());
        
    }

    private void FixedUpdate()
    {
    }

    private float PosX(float _vo, float _s, float _w)
    {
        return _vo * _w * Mathf.Cos(_s * Mathf.PI / 180);
    }

    private float PosY(float _vo, float _s, float _w)
    {
        return (_vo * _w * Mathf.Sin(_s * Mathf.PI / 180)) - (0.5f * gravitasi * Mathf.Pow(_w, 2));
    }

    /// <summary>
    /// Waktu ketika objek mencapai titik puncak
    /// </summary>
    /// <param name="_vo"></param>
    /// <param name="_s"></param>
    /// <returns></returns>
    
    public float WaktuTitikPuncak()
    {
        return (vo * Mathf.Sin(sudut * Mathf.PI / 180) / gravitasi);
    }

    public float KetinggianMaksimum()
    {
        return Mathf.Pow(vo, 2) * Mathf.Pow(Mathf.Sin(sudut * Mathf.PI / 180), 2) / (2 * gravitasi);
    }

    public float JangkauanMaksimum()
    {
        return 2 * Mathf.Pow(vo, 2) * Mathf.Sin(sudut * Mathf.PI / 180) * Mathf.Cos(sudut * Mathf.PI / 180) / gravitasi;
    }

    public float WaktuJangkauanMaksimum()
    {
        return 2 * WaktuTitikPuncak();
    }
}
