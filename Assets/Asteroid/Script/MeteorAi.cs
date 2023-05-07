using UnityEngine;
using UnityEngine.AI;

public class MeteorAi : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab; 
    Transform PlayerTranform;
    NavMeshAgent navMeshAgent;

    [SerializeField] int PointToAdd = 20;

    void Start()
    {
        PlayerTranform = GameObject.FindGameObjectWithTag("Player").transform;
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void LateUpdate()
    {
        navMeshAgent.SetDestination(PlayerTranform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Laser")
        {
            var explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(explosion, 1f);
            GameObject.FindObjectOfType<Gamemanager>().AddPoint(PointToAdd);
            Destroy(this.gameObject);
        }
        else
        if(collision.gameObject.tag == "Border" || collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
