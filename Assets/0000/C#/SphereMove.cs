using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class SphereMove : MonoBehaviour
{ 
    [Header("Скорость движения")]
    [SerializeField] private float Speed;
    private GameObject NAV = null;
    [Header("Радиус поиска игрока")]
    [SerializeField] private float Radius;

    private NavMeshAgent Agent;
    private void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        Agent.speed = Speed;
        GetComponent<SphereCollider>().radius = Radius;
        GetComponent<SphereCollider>().isTrigger = true;
    }

    void Update()
    {
        if (NAV != null)
        {
            Agent.SetDestination(NAV.transform.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NAV"))
        {
            NAV = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("NAV"))
        {
            NAV = null;
        }
    }

}
