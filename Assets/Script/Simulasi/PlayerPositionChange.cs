using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPositionChange : MonoBehaviour
{
    
    private Slider _slider;
    public GameObject _player;
    private Transform initialPos;
    private void Start()
    {
        _slider = GetComponent<Slider>();
        initialPos = _player.transform;
    }
    
    public void PindahPosisi()
    {
        _player.transform.position = new Vector3((_slider.value - 100)/100, initialPos.position.y, initialPos.position.z);
    }
}
