using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class update_text : MonoBehaviour
{   
    public TMP_Text canvasText;
    public TMP_Text phoneText;

    public string textVariable = "location:";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void update_phone(){
        phoneText.text = textVariable + canvasText.text;
    }
}
