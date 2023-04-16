using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelDistance : MonoBehaviour
{
    public GameObject disDisplay;
    public GameObject disEndDisplay;
    public int disRun;
    public bool addingDis = false;
    public  float disDelay = 0.35f;
    public float timer = 4.2f;

    void Update()
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;
        }
        else if (addingDis == false)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
    }
   



    // A tavolsagmeres elkezdodik van rajta delay hogy mennyi idonkent ad hozza tavolsagot
    IEnumerator AddingDis()
    {
        
        disRun += 1;
        disDisplay.GetComponent<Text>().text = "" + disRun;
        disEndDisplay.GetComponent<Text>().text = "" + disRun;
        yield return new WaitForSeconds(disDelay);
        addingDis = false;
    }
}
