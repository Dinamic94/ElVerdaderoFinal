using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform posJugador; 
    public float Speed = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        FollowPlayer();
        CheckDistance();
    }

    void CheckDistance()
    {
       float dis = Vector3.Distance(posJugador.position,transform.position);

       

       if(dis < 10)
       {
            Speed = 3;
            Debug.Log("Estoy cerca");
       }
       else
       {
            Speed = 0;
            
       }
    }
    void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, posJugador.position, Speed * Time.deltaTime);
    }
}
