using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Item {

    //string icon;
    string name;
    Sprite iconImage;

    public Item(string name) : this()
    {
        //Icon = spriteName;
        Name = name;
        //IconImage = Resources.Load<Sprite>("Sprites/things01");
    }

    //public string Icon { get; set; }
    public string Name { get; set; }
    public Sprite IconImage { get; set; } 
}
