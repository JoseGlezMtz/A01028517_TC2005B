using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* este codigo se encarga de mover la pala del jugador
*/

public class paddleMotion : MonoBehaviour
{
    [SerializeField]float speed;
    [SerializeField]Vector2 direction;
    [SerializeField]KeyCode positiveKey;
    [SerializeField]KeyCode negativeKey;
    [SerializeField]float Limit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(positiveKey) && (transform.position.y < Limit)){
            transform.Translate(direction * speed * Time.deltaTime);
    }
        else if(Input.GetKey(negativeKey) && (transform.position.y > -Limit)){
        transform.Translate(-direction * speed * Time.deltaTime);
    }
}
}
