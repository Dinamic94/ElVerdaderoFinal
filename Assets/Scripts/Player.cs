using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 10f;
    public int MonedasRecolectadas; 

    Vector3 posInicial; 

    void Start()
    {
        posInicial = transform.position;
    }

    void Update()
    {
        MovimientoJugador();

        if(transform.position.y < -10)
        {
            Respawn();
        }

        YouWin();
    }
    
    void MovimientoJugador()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(movX,0,movY)* Speed * Time.deltaTime);

        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0,-1,0);
        }

        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0,1,0);
        }
    }
    void Respawn()
    {
        transform.position = posInicial;
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.transform.gameObject.tag == "Pinchos")
        {
            Debug.Log("Me he pinchao");
            Respawn();
        }

        if(col.transform.gameObject.tag == "Coin")
        {
            Debug.Log("He recogido una moneda");
            MonedasRecolectadas ++; 
            Destroy(col.transform.gameObject);
        }
    }

    void YouWin()
    {
        if(MonedasRecolectadas == 16)
        {
            Debug.Log("HAS GANADO TIO"); 
        }
    }


}
