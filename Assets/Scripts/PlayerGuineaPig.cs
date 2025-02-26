using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGuineaPig : GuineaPig
{
    [SerializeField] private TextMeshProUGUI coinsText;
    [SerializeField] private GuineaPig enemyGuineaPig;
    private Animator anim;
    private Rigidbody2D rb;
    protected float hp = 5;
    protected float currentHP;
    protected float coins = 0;
    protected float damage = 1;
    protected float allies = 0;
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
    public override float Allies
    {
        get { return allies; }
        set { allies = value; }
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
        enemyGuineaPig.TakeDamage(damage);
    }
    public override void TakeDamage(float damage)
    {
        CurrentHP = Mathf.Clamp(CurrentHP - damage, 0, HP);
        if(CurrentHP > 0) 
        {
            anim.SetTrigger("hurt");
        }
        else 
        {
            rb.bodyType = RigidbodyType2D.Static;
            anim.SetTrigger("death");
        }
    }
    public override void CollectFood(float power)
    {
        CurrentHP = Mathf.Clamp(CurrentHP + power, 0, HP);
        Coins += coins;
       
    }
    public override void CollectCoins(float coins)
    {
        Coins += coins;
        coinsText.text = "Coins: " + Coins;
    }
    public override void Restart()
    {
        
    }
}

