using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class MainCameraAnimController : MonoBehaviour
{
    // Start is called before the first frame update
    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void swapLightState()
    {
        light1.enabled = !light1.enabled;
        light2.enabled = !light2.enabled;
        light3.enabled = !light3.enabled;
        light4.enabled = !light4.enabled;
    }
}
