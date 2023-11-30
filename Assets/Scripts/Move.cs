using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform childTransform; // 자식 게임 오브젝트의 Transform
    // Start is called before the first frame update
    void Start()
    {
        // 내 전역 위치를 (0, -1, 0)으로
        transform.position = new Vector3(0, -1, 0);

        // 자식의 지역 위치를 (0, 2, 0)으로
        childTransform.localPosition = new Vector3(0, 2, 0);

        // 내 전역 회전을 (0, 0, 30)으로
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));

        // 자식의 지역 회전을 (0, 60, 0)으로
        childTransform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // 위쪽 방향키를 누르면 초당 (0, 1, 0) 평행이동
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // 아래쪽 방향키를 누르면 초당 (0, -1, 0) 평행이동
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // 왼쪽 방향키를 누르면 초당 (0, 0, 180 회전)
            transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime);
            // 자식을 초당 (0, 180, 0) 회전
            childTransform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // 오른쪽 방향키를 누르면 초당 (0, 0, -180 회전)
            transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime);
            // 자식을 초당 (0, -180, 0) 회전
            childTransform.Rotate(new Vector3(0, -180, 0) * Time.deltaTime);
        }
    }
}
