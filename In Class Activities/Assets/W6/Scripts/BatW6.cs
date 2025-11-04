using NUnit.Framework.Internal;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements.Experimental;
using UnityEngine.XR;
using static UnityEngine.Rendering.DebugUI;
using static UnityEngine.UIElements.UxmlAttributeDescription;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    // The BatW6 class will make the bat chase the Cat object, when enabled.
    //The BatW6 class should :
    //Be attached to ALL of the Bat GameObjects as a Component.
    //Have a speed value tunable in the Inspector.
    //Have a method that the BatManager can call that will make the bat STOP chasing the player, and a different one that will make the bat START chasing the player. (Hint: make sure to put the keyword ‘public’ in front of these methods so that BatManager can use them- we’ll talk about what this keyword means next class.)
    public float speed = 0.1f;
    public Transform _target;
    private bool _isChasing = false;
    private void Start()
    {
        Chase();
    }

    public void Chase()
    {
        _isChasing = true;
    }
    public void StopChasing()
    {
        _isChasing = false;
    }

    public void Update()
    {
        if (_isChasing)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target.position, speed * Time.deltaTime);
        }
        
    }
}
