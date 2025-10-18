using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{

    public string nextLevel = "Scene_2";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);


        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    Debug.Log("Death");
                    break;
                }

            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    Debug.Log("Finish");
                    break;

                }

        }



    }
}


