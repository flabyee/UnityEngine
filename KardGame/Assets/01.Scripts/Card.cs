using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "AfterSchool/CardGame/Card")]
public class Card : ScriptableObject
{
    public string id;
    public string tagString;    // ������°���

    public bool usable;
    public bool disposable; // 1ȸ�� ī��

    public CardPower power;

    public void Init(string id, string tagString, CardPower defaultCP, bool dispose = false, bool usable = true)
    {
        this.id = id;
        this.tagString = tagString;
        this.disposable = dispose;

        power = defaultCP;
    }

    public Card Clone(bool setDispose = false)
    {
        var card = CreateInstance<Card>();  // ScriptableObject / new�� ���
        bool dispose = setDispose || this.disposable;   // ���� �� �� ���� 1ȸ���� �ƴ� ī�带 1ȸ������ ����� �� �� �ִ�?
        card.Init(id, tagString, power, dispose);   
        return card;
    }

    public void OnUse()
    {
        Debug.Log("Card Use : " + power.cardName);
    }
    public void OnDraw()
    {
        Debug.Log("Card Draw : " + power.cardName);
    }
    public void OnDrop()
    {
        Debug.Log("Card Drop : " + power.cardName);
    }
    public void OnTurnEnd()
    {
        Debug.Log("TurnEnd : " + power.cardName);
    }
}
