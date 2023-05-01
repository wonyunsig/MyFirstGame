using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject ProjectPrefab;
    [SerializeField] private float attackRate = 0.1f;

    public void StartFiring()
    {
        StartCoroutine("TryAttack");
    }

    public void StopFiring()
    {
        StopCoroutine("TryAttack");
    }

    private IEnumerator TryAttack()
    {
        while (true)
        {
            Instantiate(ProjectPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(attackRate);
        }
    }
}
