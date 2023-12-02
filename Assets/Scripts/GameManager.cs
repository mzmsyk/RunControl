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
    public void CharacterManager(string blockData, Transform blockPos)
    {
        switch (blockData)
        {
            case "x2":
                int circleCount = 0;
                foreach (var item in AICharacters)
                {
                    if (circleCount < characterCount)
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
            case "+3":
                int circleCount2 = 0;
                foreach (var item in AICharacters)
                {
                    if (circleCount2 < 3)
                    {
                        if (!item.activeInHierarchy)
                        {
                            item.transform.position = blockPos.position;
                            item.SetActive(true);
                            circleCount2++;

                        }
                    }
                    else
                    {
                        circleCount2 = 0;
                        break;
                    }
                }
                characterCount += 3;
                break;
            case "-4":
                if (characterCount < 4)
                {
                    foreach (var item in AICharacters)
                    {
                        item.transform.position = Vector3.zero;
                        item.SetActive(false);
                    }
                    characterCount = 1;
                }
                else
                {
                    int circleCount3 = 0;
                    foreach (var item in AICharacters)
                    {
                        if (circleCount3 != 4)
                        {
                            if (item.activeInHierarchy)
                            {
                                item.transform.position = Vector3.zero;
                                item.SetActive(false);
                                circleCount3++;
                            }
                        }
                        else
                        {
                            circleCount3 = 0;
                            break;
                        }
                    }
                    characterCount -= 4;
                }


                break;
            case "/2":
                if (characterCount <= 2)
                {
                    foreach (var item in AICharacters)
                    {
                        item.transform.position = Vector3.zero;
                        item.SetActive(false);
                    }
                    characterCount = 1;

                }
                else
                {
                    int countCircle = characterCount / 2;
                    int circleCount4 = 0;
                    foreach (var item in AICharacters)
                    {
                        if (circleCount4 != countCircle)
                        {
                            if (item.activeInHierarchy)
                            {
                                item.transform.position = Vector3.zero;
                                item.SetActive(false);
                                circleCount4++;
                            }
                        }
                        else
                        {
                            circleCount4 = 0;
                            break;
                        }
                    }
                    if (characterCount%2==0)
                    {
                        characterCount /= 2;
                    }
                    else
                    {
                        characterCount /= 2;
                        characterCount++;
                    }
                    
                }


                break;
        }
    }
}
