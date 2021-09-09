using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulasiManagerScript : MonoBehaviour
{
    public Animator playerAnimator;
    public GameObject basketBall;
    
    
    public void ShootBall()
    {
        StartCoroutine(LemparBola());
    }

    private IEnumerator LemparBola()
    {
        playerAnimator.SetTrigger("Shoot");

        yield return new WaitForSeconds(1);

        basketBall.transform.parent = transform;
        basketBall.GetComponent<ParaScript>().enabled = true;

    }
}
