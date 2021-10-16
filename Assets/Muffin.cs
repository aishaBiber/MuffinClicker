using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class Muffin : MonoBehaviour
{

    public GameObject floatingTextPrefab; 
    public TMP_Text MuffinText;
    public int TotalClicks;
    public int pointsPerClick = 1; 

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

        TotalClicks = TotalClicks + pointsPerClick; 
        UpdateUI(); 
        Debug.Log(TotalClicks);

        //MuffinText.text = TotalClicks.ToString() + " muffins";

        CreateFloatingText("+" + pointsPerClick.ToString()); 
    }

    private void CreateFloatingText(string message)
    {
        //Spawn a new floating text prefab 
        GameObject newFloatingText = Instantiate(floatingTextPrefab, transform);
        //Generate a random position around the muffin 
        Vector3 pos = GetRandomPosAroundMuffin();

        //Position the new floating text at the random position 
        newFloatingText.transform.localPosition = pos;

        //Set the floating actual text property of the float text prefab 
        TMP_Text floatingTextComp = newFloatingText.GetComponent<TMP_Text>();
        floatingTextComp.text = message; 

    }

    private Vector3 GetRandomPosAroundMuffin()
    {
        float x = Random.Range(-200f, 200f);
        float y = Random.Range(50f, 225f);

        return new Vector3(x, y);
    }
}