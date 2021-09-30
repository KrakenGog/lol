using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMessage : IAction
{
    [SerializeField] private Image Message;
    public override void Active()
    {
        Transform parent = GameObject.Find("Canvas").transform;
        Image inst = Instantiate(Message);
        inst.transform.SetParent(parent);
        inst.transform.localScale = Vector3.one;
        inst.rectTransform.localPosition = Vector3.zero;
    }
    
}
