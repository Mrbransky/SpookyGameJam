﻿using UnityEngine;
using System.Collections;

public class NPCBehavior : MonoBehaviour {

    public Manager manager;
    public Sprite spriteToChange;
    public GameObject poof;
    public RuntimeAnimatorController animToChangeTo;
	// Update is called once per frame
	void Update ()
    {
        if(manager.canFinishLevel == true)
        {
            poof.SetActive(true);
            GetComponent<SpriteRenderer>().sprite = spriteToChange;
            GetComponent<Animator>().enabled = true;
            GetComponent<Animator>().runtimeAnimatorController = animToChangeTo;
        }
	}
}
