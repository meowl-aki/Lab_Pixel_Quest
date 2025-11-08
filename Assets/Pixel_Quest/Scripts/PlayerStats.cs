using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public string nextLevel = "Scene_2";
    public int CoinCounter = 0;
    private int _maxHealth = 3;
    private int _health = 3;
    public Transform respawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Hit");


        switch(other.tag)
        {
            

            case "Death":
            {
                    _health--;
                    if (_health <= 0)
                    {
                        string thisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thisLevel);
                        Debug.Log("Death");
                    }
                    else
                    {
                        transform.position = respawnPosition.position;
                    }
                    break;
            }

            case "Health":
                {
                    if (_health < _maxHealth)
                    {
                        Destroy(other.gameObject);
                        _health++;
                    }
                    break;
                }

            case "Coin":
                {
                    CoinCounter++;
                    Destroy(other.gameObject);
                    break;
                }

            case "Finish":
                {
                    string nextLevel = other.transform.GetComponent<LevelGoal>().nextLevel;
                    SceneManager.LoadScene(nextLevel);
                    Debug.Log("Finish");
                    break;
                }

            
        }



    }
}


