using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IAction:MonoBehaviour
{
   public abstract void Active();

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            other.GetComponent<Player>().SetAction(this);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<Player>().RemoveAction();
        }
    }
}
