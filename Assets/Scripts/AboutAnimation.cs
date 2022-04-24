using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutAnimation : MonoBehaviour
{
    public GameObject objek;
    Transform cachedTransform;
    int levelindex;
    // Start is called before the first frame update
    void Start()
    {
        cachedTransform = transform;

        levelindex = SceneManager.GetActiveScene().buildIndex;

    }
    // Update is called once per frame
    void Update()
    {
        if (cachedTransform.position.y >= 1300)
        {
            // SceneManager.LoadScene(levelindex); 
        objek.SetActive(false);  
        }
    }
    
}
