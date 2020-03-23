using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string name;
    public int id;

    public static int connectionCount;

    public Player()
    {
        connectionCount++;
    }
}

public class PlayersCounter : MonoBehaviour
{
    private void Start()
    {
        Player p1 = new Player();
        Player p2 = new Player();
        Player p3 = new Player();

        Debug.Log("Players connected: " + Player.connectionCount);
    }
    
}
