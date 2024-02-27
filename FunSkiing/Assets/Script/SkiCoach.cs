using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class SkiCoach : MonoBehaviour
{
    private GameObject _player;
    private NavMeshAgent _coach;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _coach = GetComponent<NavMeshAgent>();
        _coach.speed = 0f;
        StartCoroutine(Begin());
    }

    public void Update()
    {
        StartCoroutine("Chase"); 
    }

    IEnumerator Begin()
    {
        yield return new WaitForSeconds(4f);
        _coach.speed = 22f;
    }

    public void Chase()
    {
        GetComponent<NavMeshAgent>().destination = _player.transform.position;
    }
}
