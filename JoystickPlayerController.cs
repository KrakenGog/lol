using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerController : MonoBehaviour
{
    [SerializeField] private Joystick JoystickComponent;
    private Player _playerComponent;
  
    private void Start()
    {
        _playerComponent = GetComponent<Player>();
    }
    private void FixedUpdate()
    {
        Vector3 joystickDirection = JoystickComponent.Direction;
        Vector3 direction = new Vector3(joystickDirection.x, 0, joystickDirection.y);
        _playerComponent.Move(direction);
    }
}
