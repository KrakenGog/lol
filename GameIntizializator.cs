using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameIntizializator : MonoBehaviour
{
    [SerializeField] private GameObject PlayerPref;
    [SerializeField] private Transform StartPos;

    private void Start()
    {
        PlayerPref.transform.position = StartPos.position;
        
    }
}
