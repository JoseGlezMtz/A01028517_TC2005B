using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Detects when the ball enters the goal

public class PongGoal : MonoBehaviour
{
    [SerializeField] string player;
    PongManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindWithTag("GameController").GetComponent<PongManager>();
    }

    void OnCollisionEnter2D(Collision2D other){
        
            manager.Score(player);
            Destroy(other.gameObject);
        
    }
    
}
