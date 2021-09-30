using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject ActiveButton;
    [SerializeField] private float Speed;
    private Rigidbody rigiBodyComponent;
    private IAction _action;
    private void Start()
    {
        rigiBodyComponent = GetComponent<Rigidbody>();
    }
    public void Move(Vector3 direction)
    {
        SetRotation(direction);
        if (direction != Vector3.zero)
        {
            rigiBodyComponent.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        
    }
    public void SetRotation(Vector3 dir)
    {
        if(dir!=Vector3.zero)
        transform.forward = new Vector3(dir.x,transform.forward.y,dir.z);
    }
    public void SetAction(IAction action)
    {
        if (_action == null)
        {
            _action = action;
            ActiveButton.SetActive(true);
        }
    }
    public void RemoveAction()
    {
        _action = null;
        ActiveButton.SetActive(false);
    }
    public void DoActive()
    {
        _action.Active();
    }
}
