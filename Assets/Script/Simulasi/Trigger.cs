using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public Animator playerAnimator;
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("reset simulasi");
        //playerAnimator.SetTrigger("Reset");
        SceneManager.LoadScene("Simulasi");
    }
}
