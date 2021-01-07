using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Boom : MonoBehaviour
{
    public string nextLevel;
    private Animator animator; //this creates a variable called animator

    void Awake()
    {
        //this assigns the gameObjects Animator to the variable animator
        animator = GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        //this changes the bool parameter to true and triggers the "Boom" animation
        animator.SetBool("Collision", true);
        Invoke("ChangeLevel", .5f);
    }

    void ChangeLevel()
    {
        //this restarts the current level
        SceneManager.LoadScene(nextLevel);
    }

}
