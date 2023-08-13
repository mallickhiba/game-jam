using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBehaviour : MonoBehaviour
{
    //public float rotationSpeed;
    public GameObject itemPrefab;
    public GameObject itemSpawnPoint;

    public static int score = 0;
    //public Text text;
    GameObject itemTemp;
    public GameObject hitEffect;
    public float towerHealth = 100;

    //public Slider healthBar;
    public float timeBetweenShots = 0.25f;

    private float timestamp;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {  
            itemTemp = Instantiate(itemPrefab, itemSpawnPoint.transform.position, itemSpawnPoint.transform.rotation);
            timestamp = Time.time + timeBetweenShots;
            itemTemp.GetComponent<itemBehaviour>().textScore = text;
    }
    
     void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "enemy")
        {
            GameObject hitTemp = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(hitTemp, 1);
            Destroy(collider.gameObject);
            towerHealth -= 20;
            healthBar.value= towerHealth;

            if (towerHealth == 0)
            {
                StartCoroutine(RandomSpawner.WaitForRestart());
                gameObject.transform.localScale = new Vector3(0,0,0);
            }
        }

        if (collider.gameObject.tag == "boss")
        {
            GameObject hitTemp = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(hitTemp, 1);
            Destroy(collider.gameObject);
            towerHealth =0;
            healthBar.value= towerHealth;
            StartCoroutine(RandomSpawner.WaitForRestart());
            gameObject.transform.localScale = new Vector3(0, 0, 0);
        }

    }
    

}
