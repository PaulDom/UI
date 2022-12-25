using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int health = 10;
    public int maxHealth = 10;

    //����� ������������
    public string sceneload;
    //������, ���������� �� ������������ �����
    public AudioSource audioSource;
    //�������� ����, ���������� ���� �����
    public AudioClip damageSound;

    public GameObject platform;

    //�����, ���������� �������� ������
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health > 0)
        {
            print("�������� ������: " + health);
            audioSource.PlayOneShot(damageSound);
        }
        else
        {
            SceneManager.LoadScene(sceneload);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Lever")
        {
            Platform platformscript = platform.GetComponent<Platform>();
            platformscript.Move();
        }
    }
}

