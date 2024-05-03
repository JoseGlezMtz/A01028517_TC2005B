using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimonButton : MonoBehaviour
{
    Color originalColor;
    public float delay;
    AudioSource audio;
    
    
    

    // Start is called before the first frame update
    public void init(int index)
    {
      originalColor=GetComponent<Image>().color; 
      audio=GetComponent<AudioSource>();
      audio.clip=Resources.Load<AudioClip>($"Audios/{index}");
    }

    // Update is called once per frame
    public void Highlight()
    {
        audio.Play();
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        GetComponent<Image>().color=Color.white;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Image>().color=originalColor;
    }
}
