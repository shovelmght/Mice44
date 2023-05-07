using System.Collections;
using UnityEngine;
using UnityEngine.AI;
public class HumanMovement : MonoBehaviour
{
    NavMeshAgent nav;
    [SerializeField] Transform[] VisitStops;
    [SerializeField] float TimeWaiting;
    [SerializeField] Animator anim;
    [SerializeField] bool anime;
    private Vector3 previousPosition;
    private float curSpeed;

    void Awake()
    {
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        StartCoroutine(FindNewLocation(TimeWaiting));
    }

    void Update()
    {
        Vector3 curMove = transform.position - previousPosition;
        curSpeed = curMove.magnitude / Time.deltaTime;
        previousPosition = transform.position;
        anim.SetFloat("curentSpeed", curSpeed);
    }

    IEnumerator FindNewLocation(float waitTime)
    {
        anime = true;
        yield return new WaitForSeconds(waitTime);
        anime = false;
        int locationIndex = Random.Range(0, VisitStops.Length);
        nav.SetDestination(VisitStops[locationIndex].position);
        StartCoroutine(FindNewLocation(waitTime));
    }
}
