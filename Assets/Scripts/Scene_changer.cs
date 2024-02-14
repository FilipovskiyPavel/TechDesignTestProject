using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_changer : MonoBehaviour
{
    [SerializeField] private int _scene_index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change_scene()
    {
        SceneManager.LoadScene(_scene_index);
    }
}
