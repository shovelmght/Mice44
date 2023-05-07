
using UnityEngine;

public class PaddleMesh : MonoBehaviour
{
    public Transform paddle;

    void Update()
    {
        transform.position = paddle.position;
        transform.rotation = paddle.rotation;
    }
}
