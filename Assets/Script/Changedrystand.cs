using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changedrystand : MonoBehaviour
{
    public GameObject drystand;
    public GameObject on_drystand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showDrystand()
    {
        drystand.SetActive(false);
        on_drystand.SetActive(true);
        
    }
    public void closeDrystand()
    {
        drystand.SetActive(true);
        on_drystand.SetActive(false);
    }
}
