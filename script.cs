using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject botonjugar;
    GameObject inicioff;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void fuera()
    {
        Application.Quit();
    }
    public void jugar()
    {
        inicioff.SetActive(false);
        botonjugar.SetActive(true);

    }
}
