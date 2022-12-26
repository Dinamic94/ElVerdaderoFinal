using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : MonoBehaviour
{
    public Transform shootPoint; 
    public Transform bulletPrefab; 
    public float range = 100f;
    public Camera fpsCam;
    
    

    void Start()
    {
        
    }

   
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Disparar();
        }
    }
    void Disparar()
    {
        RaycastHit hit; 
        if(Physics.Raycast(fpsCam.transform.position,fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if(hit.transform.CompareTag("Enemy"))
            {
                Debug.Log("Has disparado a un enemy");
            }
        }       
    }
    
    public void Shoot()
    {
        Instantiate(bulletPrefab , shootPoint.position, shootPoint.rotation);
    }
}
