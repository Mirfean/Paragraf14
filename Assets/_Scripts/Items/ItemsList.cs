using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsList : MonoBehaviour {

    Sprite[] sprites;
    List<Item> items;

	// Use this for initialization
	void Start () {
        Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/");
        MakeItems();
        FindSprites();

    }

    // Update is called once per frame
    void Update () {
		
	}

    private void MakeItems()
    {
        items.Add(new Item("Gun01"));
        items.Add(new Item("Knife"));
        items.Add(new Item("Blue_Diamond"));
    }

    private void FindSprites()
    {
        
        foreach (Sprite sp in sprites)
        {
            if (sp.name == "things02_1")
                this.GetComponent<SpriteRenderer>().sprite = sp; //currentItem.IconImage;
        }
    }

}
