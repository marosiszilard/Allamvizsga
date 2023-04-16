using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{ //Section Generalas, megadott idokozonkent
    public GameObject[] Section;
    public int zPosition = 50;
    public bool createSection = false;
    public int secNum;

    void Update()
    {
        if (createSection == false)
        {
            createSection = true;
            StartCoroutine(SectionGeneration());
        }
        
    }

    IEnumerator SectionGeneration()
    {
        secNum = Random.Range(0, 3);
        Instantiate(Section[secNum], new Vector3(0,0,zPosition), Quaternion.identity);
        zPosition += 50;
        yield return new WaitForSeconds(2);
        createSection = false; 
    }
}
