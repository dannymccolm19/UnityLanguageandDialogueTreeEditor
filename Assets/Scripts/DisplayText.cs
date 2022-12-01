using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{

    public English english;
    public French french;
    public German german;
    public Spanish spanish;
    public Italian italian;
    public KeyValues keyValues;

    public TMP_Text textm;
    public TMP_Dropdown drop;
    public GameObject[] prompts = new GameObject[5];
    

    int index = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        prompts[0].GetComponent<Button>().onClick.AddListener(() => Next(0));
        prompts[1].GetComponent<Button>().onClick.AddListener(() => Next(1));
        prompts[2].GetComponent<Button>().onClick.AddListener(() => Next(2));
        prompts[3].GetComponent<Button>().onClick.AddListener(() => Next(3));
        prompts[4].GetComponent<Button>().onClick.AddListener(() => Next(4));
        
    }

    void Next(int i){
        int x = 0;
        switch(i){
            case 0:
                x = keyValues.responseLink1[index];
                break;
            case 1:
                x = keyValues.responseLink2[index];
                break;
            case 2:
                x = keyValues.responseLink3[index];
                break;
            case 3:
                x = keyValues.responseLink4[index];
                break;
            case 4:
                x = keyValues.responseLink5[index];
                break;
        }
        
        index = x;
    }
    
    void Update()
    {
        //string[] values;
        string message = "";
        bool [] active = new bool[5];
        string[] responses = new string [5];
        active[0] = keyValues.active1[index];
        active[1] = keyValues.active2[index];
        active[2] = keyValues.active3[index];
        active[3] = keyValues.active4[index];
        active[4] = keyValues.active5[index];
        switch (drop.value){
            case 0:
                message = english.Values[index];
                responses[0] = english.response1[index];
                responses[1] = english.response2[index];
                responses[2] = english.response3[index];
                responses[3] = english.response4[index];
                responses[4] = english.response5[index];
                break;
            case 1:
                message = french.Values[index];
                responses[0] = french.response1[index];
                responses[1] = french.response2[index];
                responses[2] = french.response3[index];
                responses[3] = french.response4[index];
                responses[4] = french.response5[index];
                break;
            case 2:
                message = spanish.Values[index];
                responses[0] = spanish.response1[index];
                responses[1] = spanish.response2[index];
                responses[2] = spanish.response3[index];
                responses[3] = spanish.response4[index];
                responses[4] = spanish.response5[index];
                break;
            case 3:
                message = german.Values[index];
                responses[0] = german.response1[index];
                responses[1] = german.response2[index];
                responses[2] = german.response3[index];
                responses[3] = german.response4[index];
                responses[4] = german.response5[index];
                break;
            case 4:
                message = italian.Values[index];
                responses[0] = italian.response1[index];
                responses[1] = italian.response2[index];
                responses[2] = italian.response3[index];
                responses[3] = italian.response4[index];
                responses[4] = italian.response5[index];
                break;
        }
        
        for(int i =0; i<5; i++){
            TMP_Text p = prompts[i].GetComponentInChildren<Button>().GetComponentInChildren<TMP_Text>();
            if(active[i]){
                prompts[i].SetActive(true);
                p.text = responses[i];
            }
            else{
                prompts[i].SetActive(false);
            }

        }
        
       
        textm.text =  message;
    }
}
