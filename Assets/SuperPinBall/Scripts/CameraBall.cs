using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CameraBall : MonoBehaviour
{
    public List<Transform>balls = new List<Transform>();

    private bool mainBall = true;
    void Update()
    {
        if (balls[0] != null)
        {
            transform.position = balls[0].transform.position + new Vector3(0, 0, -10);
        }
    }

    public void SetMainBall()
    {
        balls.Insert(0, balls.Last());
        balls[0].GetComponent<MovementManager>().SetMainBall(true);
    }

    public void AddBalls(Transform newBall)
    {
        balls.Add(newBall);
    }
}
