using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class PickUpItem : MonoBehaviour {

    private GameObject[] itemsToPickFrom;
    private GameObject currentHeldItem;
    private GameObject itemToPickUp;

    void Start()
    {
        itemsToPickFrom = GameObject.FindGameObjectsWithTag("Ingredient");

    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space) && currentHeldItem != null)
        {
            currentHeldItem.transform.parent = null;
            currentHeldItem.transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f, 0);
            currentHeldItem.GetComponent<ItemBehavior>().isPickedUp = false;
            currentHeldItem = null;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ingredient")
        {
            itemToPickUp = col.gameObject;
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Ingredient")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                itemToPickUp.transform.SetParent(this.transform);
                itemToPickUp.transform.position = new Vector3(transform.position.x, transform.position.y + 1.2f, 0);
                currentHeldItem = itemToPickUp;
                itemToPickUp.GetComponent<ItemBehavior>().isPickedUp = true;
            }
        }
        if (col.tag == "Door" && GameObject.Find("GameManager").GetComponent<Manager>().canFinishLevel == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
