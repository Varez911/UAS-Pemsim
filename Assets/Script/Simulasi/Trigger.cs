using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public Animator playerAnimator;
    [Space]
    public GameObject bolaBasket;
    public GameObject playerHand, lokasiBola;

    private int _iteration;
    
    private void Start()
    {
        _iteration = 0;
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
        _iteration += 1;
        Debug.Log("======||Reset simulasi "+ _iteration +"||======");
        StartCoroutine(SpawnBola());
    }

    private IEnumerator SpawnBola()
    {
        playerAnimator.SetTrigger("Reset");

        yield return new WaitForSeconds(0.5f);
        
        GameObject bola = Instantiate(bolaBasket, lokasiBola.transform.position, Quaternion.identity, playerHand.transform);
        bola.name = "Basketball_size6_SF";
        bola.transform.localScale = lokasiBola.transform.localScale;
        // SimulasiManagerScript._ParaScript = bola.GetComponent<ParaScript>();
    }
}
