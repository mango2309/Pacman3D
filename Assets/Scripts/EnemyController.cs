using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    public Transform player;
    private NavMeshAgent enemy;
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();
    }

    void EnemyMove()
    {
        enemy.destination = player.position;
    }
}
