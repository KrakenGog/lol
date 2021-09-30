using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private Transform Camera;
    [SerializeField] private Transform Target;

    private Vector3 offset;
    private Vector3 currentDir;
    private void Start()
    {
        offset = Target.position - Camera.position;
    }
    public void SetCameraPositin(Vector3 pos)
    {
        Camera.position = new Vector3(pos.x, Camera.position.y, pos.z);
    }

    private void Update()
    {
        currentDir = Vector3.MoveTowards(currentDir, Target.forward, Time.deltaTime * 1);
        Vector3 finishPos = Target.position-offset+currentDir;
        float dis = Vector3.Distance(Camera.position, Target.position);
        Vector3 currentPos = Vector3.MoveTowards(Camera.position, finishPos,dis*dis*dis*0.00005f );

        SetCameraPositin(currentPos);
    }
}
