using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class AIMove : MonoBehaviour
{
    float movementSpeed = 3f;
    public GameObject[] points;
    public GameObject currTarget;
    public bool PointReached;
    bool isTrue = true;
    float step;
    float timer;
    float LookAtStoreValue = 2;
    AI ai;
    int targetIndex;
    public bool HasStayed;
    public GameObject test;

    public Sprite mugShot;
	public static AIMove aiWithPassport;
	public Pocket pocket;
	public GameObject passportPrefab;

    public void Awake()
    {
        ai = GameObject.FindGameObjectWithTag("AiController").GetComponent<AI>();
    }

    public void Start()
    {
        //  print(ai.gameObject.name + "test");
        if (aiWithPassport == null)
        {
            aiWithPassport = this;
            pocket.SetContents(passportPrefab);
        }
        else
        {
            pocket.SetRandomContents();
        }
        TargetMugShot.instance.UpdateMugShot();
        TargetGen();
    }

    public void TargetGen()
    {
       targetIndex = Random.Range(0, ai.Spawners.Length);
        currTarget = ai.Spawners[targetIndex].gameObject;
    }

    void OnTriggerEnter(Collider col)
    {     //Check if point reached
        if (col.gameObject.tag == "PointColl")
        {
            Debug.Log("Collided");
            HasStayed = true;
        }

    }

    public void Update()
    {
        Debug.Log(aiWithPassport);
      //  Debug.Log(timer);

        PointReached = true;

        step = movementSpeed * Time.deltaTime;
        Move();

        if(PointReached == true)
        {
            timer += Time.deltaTime;
        }
        if (timer >= LookAtStoreValue)
        {
            TargetGen();
            PointReached = true;
            HasStayed = false;
            timer = 0;
        }

    }
    
    void Move()
    {
        if (isTrue)
        {
            //move towards the array point at "Step" speed
            transform.position = Vector3.MoveTowards(transform.position, currTarget.transform.position, step);
        }
    }
} 