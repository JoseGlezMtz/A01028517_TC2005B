using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PongManager : MonoBehaviour
{
[SerializeField] GameObject ball;
[SerializeField] float speed;

[SerializeField] GameObject ballPrefab;

[SerializeField] TMP_Text scoreP1;
[SerializeField] TMP_Text scoreP2;

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
        if (Input.GetKeyDown(KeyCode.R) ){
            Reset();
        }
    }

    public void Reset(){
        if (ball!=null){
        Destroy(ball);
        InitGame();}

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
            scoreP1.text=PointsPlayer1.ToString();
            InitGame();
        }
        else if (player=="Player2"){
            PointsPlayer2++;
            scoreP2.text=PointsPlayer2.ToString();
            InitGame();
        }
        
    }
    public void Goto(string name){
        UnityEngine.SceneManagement.SceneManager.LoadScene(name);
}
}



