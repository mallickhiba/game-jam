using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCat : MonoBehaviour{

    public GameObject greyCat;
    public GameObject whiteCat;
    public GameObject orangeCat;

    public void greyCatOn(){
        greyCat.SetActive(true);
    }
    public void whiteCatOn(){
        whiteCat.SetActive(true);
    }
    public void orangeCatOn(){
        orangeCat.SetActive(true);
    }
}
    
