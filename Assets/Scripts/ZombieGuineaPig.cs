using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieGuineaPig : GuineaPig
{
    [SerializeField] private GuineaPig playerGuineaPig;
    [SerializeField] private GuineaPig enemyGuineaPig;
    [SerializeField] private AIPath aiPath;
    [SerializeField] private TextMeshProUGUI alliesText;
    private Animator anim;
    private Rigidbody2D rb;
    protected float hp = 3;
    protected float currentHP;
    protected float coins = 0;
    protected float damage = 1;
    public override float HP
    {
        get { return hp; }
        set { hp = value; }
    }
    public override float CurrentHP
    {
        get { return currentHP; }
        set { currentHP = value; }
    }
    public override float Coins
    {
        get { return coins; }
        set { coins = value; }
    }
    public override float Damage
    {
        get { return damage; }
        set { damage = value; }
    }

    private void Awake()
    {
        CurrentHP = HP;
    }
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    public override void Attack(float damage)
    {
        playerGuineaPig.TakeDamage(damage);
    }
    public override void TakeDamage(float damage)
    {
        CurrentHP = Mathf.Clamp(CurrentHP - damage, 0, HP);
        if (CurrentHP > 0)
        {
            anim.SetTrigger("hurt");
        }
        else
        {
            rb.bodyType = RigidbodyType2D.Static;
            anim.SetTrigger("death");
            playerGuineaPig.Allies += 1;
            alliesText.text = "Points: " + playerGuineaPig.Allies + "/10";
        }
    }
    public override void CollectFood(float power)
    {
        

    }
    public override void CollectCoins(float coins)
    {
        
    }
    private void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Attack(Damage);
        }
    }
    public override void Restart()
    {
        gameObject.SetActive(false);
    }
}
