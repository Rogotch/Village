using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Unit : UnitStateMachine
{
    public Transform hands_transform;
    public float speed_multiplayer = 1.0f;
    public Ease playerEasy;

    protected Vector2 speed_force = Vector2.zero;
    protected List<Vector2> pathArr = new List<Vector2>();
    protected Rigidbody2D Unit_rb;

    private bool moveFlag = false;


    public Vector2 Target;

    private Vector2 position;
    private Camera cam;
    private float step = 0;

    // Start is called before the first frame update
    void Start()
    {
        Unit_rb = GetComponent<Rigidbody2D>();
        position = gameObject.transform.position;
        Target = position;

        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        speed_force = Vector2.Lerp(speed_force, Vector2.zero, 0.01f);
        position = gameObject.transform.position;

        step = Mathf.Lerp(step, 0, 0.001f);

        if (Vector2.Distance(position, Target) > 1f)
        {
            //step = Mathf.Lerp(step, 10 * Time.deltaTime, 0.001f);
            step = 10 * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, Target, step);
        }
        
        else if ((pathArr.Count > 0))
        {
            pathArr.RemoveAt(0);
            if ((pathArr.Count > 0))
            {
                Target = pathArr[0];
            }
        }
    }

    void OnGUI()
    {
        Event currentEvent = Event.current;
        Vector2 mousePos = new Vector2();
        Vector2 point = new Vector2();

        // compute where the mouse is in world space
        mousePos.x = currentEvent.mousePosition.x;
        mousePos.y = cam.pixelHeight - currentEvent.mousePosition.y;
        point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 0.0f));

        if (Input.GetMouseButtonDown(0))
        {
            if (pathArr.Count == 0)
            {
                Debug.Log(Target);
                Target = point;
            }
            pathArr.Add(point);
        }
    }

    public void Shake()
    {
        Sequence shakeSequence = DOTween.Sequence();
        float rotationValue = 30f;
        //hands_transform
        //    .DOLocalRotate(new Vector3(0, 0, rotationValue), 0.5f)
        //    .SetEase(playerEasy)
        //    .SetLoops(2, LoopType.Yoyo);
        shakeSequence.Append(
            hands_transform
            .DOLocalRotate(new Vector3(0, 0, rotationValue), 0.5f)
            .SetDelay(0.5f));
        shakeSequence.Append(
            hands_transform
            .DOLocalRotate(new Vector3(0, 0, -rotationValue), 0.5f)
            .SetDelay(0.5f, true));
        //shakeSequence.Append(hands_transform.DOLocalRotate(new Vector3(0, 0, rotationValue), 0.5f));
        shakeSequence.SetLoops(-1, LoopType.Yoyo);
    }
}
