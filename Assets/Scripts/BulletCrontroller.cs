using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCrontroller : MonoBehaviour
{
    public float power = 100f;

    public float lifeTime = 5f;
    
    float deltatime = 0f;
    
    Rigidbody bulletRb;
    
    void Start()
    {
        bulletRb = GetComponent<Rigidbody>();
        bulletRb.velocity = this.transform.forward * power;
    }

    void FixedUpdate()
    {
        deltatime += Time.deltaTime;
        
        if (deltatime >= lifeTime)
        {
            Destroy (this.gameObject);
        }
    }
}
