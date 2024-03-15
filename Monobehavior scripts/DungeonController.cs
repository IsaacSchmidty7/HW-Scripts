using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonController : MonoBehaviour
{
    public GameObject northDoor, southDoor, eastDoor, westDoor;

    void Start()
    {
        Room theCurrentRoom = MySingleton.thePlayer.getCurrentRoom();
        if(theCurrentRoom.hasExit("north"))
        {
            this.northDoor.SetActive(false);
        }

        if (theCurrentRoom.hasExit("south"))
        {
            this.southDoor.SetActive(false);
        }

        if (theCurrentRoom.hasExit("east"))
        {
            this.eastDoor.SetActive(false);
        }

        if (theCurrentRoom.hasExit("west"))
        {
            this.westDoor.SetActive(false);
        }

        Room theEnterRoom = MySingleton.Dungeon.enterRoom();
        if( MySingleton.theDungeon.setStartRoom(r1))
        {
            this.currentRoom = r2;
        }
        if( this.currentRoom = r2)
        {
            this.currentRoom = r3;
        }
         if( this.currentRoom = r3)
        {
            this.currentRoom = r4;
        }
         if( this.currentRoom = r4)
        {
            this.currentRoom = r5;
        }
         if( this.currentRoom = r5)
        {
            this.currentRoom = r6;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}