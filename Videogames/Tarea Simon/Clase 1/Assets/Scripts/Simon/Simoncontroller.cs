/*
Manage the flow of the Simon game
Keep track of the turn, and the list of buttons to press

Gilberto Echeverria
2024-04-24
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SimonController : MonoBehaviour
{
    [SerializeField] List<SimonButton> buttons;
    [SerializeField] List<int> sequence;
    [SerializeField] float delay;
    [SerializeField] int level=1;
    [SerializeField] bool playerTurn = false;
    [SerializeField] int counter = 0;
    [SerializeField] int numButtons=6;
    [SerializeField] GameObject buttonPrefab;
    [SerializeField] Transform buttonParent;
    [SerializeField] TextMeshProUGUI textMesh;
    [SerializeField] TextMeshProUGUI textlevel;
    //Se le añade un multiplicador para ir aumentando la velocidad
    public float mult=1.0f;
    public int Max_level=0;
    [SerializeField] TextMeshProUGUI maxlevel;

    public string APIData= @"
    {
        ""buttons"":[
            {
                ""ID"":0,
                ""r"":1.0,
                ""g"":0.0,
                ""b"":0.5
            }
        ]
    }";

    [SerializeField] ColorButtons allButtons;
    // Start is called before the first frame update
    void Start()
    {
        // Configure the buttons to be used in the game
        //PrepareButtons();
        GetComponent<APIconection>().getData();
    }

    // Configure the callback functions for the buttons
    public void PrepareButtons()
    {
        allButtons = JsonUtility.FromJson<ColorButtons>(APIData);
        foreach (ColorButton button in allButtons.buttons) {
            GameObject newButton = Instantiate(buttonPrefab, buttonParent);
            newButton.GetComponent<Image>().color = new Color(button.r, button.g, button.b);
            newButton.GetComponent<SimonButton>().init(button.ID);
            newButton.GetComponent<Button>().onClick.AddListener(() => ButtonPressed(button.ID));
            buttons.Add(newButton.GetComponent<SimonButton>());
            Debug.Log(button.ID);
        }
        AddToSequence();
        /*
        for (int i=0; i<numButtons; i++) {
            int index = i;
            GameObject newButton = Instantiate(buttonPrefab, buttonParent);
            newButton.GetComponent<Image>().color = Color.HSVToRGB((float)index/numButtons, 1, 1);
            newButton.GetComponent<SimonButton>().init(index);
            buttons.Add(newButton.GetComponent<SimonButton>());
            buttons[i].gameObject.GetComponent<Button>().onClick.AddListener(() => ButtonPressed(index));
        }
        // Start the game by adding the first button
        AddToSequence();*/
    }

    // Main function to validate that the button pressed by the user 
    // corresponds with the sequence generated by the CPU
    public void ButtonPressed(int index) {
        if (playerTurn) {
            if (index == sequence[counter++]) {
                // Highlight the button selected by the player
                buttons[index].Highlight();
                if (counter == sequence.Count) {
                    // Finish the player turn to ensure no other actions are
                    // taken into account
                    playerTurn = false;
                    level++;
                    counter = 0;
                    if(mult!=0.1 && level%2==0){
                        mult-=0.1f;
                    }
                    textlevel.text = "Level: "+ level.ToString() ;
                    textMesh.text = "PC turn!";
                    if(level%5==0){
                        numButtons++;
                        Create_Button();
                    }
                    AddToSequence();
                }
            } else {
                Debug.Log("Game Over!");
                textMesh.text = "Game Over!";
                if(level>Max_level){
                    textMesh.text = "New Max Level!";
                    maxlevel.text = "Max Level: "+ level.ToString();
                    Max_level=level;
                    playerTurn = false;
                }
            }
        }
    }

    // Add another number to the sequence and display it
    void AddToSequence()
    {
        // Add a new button to the sequence
        sequence.Add(Random.Range(0, buttons.Count));
        StartCoroutine(PlaySequence());
    }

    // Display every button in the sequence so far
    IEnumerator PlaySequence()
    {
        // Add an initial delay before showing the sequence
        yield return new WaitForSeconds(delay);
        foreach (int index in sequence) {
            buttons[index].Highlight();
            yield return new WaitForSeconds(delay*mult);
            //aqui se hace referencia al multiplicador para que el tiempo de espera sea menor solo al momento de mostrar la secuencia
        }
        // Switch the turn over to the player
        playerTurn = true;
        textMesh.text = "Your Turn!";
    }

    // Restart the game
    public void RestartGame()
    {
        foreach (SimonButton button in buttons) {
            Destroy(button.gameObject);
        }
        sequence.Clear();
        buttons.Clear();    
        level = 1;
        counter = 0;
        numButtons=6;
        playerTurn = false;
        textMesh.text = "PC turn!";
        textlevel.text = "Level: "+ level.ToString() ;
        PrepareButtons();
    }

    public void Create_Button(){
            GameObject newButton = Instantiate(buttonPrefab, buttonParent);
            newButton.GetComponent<Image>().color = Color.HSVToRGB((float)(numButtons-1)/numButtons, 1, 1);
            newButton.GetComponent<SimonButton>().init(numButtons-1);
            buttons.Add(newButton.GetComponent<SimonButton>());
            buttons[numButtons-1].gameObject.GetComponent<Button>().onClick.AddListener(() => ButtonPressed(numButtons-1));

    }
}