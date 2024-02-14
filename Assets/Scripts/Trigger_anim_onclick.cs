using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_anim_onclick : MonoBehaviour
{
    [SerializeField] private string _tag;
    [SerializeField] private string _anim_trigger_name;
    [SerializeField] private AudioSource _clip;
    [SerializeField] private AudioClip _name;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = (Vector2)mousePos;
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null && hit.collider.CompareTag(_tag)) 
            {
                TrigerAnim(hit.collider.GetComponent<Animator>());
            }
        }
    }
    public void TrigerAnim(Animator anim)
    {
        anim.SetTrigger(_anim_trigger_name);
        _clip.PlayOneShot(_name);
    }
}
