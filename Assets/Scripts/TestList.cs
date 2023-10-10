using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestList : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BadGuy bg1 = new BadGuy("Harvey", 50);
        BadGuy bg2 = new BadGuy("Magneto", 100);
        BadGuy bg3 = new BadGuy("Mary", 5);

        List<BadGuy> badguys = new List<BadGuy>();
        badguys.Add(bg1);
        badguys.Add(bg2);
        badguys.Add(bg3);

        print("List size: " + badguys.Count);

        foreach (BadGuy bg in badguys)
        {
            print(bg.name + " " + bg.power);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
