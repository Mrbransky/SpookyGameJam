using UnityEngine;
using System.Collections;

public class ItemBehavior : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Cauldron")
        {
            Destroy(gameObject);
            GameObject.Find("GameManager").GetComponent<Manager>().numberOfIngredientsPlaced += 1;
        }
    }
}
