using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class PickUpItem : MonoBehaviour {

    private GameObject[] itemsToPickFrom;
    private GameObject currentHeldItem;
    void Start()
    {
        itemsToPickFrom = GameObject.FindGameObjectsWithTag("Ingredient");

    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            currentHeldItem.transform.parent = null;
            currentHeldItem.transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f, 0);
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if(col.tag == "Ingredient" && Input.GetKeyDown(KeyCode.Space))
        {
            col.gameObject.transform.SetParent(this.transform);
            col.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y+1.2f, 0);
            currentHeldItem = col.gameObject;
        }
        if(col.tag == "Door")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
