using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public GameObject preFab;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private const float Timer = 0.5f;
    private float _currentTime = 0.5f;
    private bool _canShoot = true;


    private void Update()
    {

        if (!_canShoot)
        {

            _currentTime -= Time.deltaTime;

           if(_currentTime < 0)
            {

                _canShoot = true;
                _currentTime = Timer;
            }

        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && _canShoot)
        {

            GameObject bullet = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);

            

        }

    }

}
