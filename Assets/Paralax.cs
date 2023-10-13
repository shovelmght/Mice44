using System.Collections;
using System.Collections.Generic;
using LesserKnown.Player;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    [SerializeField] private PlayerMovement PlayerMovementSolver;
    [SerializeField] private PlayerMovement PlayerMovementFigther;
    [SerializeField] private Transform TransformSolver;
    [SerializeField] private float speed;
    // Start is called before the first frame update

    private float lastSolverPositionX;

    // Update is called once per frame
    void Update()
    {
        float posX = transform.position.x + (TransformSolver.position.x - lastSolverPositionX) *
            Time.deltaTime * speed;

        lastSolverPositionX = TransformSolver.position.x;
        /*float posX = transform.position.x + (PlayerMovementSolver._ParalaxValue + PlayerMovementFigther._ParalaxValue) *
            Time.deltaTime * speed;*/
        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
    }
}
