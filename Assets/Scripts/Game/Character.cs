using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public abstract class Character : MonoBehaviour
{
    [SerializeField]
    private EnemyType myType;

    [SerializeField]
    private float maxHP;

    [SerializeField]
    private Bullet bullet;

    [SerializeField]
    private float shootForce = 20F;

    [SerializeField]
    private Transform bulletSpawnPosition;

    private float hp;

    public float HP
    {
        get { return hp; }
        protected set { hp = value; }
    }

    public float ShootForce { get { return shootForce; } }

    public EnemyType MyType { get => myType; protected set => myType = value; }

    public void ModifyHP(float delta)
    {
        HP += delta;

        if (HP <= 0F)
        {
            OnDeath();
        }
    }

    protected virtual void OnDeath()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        HP = maxHP;
    }

    protected void SpawnBullet()
    {
        if (bullet != null && bulletSpawnPosition != null)
        {
            Instantiate<Bullet>(bullet, bulletSpawnPosition.position, transform.rotation).Shoot(this);
        }
    }
}