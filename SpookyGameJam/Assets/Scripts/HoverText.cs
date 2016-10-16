using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HoverText : MonoBehaviour {

    [SerializeField]
    GameObject ingredient;
    [SerializeField]
    Text itemText;
    [SerializeField]
    string hoverText;

    private float height, width;
    private float textPos;
    private string currText;

    // Use this for initialization
    void Start () {
        height = ingredient.transform.position.y;
        width = ingredient.transform.position.x;
        textPos = height + 0.65f;
        currText = "";
        itemText.rectTransform.position = new Vector2(width, textPos);
	
	}
	
	// Update is called once per frame
	void Update () {
        itemText.text = currText;
	}

    void OnMouseEnter()
    {
        height = ingredient.transform.position.y;
        width = ingredient.transform.position.x;
        currText = hoverText;
    }

    void OnMouseExit()
    {
        currText = "";
    }
}
