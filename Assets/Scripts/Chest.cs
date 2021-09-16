﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int rubiesAmount = 5;

    protected override void OnCollect()
    {
        if(!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            GameManager.instance.ShowText("+" + rubiesAmount + " Rubies!", 25, Color.red, transform.position, Vector3.up * 25, 1.5f);
        }
    }

}
