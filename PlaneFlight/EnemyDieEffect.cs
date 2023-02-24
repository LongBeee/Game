using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDieEffect : MonoBehaviour
{
    public float fSpeed = 0.0f;
    GameObject Player;
    Vector3 dir;
    public GameObject explosionFactory;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject explosion = Instantiate(explosionFactory);

        explosion.transform.position = transform.position;


        //Destroy(collision.gameObject);
        //Destroy(gameObject);
    }
}
