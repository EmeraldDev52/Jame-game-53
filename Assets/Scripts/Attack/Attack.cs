using System.Collections;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject bulletPrefab;
    [SerializeField] private int reloadTime;
    [SerializeField] private bool canShoot;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (canShoot == true)
            {
                Instantiate(bulletPrefab, transform.position, transform.rotation);
                canShoot = false;
                StartCoroutine("reload");
            }
        }
    }

    IEnumerator reload()
    {
        yield return new WaitForSeconds(reloadTime);
        canShoot = true;
    }
}
