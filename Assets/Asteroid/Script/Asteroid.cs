using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] int minTorque = 2;
    [SerializeField] int maxTorque = 7;

    [SerializeField] float minScale = 0.5f;
    [SerializeField] float maxScale = 1f;

    [SerializeField] GameObject explosionPrefab;

    [SerializeField] int PointToAdd = 10;

    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddTorque(Vector3.up * Random.Range(minTorque, maxTorque));

        float newScale = Random.Range(minScale, maxScale);
        gameObject.transform.localScale = new Vector3(newScale, newScale, 0f);
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
        if (collision.gameObject.tag == "Border" || collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
