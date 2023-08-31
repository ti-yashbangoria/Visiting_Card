using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Information_Manager : MonoBehaviour
{
    [SerializeField] private GameObject info_Holder;

    [SerializeField] private Animator character_Aniamator;
    [SerializeField] private AudioSource audioSource;

    [Header("Buttons")]
    [SerializeField] private GameObject agumentedReality;
    [SerializeField] private GameObject enterpriseMobility;
    [SerializeField] private GameObject virtualReality;
    [SerializeField] private GameObject contactUs;
    [SerializeField] private GameObject website;

    [DllImport("__Internal")]
    private static extern void AgumentedReality();

    [DllImport("__Internal")]
    private static extern void EnterpriseMobility();

    [DllImport("__Internal")]
    private static extern void VirtualReality();

    [DllImport("__Internal")]
    private static extern void ContactUs();

    [DllImport("__Internal")]
    private static extern void Website();

    void Start()
    {
        HideCharacter_Holder();
        DisableButtons();
    }

    public void HideCharacter_Holder()
    {
        info_Holder.SetActive(false);
    }

    public void Onseen()
    {
        StopCoroutine(nameof(ShowButtons));

        character_Aniamator.enabled = true;
        character_Aniamator.Play("Base Layer.new");

        audioSource.Play();

        DisableButtons();

        StartCoroutine(nameof(ShowButtons));
    }

    public void OnNotSeen()
    {
        StopCoroutine(nameof(ShowButtons));

        audioSource.Stop();

        character_Aniamator.StopPlayback();
        character_Aniamator.enabled = false;

        DisableButtons();
    }

    IEnumerator ShowButtons()
    {
        yield return new WaitForSeconds(7f);
        agumentedReality.gameObject.SetActive(true);

        yield return new WaitForSeconds(1f);
        enterpriseMobility.gameObject.SetActive(true);

        yield return new WaitForSeconds(1f);
        virtualReality.gameObject.SetActive(true);

        yield return new WaitForSeconds(2f);
        contactUs.gameObject.SetActive(true);

        yield return new WaitForSeconds(6.5f);
        website.gameObject.SetActive(true);
    }

    private void DisableButtons()
    {
        agumentedReality.gameObject.SetActive(false);
        enterpriseMobility.gameObject.SetActive(false);
        virtualReality.gameObject.SetActive(false);
        contactUs.gameObject.SetActive(false);
        website.gameObject.SetActive(false);
    }

    #region Test
    public void Play()
    {
        info_Holder.SetActive(true);
        Onseen();
    }

    public void Stop()
    {
        OnNotSeen();
    }
    #endregion


    #region Button 
    public void _AgumentedReality()
    {
        AgumentedReality();
    }

    public void _EnterpriseMobility()
    {
        EnterpriseMobility();
    }

    public void _VirtualReality()
    {
        VirtualReality();
    }

    public void _ContactUs()
    {
        ContactUs();
    }

    public void _Website()
    {
        Website();
    }

    #endregion
}
