//using UnityEngine;

//public class First_Ball : MonoBehaviour
//{

//    //Vector3 vec = new Vector3(5.3f, 3.9f, 33.3f);
//    Rigidbody rigid;
//    MeshCollider mesh;
//    Material mat;

//    void Start()
//    {
//        rigid = GetComponent<Rigidbody>();
        
//    }
//    void FixedUpdate()
//    {
//        rigid.angularVelocity = Vector3.right;
//        if (Input.GetButtonDown("Jump"))
//        {
//            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
//        }

//        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), 
//            Input.GetAxis("Jump"), Input.GetAxis("Vertical"));

//        rigid.AddForce(vec * 5, ForceMode.Impulse);

//        // 회전력

//        rigid.AddTorque(Vector3.down*3);
//    }

//    private void OnTriggerStay(Collider something)
//    {
//        if (something.name == "Cube")
//            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
//    }

//    public void Jump()
//    {
//        rigid.AddForce(Vector3.up * 30, ForceMode.Impulse);
//    }

    //void Update()
    //{

    //    //if (Input.anyKeyDown)
    //    //{
    //    //    Debug.Log("플레이어가 아무키나 눌렀습니다.");
    //    //}
    //    //if (Input.anyKey)
    //    //{
    //    //    Debug.Log("아무키나 누르고 있습니다.");
    //    //}

    //    //if (Input.GetKeyDown(KeyCode.Return)) // Return = Enter
    //    //    Debug.Log("아이템을 구매했습니다.");

    //    //if (Input.GetKey(KeyCode.LeftArrow)) 
    //    //    Debug.Log("왼쪽으로 이동중");

    //    //if (Input.GetKeyUp(KeyCode.RightArrow))
    //    //    Debug.Log("오른쪽 이동을 멈추었습니다.");

    //    //if (Input.GetMouseButtonDown(0))
    //    //    Debug.Log("미사일 발사");

    //    //if (Input.GetMouseButton(0))
    //    //    Debug.Log("차지중");

    //    //if (Input.GetMouseButtonDown(0))
    //    //    Debug.Log("슈퍼 미사일 발사!");




    //    //Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), 
    //    //    Input.GetAxisRaw("Jump"), Input.GetAxisRaw("Vertical"));
    //    //transform.Translate(vec);


    //    // 1.MoveTowards = 등속 이동 (현재위치, 목표위치, 속도)
    //    //transform.position =
    //    //    Vector3.MoveTowards(transform.position, 
    //    //    vec, 0.1f);

    //    // 2.SmoothDamp (현재위치, 목표위치, 참조속도, 속도)

    //    //Vector3 value =  Vector3.zero;
    //    //transform.position =
    //    //    Vector3.SmoothDamp(transform.position,
    //    //    vec, ref value, 0.20f);

    //    // 3.Lerp (선형 보간)
    //    //transform.position =
    //    //    Vector3.Lerp(transform.position,
    //    //   vec, 0.01f);

    //    // 4.Slerp (구면 선형 보간)
    //    //transform.position =
    //    //    Vector3.Slerp(transform.position,
    //    //   vec, 0.001f);

    //    // Time.delTatime => 프레임이 적으면 크고, 프레임이 많으면 작음



    //}