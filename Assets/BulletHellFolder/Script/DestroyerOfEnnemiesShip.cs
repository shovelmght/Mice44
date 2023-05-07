using UnityEngine;

public class DestroyerOfEnnemiesShip : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BulletEnn"))
        {
            Destroy(collision.gameObject);
        }
    }
}
