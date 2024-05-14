using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class APIconection : MonoBehaviour
{
    [SerializeField] string url;
    [SerializeField] string getEndpoint;
    SimonController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller=GetComponent<SimonController>();
    }

    // Update is called once per frame
    public void getData(){
        StartCoroutine(RequestGet(url+getEndpoint));
    }

    IEnumerator RequestGet(string url){
        using(UnityWebRequest www = UnityWebRequest.Get(url)){
            yield return www.SendWebRequest();
            if(www.isNetworkError || www.isHttpError){
                Debug.Log("request error" + www.error);
            }else{
                string result=www.downloadHandler.text;
                Debug.Log("result" + result);
                controller.APIData=result;
                controller.PrepareButtons();
            }
        }
    }
}
