using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayitKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("TotalPuan" ))
        {
            PlayerPrefs.SetInt("TotalPuan", CarpismaTespit.TotalPuan)
        }
        else
        {
            int 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
