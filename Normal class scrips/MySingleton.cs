using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySingleton
{
    public static string currentDirection = "?";
    private static Room[] theRooms = new Room[100];
    private static int numRooms = 0;
    public static Room theCurrentRoom = null;
    public static Dungeon theDungeon = null;
    
    public static void generateDungeon()
    {
        Room r1 = new Room("R1");
        Room r2 = new Room("R2");
        Room r3 = new Room("R3");
        Room r4 = new Room("R4");
        Room r5 = new Room("R5");
        Room r6 = new Room("R6");

        r1.addExit("north", r2);
        r2.addExit("south", r1);
        r2.addExit("north", r3);
        r3.addExit("south", r2);
        r3.addExit("west", r4);
        r3.addExit("north", r6);
        r3.addExit("east", r5);
        r4.addExit("east", r3);
        r5.addExit("west", r3);
        r6.addExit("south", r3);

        MySingleton.theDungeon = new Dungeon("the cross");
        MySingleton.theDungeon.setStartRoom(r1);
        

    }

   
    
        
    
    public static void addRoom(Room r)
    {
        //static context
        MySingleton.theRooms[numRooms] = r;
        MySingleton.numRooms++;   
    }
    
}