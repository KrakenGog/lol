using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NpcBehavior : MonoBehaviour
{
    [SerializeField] private Transform[] Points;
    private NavMeshAgent _agent;
    private Coroutine current;
    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        current= StartCoroutine(Behavior());
    }
    IEnumerator Behavior()
    {
        while (true)
        {
            int i = Random.Range(0, Points.Length);
            _agent.SetDestination(Points[i].position);
            yield return new WaitForSeconds(Random.Range(20, 100));
        }
    }
    public void Stop()
    {
        StopCoroutine(current);
        current = null;
        _agent.SetDestination(transform.position);
    }
    public void Active()
    {
        if(current==null)
        current = StartCoroutine(Behavior());
    }
    private void OnEnable()
    {
        DialogPresenter.OnEnded += Active;
    }
    private void OnDisable()
    {
        DialogPresenter.OnEnded -= Active;
    }
}
