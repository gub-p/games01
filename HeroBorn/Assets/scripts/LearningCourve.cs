using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCourve : MonoBehaviour
{
    private int CurrentAge = 30;
    public int AddedAge = 1;

    public float Pi = 3.14f;
    public string FirstName = "Harrison";
    public bool IsAuthor = true;

    public Transform CamTransform;
    public GameObject DirectionLight;
    public Transform LightTransform;


    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
        Debug.Log($"A string can have variables like {FirstName} inserted directly!");

        var hero = new Character();
        Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);
        CamTransform = this.GetComponent<Transform>();
    }

    /// <summary>
    /// Time for action - adding comments
    /// Computes a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }
}
