using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keyholder : MonoBehaviour
{
    private List<key.Keytype> keyList;

    private void Awake()
    {
        keyList = new List<key.Keytype>();
    }

    public void AddKey(key.Keytype keytype)
    {
        Debug.Log("you found a key");
        keyList.Add(keytype);
    }

    public void RemoveKey(key.Keytype keyType)
    {
        keyList.Remove(keyType);
    }

    public bool ContainsKey(key.Keytype keyType)
    {
        return keyList.Contains(keyType);
    }

    private void OnTriggerEnter(Collider collider)
    {
        key key = collider.GetComponent<key>();
        if(key != null)
        {
            AddKey(key.GetKeyType());
            Destroy(key.gameObject);
        }

        keyDoor keyDoor = collider.GetComponent<keyDoor>();
        if(keyDoor != null)
        {
            if (ContainsKey(keyDoor.GetKeyType()))
            {
                Debug.Log("You win");
                SceneManager.LoadScene("Main menu");
            }
        }
    }
}
