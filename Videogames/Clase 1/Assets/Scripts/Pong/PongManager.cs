using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongManager : MonoBehaviour
{
[SerializeField] GameObject ball;
[SerializeField] float speed;

[SerializeField] GameObject ballPrefab;

public int PointsPlayer1;
public int PointsPlayer2;

    // Start is called before the first frame update
    void Start()
    {
        InitGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && ball!=null){
            Destroy(ball);
            InitGame();
        }
    }
    void InitGame(){
        StartCoroutine(ServeBall());
    }

    IEnumerator ServeBall(){
        yield return new WaitForSeconds(2.0f);
        ball=Instantiate(ballPrefab);
        ball.GetComponent<Rigidbody2D>().velocity= Random.insideUnitCircle.normalized*speed;
    }

    public void Score(string player){
        if(player=="Player1"){
            PointsPlayer1++;
            InitGame();
        }
        else if (player=="Player2"){
            PointsPlayer2++;
            InitGame();
        }
        
    }
}



