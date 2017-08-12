namespace VRTK.Examples
{

    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Vader : VRTK_InteractableObject
    {

        public GameObject blade;
        private bool active;
        private float currentBeamSize;
        private float beamExtendSpeed = 0;
        private Vector2 beamLimits = new Vector2(0f, 1f);
        private bool beamActive = false;
        private bool retract;
        public AudioSource audioSource;
        public GameObject sphereRed;
        public GameObject sphereGreen;

        public AudioClip On;
        public AudioClip Off;

        float timer = 0.0f; // begins at this value
        float timerMax = 3.0f; // event occurs at this value

        

        public override void StartUsing(GameObject usingObject)
        {
            base.StartUsing(usingObject);
            active = !active;
            if (active == true)
            {
                retract = false;
                blade.SetActive(true);
                beamExtendSpeed = 5f;
                audioSource.PlayOneShot(On, 1f);
            }
            if (active == false)
            {
                beamExtendSpeed = -5f;
                timerMax = timer + .25f;
                retract = true;
                audioSource.PlayOneShot(Off, 1f);
            }
        }

        // Use this for initialization
        protected void Start()
        {
            Physics.IgnoreCollision(sphereRed.GetComponent<Collider>(), sphereGreen.GetComponent<Collider>());
            active = false;
            blade.SetActive(false);
            currentBeamSize = beamLimits.x;
            blade.transform.localScale = new Vector3(1f, currentBeamSize, 1f);
            beamActive = (currentBeamSize >= beamLimits.y ? true : false);
            audioSource = GetComponent<AudioSource>();
        }

        protected override void Update()
        {
            timer += Time.deltaTime;
            base.Update();
        currentBeamSize = Mathf.Clamp(blade.transform.localScale.y + (beamExtendSpeed * Time.deltaTime), beamLimits.x, beamLimits.y);
        blade.transform.localScale = new Vector3(1f, currentBeamSize, 1f);
        beamActive = (currentBeamSize >= beamLimits.y ? true : false);

            if (retract == true)
            {
                if (timer >= timerMax)
                {
                    blade.SetActive(false);
                }
            }
        }

    }
}
