using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameObject Player;
    public static bool something_Grab = false;
    // Start is called before the first frame update
    void Start()
    {
        Player = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
