using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    /*int[] arrayNumber = new int[10];
    Enemy[] enemyList = new Enemy[10];

    List<int> listNumber = new List<int>();
    List<Enemy> eList = new List<Enemy>();*/
    List<Character> characterList;
    void Start()
    {
        characterList = new List<Character>();

        PrintAllCharacter();

        CreateCharacter(new Character("ashe", "archer", 100, 30));
        CreateCharacter(new Character("ezreal", "ad", 100, 40));
        CreateCharacter(new Character("sett", "knight", 300, 10));

        RemoveCharacter(2);
        CreateCharacter(new Character("mesh", "knight", 300, 10));

        PrintAllCharacter();
    }

    void CreateCharacter(Character c)
    {
        characterList.Add(c);
    }

    void RemoveCharacter(int index)
    {
        characterList.RemoveAt(index);
    }

    void PrintAllCharacter()
    {
        int i = 0;

        if (characterList.Count == 0)
        {
            Debug.Log("비어있습니다.");
        }

        while(i < characterList.Count)
        {
            characterList[i].GetCharacterInfo();
            i++;
        }
    }


}
