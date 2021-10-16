using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FloatingText : MonoBehaviour
{

    public float speed = 99;
    public float lifetime = 3f;

    private float age = 0; 

    private TMP_Text textComp;
    //public Vector3 lerpedValue;
    public Color initialColor; 
    //public float tValue; 
    // Start is called before the first frame update
    void Start()
    {
        textComp = GetComponent<TMP_Text>();
        initialColor = textComp.color; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);

        textComp.color = Color.Lerp(initialColor, Color.clear, age / lifetime); 
    }
}
