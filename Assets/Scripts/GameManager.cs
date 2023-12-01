using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    //public GameObject startPoint;
    public GameObject spawnPoint;

    public List<GameObject> AICharacters;
    public int characterCount=1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.A))
        {
            foreach (var item in AICharacters)
            {
                if (!item.activeInHierarchy)
                {
                    item.transform.position = startPoint.transform.position;
                    item.SetActive(true);
                    characterCount++;
                    break;
                }
                
            }
        }*/
    }
    public void CharacterManager(string blockData,Transform blockPos)
    {
        switch (blockData)
        {
            case "x2":
                int circleCount = 0;
                foreach (var item in AICharacters)
                {
                    if (circleCount<characterCount)
                    {
                        if (!item.activeInHierarchy)
                        {
                            item.transform.position = blockPos.position;
                            item.SetActive(true);
                            circleCount++;
                            
                        }
                    }
                    else
                    {
                        circleCount = 0;
                        break;
                    }
                }
                characterCount *= 2;
                break;
        }
    }
}
