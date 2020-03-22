using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public Item[] items;

    public Item pistol;
    public Item rifle;
    public Item sword;

    private void Start()
    {
        CreateItem();
    }
    private void CreateItem()
    {
        pistol = new Item("m1911", 1, "This is a legendary classic!");
        rifle = new Item("Ak-47", 2, "This is a russian kill machine!");
        sword = new Item("Sword", 3, "Meh, just an iron sword..");
    }
}
