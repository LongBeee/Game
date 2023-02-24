using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject explosionFactory;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 3 * Time.deltaTime);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
