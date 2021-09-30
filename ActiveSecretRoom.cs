using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSecretRoom : IAction
{
    [SerializeField] private GameObject SecretRoom;
    [SerializeField] private Animator Animator;
    public override void Active()
    {
        Animator.SetBool("DoorOpen",true);
        SecretRoom.SetActive(true);
    }
}
