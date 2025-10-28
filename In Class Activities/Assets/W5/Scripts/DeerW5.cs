using UnityEngine;
using UnityEngine.AI;

public class DeerW5 : MonoBehaviour
{
    [SerializeField] GameObject _target;
    private void Start()
    {
        NavMeshAgent _navMeshAgent = GetComponent<NavMeshAgent>();
        // sets destination to target position
        _navMeshAgent.SetDestination(_target.transform.position);
    }


}

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...
