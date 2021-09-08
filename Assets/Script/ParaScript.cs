using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaScript : MonoBehaviour
{
    [SerializeField] float timer;
    [SerializeField] float vo;
    [SerializeField] float sudut;
    [SerializeField] const float gravitasi = 9.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        transform.position = new Vector3
            (
                PosX(vo, sudut, timer),
                PosY(vo, sudut, timer),
                0
            );
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
    
    private float WaktuTitikPuncak(float _vo, float _s)
    {
        return (_vo * Mathf.Sin(_s * Mathf.PI / 180) / gravitasi);
    }

    private float KetinggianMaksimum(float _vo, float _s)
    {
        return Mathf.Pow(_vo, 2) * Mathf.Pow(Mathf.Sin(_s * Mathf.PI / 180), 2) / (2 * gravitasi);
    }

    private float JangkauanMaksimum(float _vo, float _s)
    {
        return 2 * Mathf.Pow(_vo, 2) * Mathf.Sin(_s * Mathf.PI / 180) * Mathf.Cos(_s * Mathf.PI / 180) / gravitasi;
    }

    private float WaktuJangkauanMaksimum(float _vo, float _s)
    {
        return 2 * WaktuTitikPuncak(_vo, _s);
    }
}
