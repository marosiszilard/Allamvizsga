using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndRunSequence : MonoBehaviour
{

    public GameObject liveCoins;
    public GameObject liveDistance;
    public GameObject endScreen;
    public GameObject fadeOut;

    
    void Start()
    {
        StartCoroutine(EndSequence());
    }
    //Elindul az EndSequence, amikor utkozes lesz/ vege lesz a kornek
    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(3);
        liveCoins.SetActive(false);
        liveDistance.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        //ez azert 0 mert ez volt elsonek hozzaadva a buildhez, ha 1es akkor a masik scene jon be
        SceneManager.LoadScene(0);
    }

}
