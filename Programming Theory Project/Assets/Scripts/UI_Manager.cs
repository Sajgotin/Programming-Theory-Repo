using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] Camera camera1;
    [SerializeField] Camera camera2;
    [SerializeField] GameObject titleScreenUI;
    [SerializeField] GameObject characterInfoUI;
    public TextMeshProUGUI classText;
    public TextMeshProUGUI hpText;
    public TextMeshProUGUI dmgText;
    public TextMeshProUGUI defText;
    public interface IUIInfoContent
    {
        string GetName();
        string GetData();
    }

    public void StartProject()
    {
        camera1.gameObject.SetActive(false);
        camera2.gameObject.SetActive(true);
        titleScreenUI.SetActive(false);
        characterInfoUI.SetActive(true);
    }

    private void Update()
    {
        // ABSTRACTION
        CheckingInput();
    }

    void CheckingInput()
    {
        if (Input.GetMouseButtonDown(0) && camera2.isActiveAndEnabled)
        {
            var ray = camera2.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Enemy"))
            {
                //the collider could be children of the unit, so we make sure to check in the parent
                var enemy = hit.collider.GetComponentInParent<Enemy>();
                classText.SetText("Class: " + enemy.CharacterClass);
                hpText.SetText("HP: " + enemy.Hp.ToString());
                dmgText.SetText("DMG: " + enemy.Dmg.ToString());
                defText.SetText("DEF: " + enemy.Def.ToString());
                enemy.Attack();
                enemy.Guard();
            }
        }
    }
}
