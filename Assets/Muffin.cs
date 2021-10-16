using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class Muffin : MonoBehaviour
{
    public TMP_Text MuffinText;
    public int TotalClicks;


    //public RectTransform spinLight = null;
    //public RectTransform spinLight2 = null;


    public RectTransform[] spinLights;
    //public float[] spinLightSpeeds;

    private float[] spinLightSpeeds; 



    

    private void Start()
    {

        spinLightSpeeds = new float[spinLights.Length]; 

        for (int i = 0; i < spinLightSpeeds.Length; i++)
        {
            spinLightSpeeds[i] = Random.Range(-45f, 45f); 
        }
        
        UpdateUI();
    }

    private void Update()
    {
        int index = 0; 

        for(int i = 0; i < spinLights.Length; i++)
        {
            spinLights[index].Rotate(0, 0, spinLightSpeeds[index] * Time.deltaTime);
            index++; 
        }
        //spinLights[index].Rotate(0, 0, spinLightSpeeds[index] * Time.deltaTime);
        //index++; 
        //spinLights[index].Rotate(0, 0, spinLightSpeeds[index] * Time.deltaTime);
        //index++;
        //spinLights[index].Rotate(0, 0, spinLightSpeeds[index] * Time.deltaTime); 
        //index++;
        //spinLights[index].Rotate(0, 0, spinLightSpeeds[index] * Time.deltaTime); 
        //index++;
        //spinLights[index].Rotate(0, 0, spinLightSpeeds[index] * Time.deltaTime); 
        //index++;
        //spinLights[index].Rotate(0, 0, spinLightSpeeds[index] * Time.deltaTime);

    }
    private void UpdateUI()
    {
        if(TotalClicks == 1)
        {
            MuffinText.text = TotalClicks.ToString() + " muffin";
        }
        else
        {
            MuffinText.text = TotalClicks.ToString() + " muffins";
        }
       
    }
    public void OnMuffinClicked()
    {

        TotalClicks = TotalClicks + 1;
        UpdateUI(); 
        Debug.Log(TotalClicks);

        //MuffinText.text = TotalClicks.ToString() + " muffins";
    }
}