using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private KeyCode keyCodeAttack = KeyCode.Space;
    [SerializeField] private string nextSceneName;
    public float speed;
    private Bullet bullet;
    
    private Animator anim;
    public GameObject explosionPrefab;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        bullet = GetComponent<Bullet>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 curPos = transform.position;
        Vector3 nextPos = new Vector3(x, y, 0) * speed * Time.deltaTime;
        

        if (Input.GetKeyDown(keyCodeAttack))
        {
            bullet.StartFiring();
        }
        else if (Input.GetKeyUp(keyCodeAttack))
        {
            bullet.StopFiring();
        }

        transform.position = curPos + nextPos;

        if (Input.GetButtonDown("Horizontal") || Input.GetButtonUp("Horizontal"))
        {
            anim.SetInteger("Input", (int)x);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
            //부딪힌 객체의 태그를 비교해서 적인지 판단합니다.
        {
            /* 여기서 부터 추가된 부분*/
            Instantiate(explosionPrefab,
                this.transform.position,
                Quaternion.identity);
            Destroy(other.gameObject);
            //적을 파괴합니다.
            Destroy(this.gameObject);
            //자신을 파괴합니다.
        }
    }
}
