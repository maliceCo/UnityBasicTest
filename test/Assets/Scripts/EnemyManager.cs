using DG.Tweening;
using System.Collections;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Transform[] bulletsOrigin;
    public GameObject bulletPrefab;
    private float remainingTime = 0.5f;
    private bool isPlaying;
    private float nextBullet = 0;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(2);
        isPlaying = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            isPlaying = false;

        if (isPlaying && nextBullet < Time.time)
        {
            nextBullet = Time.time + remainingTime;
            int pos = Random.Range(0, bulletsOrigin.Length);
            //TODO-> bullet pool
            GameObject bullet = Instantiate(bulletPrefab, bulletsOrigin[pos].position, Quaternion.identity);

            bullet.transform.DOMoveZ(-10, 2).SetEase(Ease.Linear);
        }
    }
    public void Stop()
    {
        isPlaying = false;
    }

}