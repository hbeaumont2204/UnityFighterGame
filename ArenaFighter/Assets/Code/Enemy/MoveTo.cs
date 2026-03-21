    // MoveTo.cs
    using UnityEngine;
    using UnityEngine.AI;

    public class MoveTo : MonoBehaviour {

      public Transform goal;

    void Start()
    {
      goal = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update () {
          NavMeshAgent agent = GetComponent<NavMeshAgent>();
          agent.destination = goal.position;
       }
    }
