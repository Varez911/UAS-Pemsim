using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ToSimulasi()
    {
        SceneManager.LoadScene("Simulasi");
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
