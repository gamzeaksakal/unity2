using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class CarpismaTespit : MonoBehaviour
{
   
    public int puan;
    public static int TotalPuan;
    public List <GameObject> puanObjeleri = new List<GameObject> ();
    private GameObject PuanYazisi;
    private void OnCollisionEnter(Collision collision)
    {
        PuanYazisi = GameObject.Find("toplampuan");
        puanObjeleri.Add(GameObject.Find("PositiveObject"));// 3+ 2- olacak
        puanObjeleri.Add(GameObject.Find("PositiveObject"));
        puanObjeleri.Add(GameObject.Find("PositiveObject"));
        puanObjeleri.Add(GameObject.Find("NegativeObject"));
        puanObjeleri.Add(GameObject.Find("NegativeObject"));
       
        int SecimDegiskeni = Random.Range(0, 5);
        float rastgeleXDegiskeni = Random.Range(-5.2f, 7.94f);
        float rastgeleZDegiskeni = Random.Range(-18.54f, 0f);
        TotalPuan += puan;
        if (TotalPuan >= 30)
        {
            TotalPuan = 0; 
            SceneManager.LoadScene(1);
        }
        PuanYazisi.GetComponent<Text>().text = "Puan: " + TotalPuan.ToString(); 
        GameObject yaratilanObje = (GameObject)Instantiate(puanObjeleri[SecimDegiskeni], new Vector3(rastgeleXDegiskeni, 4.55f, rastgeleZDegiskeni), Quaternion.Euler(0, 0, 0));
        Destroy(gameObject);
    }
    
   
        
    void Update()
    {
        transform.Rotate(1, 3, 4);
        
    }
}
