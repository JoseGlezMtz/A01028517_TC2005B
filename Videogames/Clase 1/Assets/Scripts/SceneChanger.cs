using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public void Goto(string name){
        UnityEngine.SceneManagement.SceneManager.LoadScene(name);
    }
}
