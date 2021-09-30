using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveElements : MonoBehaviour
{
    [SerializeField] private GameObject Current;

   
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag=="Player")
        {
            Current.SetActive(false);
        }
    }
  
    private void OnTriggerExit(Collider other)
    {
       
        if (other.gameObject.tag == "Player")
        {
            Current.SetActive(true);
        }
    }
}
